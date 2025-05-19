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
    public partial class SolicitudMateriales : Form
    {
        public SolicitudMateriales()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Limpiar()
        {
            TxtId.Text = "";
            LblStock.Text = "";
            TxtCantidad.Text = "";
            TxtRecepcion.Text = "";
            TxtMarca.Text = "";
        }
        private void Cargar_Personal()
        {
            RN_Materiales obj = new RN_Materiales();
            DataTable dt = new DataTable();

            try
            {
                dt = obj.RN_Listar_Personal();
                if (dt.Rows.Count > 0)
                {
                    var cbo = CboPersonal;
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "Nombre_Personal";
                    cbo.ValueMember = "Id_personal";
                }
                CboPersonal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SolicitudMateriales_Load(object sender, EventArgs e)
        {
            Cargar_Personal();
        }
        private void AgregarHerramienta()
        {
            if (LblStock.Text == "0")
            {
                MessageBox.Show("No queda stock del producto seleccionado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (Convert.ToInt32(TxtCantidad.Text) > Convert.ToInt32(LblStock.Text))
                {
                    MessageBox.Show("La cantidad es Superior al stock del producto seleccionado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (TxtMaterial.Text == "" || CboPersonal.Text == "" || TxtMarca.Text == "" || TxtCantidad.Text == "" || TxtRecepcion.Text == "")
                {

                    MessageBox.Show("Se Deben ingresar todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EN_EntregaMateriales obj = new EN_EntregaMateriales();
                    RN_Materiales materiales = new RN_Materiales();

                    try
                    {
                        obj.Descripcion = TxtMarca.Text;
                        obj.Id_prod = Convert.ToInt32(TxtId.Text);
                        obj.EntregadoPor1 = CboPersonal.Text;
                        obj.Producto = TxtMaterial.Text;
                        obj.Fecha = Fecha.Text;
                        obj.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                        obj.RecibidoPor1 = TxtRecepcion.Text;
                        obj.Rol = cbo_rol.Text;
                        materiales.RN_SalidaMateriales(obj);


                        if (BD_Materiales.Guardar == true)
                        {

                            MessageBox.Show("Producto Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            this.Close();
                   


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarHerramienta();
            Principal principal = new Principal();
            principal.Cargar_Salida_Materiales();
        }
    }
}
