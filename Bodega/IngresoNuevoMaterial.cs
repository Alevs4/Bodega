using Bodega.Datos;
using Bodega.Entidad;
using Bodega.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    public partial class IngresoNuevoMaterial : Form
    {
        public IngresoNuevoMaterial()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
           AgregarMaterial();
            this.Close();
        }
        public void Limpiar()
        {
            TxtNumFac.Text = "";
            TxtMaterial.Text = "";
            TxtMarca.Text = "";
            TxtCantidad.Text = "";
            TxtRecepcion.Text = "";
            TxtProv.Text = "";
        }
        private void AgregarMaterial()
        {
            if (TxtMaterial.Text == "" || TxtProv.Text == "" || TxtMarca.Text == "" || TxtCantidad.Text == "" || TxtRecepcion.Text == "" || TxtNumFac.Text == "")
            {

                MessageBox.Show("Se Deben ingresar todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EN_Materiales obj = new EN_Materiales();
                RN_Materiales materiales = new RN_Materiales();

                try
                {
                    obj.Proveedor = TxtProv.Text;
                    obj.Materiales = TxtMaterial.Text;
                    obj.Fecha = Fecha.Text;
                    obj.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                    obj.Receptor = TxtRecepcion.Text;
                    obj.Factura = TxtNumFac.Text;

                    materiales.RN_IngresoMateriales(obj);
                    materiales.RN_IngresoProductos(TxtMaterial.Text, TxtMarca.Text, Convert.ToInt32(TxtCantidad.Text));


                    if (BD_Materiales.Guardar == true)
                    {

                        MessageBox.Show("Producto Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Principal frm = new Principal();
                        frm.Cargar_Materiales();


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
