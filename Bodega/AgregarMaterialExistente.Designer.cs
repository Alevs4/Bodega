namespace Bodega
{
    partial class AgregarMaterialExistente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMaterialExistente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumFac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.lab = new System.Windows.Forms.Label();
            this.TxtRecepcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCancelar = new Bodega.Componentes.BotonesRedondos();
            this.BtnRegistrar = new Bodega.Componentes.BotonesRedondos();
            this.formularioRedondo1 = new Bodega.Componentes.FormularioRedondo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 80);
            this.panel1.TabIndex = 116;
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
            this.label1.Location = new System.Drawing.Point(269, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 34);
            this.label1.TabIndex = 487;
            this.label1.Text = "Ingreso Material Existente";
            // 
            // TxtNumFac
            // 
            this.TxtNumFac.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtNumFac.Location = new System.Drawing.Point(359, 129);
            this.TxtNumFac.Name = "TxtNumFac";
            this.TxtNumFac.Size = new System.Drawing.Size(126, 29);
            this.TxtNumFac.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label8.Location = new System.Drawing.Point(109, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 114;
            this.label8.Text = "N° Factura";
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(359, 574);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(187, 24);
            this.Fecha.TabIndex = 113;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(108, 573);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(55, 20);
            this.lab.TabIndex = 112;
            this.lab.Text = "Fecha";
            // 
            // TxtRecepcion
            // 
            this.TxtRecepcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecepcion.ForeColor = System.Drawing.Color.DimGray;
            this.TxtRecepcion.Location = new System.Drawing.Point(359, 420);
            this.TxtRecepcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRecepcion.Name = "TxtRecepcion";
            this.TxtRecepcion.Size = new System.Drawing.Size(473, 29);
            this.TxtRecepcion.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "Recepcionado Por";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCantidad.Location = new System.Drawing.Point(359, 500);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(187, 29);
            this.TxtCantidad.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 505);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Cantidad";
            // 
            // TxtProv
            // 
            this.TxtProv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProv.ForeColor = System.Drawing.Color.DimGray;
            this.TxtProv.Location = new System.Drawing.Point(359, 348);
            this.TxtProv.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProv.Name = "TxtProv";
            this.TxtProv.Size = new System.Drawing.Size(473, 29);
            this.TxtProv.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Proveedor";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Enabled = false;
            this.TxtMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarca.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMarca.Location = new System.Drawing.Point(359, 274);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(473, 29);
            this.TxtMarca.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "Marca";
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Enabled = false;
            this.TxtMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterial.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMaterial.Location = new System.Drawing.Point(359, 198);
            this.TxtMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(473, 29);
            this.TxtMaterial.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nombre Material";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtId.Location = new System.Drawing.Point(620, 131);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(87, 29);
            this.TxtId.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label7.Location = new System.Drawing.Point(555, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 119;
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
            this.BtnCancelar.Location = new System.Drawing.Point(586, 690);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 55);
            this.BtnCancelar.TabIndex = 118;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnRegistrar.Location = new System.Drawing.Point(197, 690);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(150, 55);
            this.BtnRegistrar.TabIndex = 117;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextColor = System.Drawing.Color.White;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // formularioRedondo1
            // 
            this.formularioRedondo1.CornerRadius = 30;
            this.formularioRedondo1.TargetControl = this;
            // 
            // AgregarMaterialExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 801);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtNumFac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.TxtRecepcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMaterial);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarMaterialExistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMaterialExistente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.BotonesRedondos BtnCancelar;
        private Componentes.BotonesRedondos BtnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnSalir;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumFac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox TxtRecepcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Componentes.FormularioRedondo formularioRedondo1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtMarca;
        public System.Windows.Forms.TextBox TxtMaterial;
        public System.Windows.Forms.TextBox TxtId;
    }
}