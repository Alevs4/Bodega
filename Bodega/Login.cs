using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bodega.Negocio;

namespace Bodega
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool ValidarTexbox()
        {
            if (Txt_Usu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Usu.Focus();
                return false;

            }
            if (Txt_Pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Pass.Focus();
                return false;

            }
            return true;
        }
        private void AccederAlSistema()
        {
            RN_Usuarios obj = new RN_Usuarios();
            DataTable dt = new DataTable();
            int veces = 0;

            if (ValidarTexbox() == false)
                return;

            string usu, pass;
            usu = Txt_Usu.Text.Trim();
            pass = Txt_Pass.Text.Trim();

            if (obj.RN_Verificar_Acceso(usu, pass) == true)
            {
                //los datos son correctos
                //MessageBox.Show("Bienvenido al Sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cls_Libreria.Usuario = usu;

                dt = obj.RN_Lerr_Datos_Usuario(usu);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Cls_Libreria.Nombre = Convert.ToString(dr["nombre"]);

                }


                Principal principal = new Principal();
                this.Hide();
                principal.Show();


            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Txt_Usu.Text = "";
                Txt_Pass.Text = "";
                Txt_Usu.Focus();
                veces += 1;

                if (veces == 3)
                {
                    MessageBox.Show("Numero de intentos Superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            AccederAlSistema();
        }
    }
}
