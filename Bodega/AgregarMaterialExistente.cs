using Bodega.Datos;
using Bodega.Entidad;
using Bodega.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    public partial class AgregarMaterialExistente : Form
    {

        public bool editPerso = false;
        public AgregarMaterialExistente()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        public void Limpiar()
        {
            TxtNumFac.Text = "";
            TxtCantidad.Text = "";
            TxtRecepcion.Text = "";
            TxtProv.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void AgregarMateriales()
        {
            if (TxtMaterial.Text == "" || TxtProv.Text == "" || TxtMarca.Text == "" || TxtCantidad.Text == "" || TxtRecepcion.Text == "")
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
                    materiales.RN_ActualizarStock_Sumar_Materiales(Convert.ToInt32(TxtId.Text), Convert.ToInt32(TxtCantidad.Text));

                    if (BD_Materiales.Guardar == true)
                    {

                        MessageBox.Show("Producto Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Principal principal = new Principal();
                        principal.Cargar_Materiales();
                        this.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarMateriales();
        }
    }
}
