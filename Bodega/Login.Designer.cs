namespace Bodega
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.Txt_Usu = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.formularioRedondo1 = new Bodega.Componentes.FormularioRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.BackColor = System.Drawing.Color.Blue;
            this.BtnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.ForeColor = System.Drawing.Color.White;
            this.BtnIngreso.Location = new System.Drawing.Point(348, 270);
            this.BtnIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(168, 38);
            this.BtnIngreso.TabIndex = 484;
            this.BtnIngreso.Text = "Ingresar";
            this.BtnIngreso.UseVisualStyleBackColor = false;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pass.Location = new System.Drawing.Point(303, 189);
            this.Txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.Size = new System.Drawing.Size(290, 30);
            this.Txt_Pass.TabIndex = 483;
            this.Txt_Pass.UseSystemPasswordChar = true;
            // 
            // Txt_Usu
            // 
            this.Txt_Usu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usu.Location = new System.Drawing.Point(303, 118);
            this.Txt_Usu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usu.Name = "Txt_Usu";
            this.Txt_Usu.Size = new System.Drawing.Size(290, 30);
            this.Txt_Usu.TabIndex = 482;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label12.Image = ((System.Drawing.Image)(resources.GetObject("Label12.Image")));
            this.Label12.Location = new System.Drawing.Point(225, 118);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(53, 28);
            this.Label12.TabIndex = 480;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label13.Image = ((System.Drawing.Image)(resources.GetObject("Label13.Image")));
            this.Label13.Location = new System.Drawing.Point(228, 191);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(50, 28);
            this.Label13.TabIndex = 481;
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.ForeColor = System.Drawing.Color.Black;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(26, 27);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(132, 121);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 479;
            this.PicLogo.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(248, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(241, 28);
            this.Label1.TabIndex = 478;
            this.Label1.Text = "Fruttita Services SPA";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(606, 11);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(89, 58);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSalir.TabIndex = 485;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // formularioRedondo1
            // 
            this.formularioRedondo1.CornerRadius = 30;
            this.formularioRedondo1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 339);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_Usu);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.FormularioRedondo formularioRedondo1;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.TextBox Txt_Usu;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.PictureBox PicLogo;
        internal System.Windows.Forms.Label Label1;
    }
}

