namespace Bodega
{
    partial class SolicitudMateriales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudMateriales));
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCancelar = new Bodega.Componentes.BotonesRedondos();
            this.BtnRegistrar = new Bodega.Componentes.BotonesRedondos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.lab = new System.Windows.Forms.Label();
            this.TxtRecepcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formularioRedondo1 = new Bodega.Componentes.FormularioRedondo();
            this.label9 = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.CboPersonal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtId.Location = new System.Drawing.Point(239, 135);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(87, 29);
            this.TxtId.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label7.Location = new System.Drawing.Point(56, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 138;
            this.label7.Text = "ID";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Gray;
            this.BtnCancelar.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar.BorderRadius = 15;
            this.BtnCancelar.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(526, 720);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 55);
            this.BtnCancelar.TabIndex = 137;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.Green;
            this.BtnRegistrar.BackgroundColor = System.Drawing.Color.Green;
            this.BtnRegistrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRegistrar.BorderRadius = 15;
            this.BtnRegistrar.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(214, 720);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(150, 55);
            this.BtnRegistrar.TabIndex = 136;
            this.BtnRegistrar.Text = "Solicitar";
            this.BtnRegistrar.TextColor = System.Drawing.Color.White;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 84);
            this.panel1.TabIndex = 135;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(850, 13);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(58, 45);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSalir.TabIndex = 488;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(284, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 34);
            this.label1.TabIndex = 487;
            this.label1.Text = "Solicitud de Materiales";
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(238, 546);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(187, 24);
            this.Fecha.TabIndex = 132;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(56, 550);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(55, 20);
            this.lab.TabIndex = 131;
            this.lab.Text = "Fecha";
            // 
            // TxtRecepcion
            // 
            this.TxtRecepcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecepcion.ForeColor = System.Drawing.Color.DimGray;
            this.TxtRecepcion.Location = new System.Drawing.Point(238, 392);
            this.TxtRecepcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRecepcion.Name = "TxtRecepcion";
            this.TxtRecepcion.Size = new System.Drawing.Size(473, 29);
            this.TxtRecepcion.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 130;
            this.label6.Text = "Retirado Por";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCantidad.Location = new System.Drawing.Point(238, 467);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(187, 29);
            this.TxtCantidad.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 471);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 128;
            this.label4.Text = "Autorizado Por";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Enabled = false;
            this.TxtMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarca.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMarca.Location = new System.Drawing.Point(238, 264);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(473, 29);
            this.TxtMarca.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 127;
            this.label3.Text = "Marca";
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Enabled = false;
            this.TxtMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterial.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMaterial.Location = new System.Drawing.Point(238, 196);
            this.TxtMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(473, 29);
            this.TxtMaterial.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "Nombre Material";
            // 
            // formularioRedondo1
            // 
            this.formularioRedondo1.CornerRadius = 30;
            this.formularioRedondo1.TargetControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label9.Location = new System.Drawing.Point(390, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 140;
            this.label9.Text = "Stock";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.LblStock.Location = new System.Drawing.Point(472, 139);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(0, 20);
            this.LblStock.TabIndex = 141;
            // 
            // cbo_rol
            // 
            this.cbo_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rol.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Items.AddRange(new object[] {
            "Adminstracion ",
            "Packing",
            "Mantencion",
            "Sadema",
            "Bodega",
            "Recepcion",
            "Calidad",
            "Informatica",
            "Despacho",
            "Frio",
            "Comex",
            "Cuenta corriente",
            "Porteria"});
            this.cbo_rol.Location = new System.Drawing.Point(239, 615);
            this.cbo_rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(291, 29);
            this.cbo_rol.TabIndex = 147;
            // 
            // CboPersonal
            // 
            this.CboPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPersonal.FormattingEnabled = true;
            this.CboPersonal.Location = new System.Drawing.Point(239, 328);
            this.CboPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboPersonal.Name = "CboPersonal";
            this.CboPersonal.Size = new System.Drawing.Size(472, 28);
            this.CboPersonal.TabIndex = 146;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 619);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 148;
            this.label10.Text = "Seccion";
            // 
            // SolicitudMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 853);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_rol);
            this.Controls.Add(this.CboPersonal);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.TxtRecepcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMaterial);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitudMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolicitudMateriales";
            this.Load += new System.EventHandler(this.SolicitudMateriales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label7;
        private Componentes.BotonesRedondos BtnCancelar;
        private Componentes.BotonesRedondos BtnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnSalir;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox TxtRecepcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.Label label2;
        private Componentes.FormularioRedondo formularioRedondo1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.ComboBox CboPersonal;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label LblStock;
    }
}