using Bodega.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bodega
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Mensaje = MessageBox.Show("Estas seguro que quiere cerrar la APP", "Requerimiento del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Mensaje == DialogResult.OK)
                Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ConfigurarListview();
            Cargar_Materiales();
            ConfigurarListviewSalida();
            Cargar_Salida_Materiales(); 
        }
        public void Cargar_Materiales()
        {
            RN_Materiales obj = new RN_Materiales();
            DataTable dt = new DataTable();

            dt = obj.RN_Mostrar_Materiales();
            if (dt.Rows.Count > 0)
            {
                LlenarListview(dt);
            }
   
        }
        private void LlenarListview(DataTable data)
        {
            ListaMateriales.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["id_prod"].ToString());
                list.SubItems.Add(dr["nombre_producto"].ToString());
                list.SubItems.Add(dr["descripcion"].ToString());
                list.SubItems.Add(dr["stock"].ToString());

         
                //Llenamos el listview
                ListaMateriales.Items.Add(list);
            }
            //Lbl_total.Text = Convert.ToString(ListaMateriales.Items.Count);
        }
        private void ConfigurarListview()
        {
            var lis = ListaMateriales;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            // configuramos el ancho y nombres de las columnas
            lis.Columns.Add("Id ", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Material", 350, HorizontalAlignment.Left);
            lis.Columns.Add("Marca", 200, HorizontalAlignment.Left);
            lis.Columns.Add("Stock", 100, HorizontalAlignment.Left);
     
        }

        private void TxxtBuscarHerramienta_TextChanged(object sender, EventArgs e)
        {
            if (TxxtBuscarHerramienta.Text.Trim().Length > 1)
            {
                Buscar_Herramienta_PorValor(TxxtBuscarHerramienta.Text.Trim());
            }
            else
            {
                Cargar_Materiales();
            }
        }
        private void Buscar_Herramienta_PorValor(string xvalor)
        {
            RN_Materiales obj = new RN_Materiales();
            DataTable dt = new DataTable();

            dt = obj.RN_Buscar_Material_xValor(xvalor);
            if (dt.Rows.Count > 0)
            {
                LlenarListview(dt);
            }
    
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            IngresoNuevoMaterial ingreso = new IngresoNuevoMaterial();
            ingreso.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ListaMateriales.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AgregarMaterialExistente agregar = new AgregarMaterialExistente();
            agregar.TxtId.Text = ListaMateriales.SelectedItems[0].SubItems[0].Text;
            agregar.TxtMaterial.Text = ListaMateriales.SelectedItems[0].SubItems[1].Text;
            agregar.TxtMarca.Text = ListaMateriales.SelectedItems[0].SubItems[2].Text;
            agregar.ShowDialog();

        }

        private void ListaMateriales_MouseClick(object sender, MouseEventArgs e)
        {
            //AgregarMaterialExistente agregar = new AgregarMaterialExistente(); 
            //agregar.TxtId.Text = ListaMateriales.SelectedItems[0].SubItems[0].Text;
            //agregar.TxtMaterial.Text = ListaMateriales.SelectedItems[0].SubItems[1].Text;
            //agregar.TxtMarca.Text = ListaMateriales.SelectedItems[0].SubItems[2].Text;
            //agregar.ShowDialog();
        }

        private void BtnSolicitud_Click(object sender, EventArgs e)
        {
            if (ListaMateriales.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SolicitudMateriales solicitud = new SolicitudMateriales();
            solicitud.TxtId.Text = ListaMateriales.SelectedItems[0].SubItems[0].Text;
            solicitud.TxtMaterial.Text = ListaMateriales.SelectedItems[0].SubItems[1].Text;
            solicitud.TxtMarca.Text = ListaMateriales.SelectedItems[0].SubItems[2].Text;
            solicitud.LblStock.Text = ListaMateriales.SelectedItems[0].SubItems[3].Text;
            solicitud.ShowDialog();
        }

        private void eliminarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RN_Materiales obj = new RN_Materiales();
            if (ListaMateriales.SelectedIndices.Count == 0)
            {

                MessageBox.Show("Selecione Item que Desea Eliminar", "Informacion De Sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);

                return;
            }
            else
            {
                var lsv = ListaMateriales.SelectedItems[0];
                string Valor = lsv.SubItems[0].Text;

                DialogResult Res = MessageBox.Show("Estas Seguro de Eliminar el Material", "Informacion Critica", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                if (Res == DialogResult.OK)
                {
                    obj.RN_EliminarMaterial(Valor);
                    MessageBox.Show("Material Eliminado", "Informacion de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Cargar_Materiales();

                }
            }
        }
        public void Cargar_Salida_Materiales()
        {
            RN_Materiales obj = new RN_Materiales();
            DataTable dt = new DataTable();

            dt = obj.RN_Mostrar_Materiales_Salida();
            if (dt.Rows.Count > 0)
            {
                LlenarListviewSalida(dt);
            }

        }
        private void LlenarListviewSalida(DataTable data)
        {
            ListaEntregaMateriales.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["id_salida"].ToString());
                list.SubItems.Add(dr["nombre_materiales"].ToString());
                list.SubItems.Add(dr["descripcion"].ToString());
                list.SubItems.Add(dr["autorizadoPor"].ToString());
                list.SubItems.Add(dr["retiradoPor"].ToString());
                list.SubItems.Add(dr["cantidad"].ToString());
                list.SubItems.Add(dr["fecha"].ToString());
                list.SubItems.Add(dr["area"].ToString());


                //Llenamos el listview
                ListaEntregaMateriales.Items.Add(list);
            }
            //Lbl_total.Text = Convert.ToString(ListaMateriales.Items.Count);
        }
        private void ConfigurarListviewSalida()
        {
            var lis = ListaEntregaMateriales;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            // configuramos el ancho y nombres de las columnas
            lis.Columns.Add("Id ", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Material", 250, HorizontalAlignment.Left);
            lis.Columns.Add("Marca", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Autorizado por", 200, HorizontalAlignment.Left);
            lis.Columns.Add("Retirado por", 200, HorizontalAlignment.Left);
            lis.Columns.Add("Cantidad", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Area", 100, HorizontalAlignment.Left);

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            RN_Materiales obj = new RN_Materiales();

            if (ListaEntregaMateriales.SelectedItems.Count > 0)
            {
                // Obtener el ítem seleccionado
                ListViewItem selectedItem = ListaEntregaMateriales.SelectedItems[0];

                // Crear un array para almacenar los valores de los 8 subitems
                string[] fila = new string[8];

                for (int i = 0; i < 8; i++)
                {
                    fila[i] = selectedItem.SubItems[i].Text;
                }

                // Agregar la fila al DataGridView
                DataSalidaMat.Rows.Add(fila);
                obj.RN_Actualizar_Estado_Materiales(Convert.ToInt32(fila[0]));
                Cargar_Salida_Materiales();
            }
            else
            {
                MessageBox.Show("Selecciona una fila de la Lista de Materiales.");
            }
        }
    }
}
