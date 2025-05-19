namespace Bodega
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Materiales = new System.Windows.Forms.TabPage();
            this.ListaMateriales = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.TxxtBuscarHerramienta = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaEntregaMateriales = new System.Windows.Forms.ListView();
            this.DataSalidaMat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retirado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSolicitud = new Bodega.Componentes.BotonesRedondos();
            this.BtnEditar = new Bodega.Componentes.BotonesRedondos();
            this.BtnIngreso = new Bodega.Componentes.BotonesRedondos();
            this.BtnConfirmar = new Bodega.Componentes.BotonesRedondos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Materiales.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSalidaMat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PicLogo);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1715, 83);
            this.panel1.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(1560, 13);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(58, 45);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSalir.TabIndex = 486;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(666, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 34);
            this.label2.TabIndex = 481;
            this.label2.Text = "Inventario de Bodega ";
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.ForeColor = System.Drawing.Color.Black;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(12, 5);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(87, 74);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 480;
            this.PicLogo.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(107, 28);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(241, 28);
            this.Label1.TabIndex = 479;
            this.Label1.Text = "Fruttita Services SPA";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Materiales);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1663, 685);
            this.tabControl1.TabIndex = 1;
            // 
            // Materiales
            // 
            this.Materiales.Controls.Add(this.BtnSolicitud);
            this.Materiales.Controls.Add(this.BtnEditar);
            this.Materiales.Controls.Add(this.ListaMateriales);
            this.Materiales.Controls.Add(this.BtnIngreso);
            this.Materiales.Controls.Add(this.label9);
            this.Materiales.Controls.Add(this.TxxtBuscarHerramienta);
            this.Materiales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materiales.Location = new System.Drawing.Point(4, 29);
            this.Materiales.Name = "Materiales";
            this.Materiales.Padding = new System.Windows.Forms.Padding(3);
            this.Materiales.Size = new System.Drawing.Size(1655, 652);
            this.Materiales.TabIndex = 0;
            this.Materiales.Text = "Materiales";
            this.Materiales.UseVisualStyleBackColor = true;
            // 
            // ListaMateriales
            // 
            this.ListaMateriales.ContextMenuStrip = this.contextMenuStrip1;
            this.ListaMateriales.HideSelection = false;
            this.ListaMateriales.Location = new System.Drawing.Point(28, 112);
            this.ListaMateriales.Name = "ListaMateriales";
            this.ListaMateriales.Size = new System.Drawing.Size(1064, 498);
            this.ListaMateriales.TabIndex = 96;
            this.ListaMateriales.UseCompatibleStateImageBehavior = false;
            this.ListaMateriales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListaMateriales_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 94;
            this.label9.Text = "Buscar";
            // 
            // TxxtBuscarHerramienta
            // 
            this.TxxtBuscarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxxtBuscarHerramienta.Location = new System.Drawing.Point(119, 41);
            this.TxxtBuscarHerramienta.Name = "TxxtBuscarHerramienta";
            this.TxxtBuscarHerramienta.Size = new System.Drawing.Size(371, 27);
            this.TxxtBuscarHerramienta.TabIndex = 93;
            this.TxxtBuscarHerramienta.TextChanged += new System.EventHandler(this.TxxtBuscarHerramienta_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnConfirmar);
            this.tabPage2.Controls.Add(this.DataSalidaMat);
            this.tabPage2.Controls.Add(this.ListaEntregaMateriales);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1655, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Confirmar Entrega Materiales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1655, 652);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ropa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1655, 652);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Confirmar Entrega Ropa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1655, 652);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Solicitud Colaciones";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarMaterialToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 28);
            // 
            // eliminarMaterialToolStripMenuItem
            // 
            this.eliminarMaterialToolStripMenuItem.Name = "eliminarMaterialToolStripMenuItem";
            this.eliminarMaterialToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.eliminarMaterialToolStripMenuItem.Text = "Eliminar material";
            this.eliminarMaterialToolStripMenuItem.Click += new System.EventHandler(this.eliminarMaterialToolStripMenuItem_Click);
            // 
            // ListaEntregaMateriales
            // 
            this.ListaEntregaMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaEntregaMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaEntregaMateriales.HideSelection = false;
            this.ListaEntregaMateriales.Location = new System.Drawing.Point(3, 56);
            this.ListaEntregaMateriales.Name = "ListaEntregaMateriales";
            this.ListaEntregaMateriales.Size = new System.Drawing.Size(817, 459);
            this.ListaEntregaMateriales.TabIndex = 0;
            this.ListaEntregaMateriales.UseCompatibleStateImageBehavior = false;
            // 
            // DataSalidaMat
            // 
            this.DataSalidaMat.AllowUserToAddRows = false;
            this.DataSalidaMat.AllowUserToDeleteRows = false;
            this.DataSalidaMat.AllowUserToResizeColumns = false;
            this.DataSalidaMat.AllowUserToResizeRows = false;
            this.DataSalidaMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSalidaMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataSalidaMat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataSalidaMat.BackgroundColor = System.Drawing.Color.White;
            this.DataSalidaMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataSalidaMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataSalidaMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataSalidaMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSalidaMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Material,
            this.marca,
            this.autorizado,
            this.retirado,
            this.cantidad,
            this.fecha,
            this.area});
            this.DataSalidaMat.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataSalidaMat.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataSalidaMat.EnableHeadersVisualStyles = false;
            this.DataSalidaMat.Location = new System.Drawing.Point(881, 56);
            this.DataSalidaMat.MultiSelect = false;
            this.DataSalidaMat.Name = "DataSalidaMat";
            this.DataSalidaMat.ReadOnly = true;
            this.DataSalidaMat.RowHeadersVisible = false;
            this.DataSalidaMat.RowHeadersWidth = 51;
            this.DataSalidaMat.RowTemplate.Height = 24;
            this.DataSalidaMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataSalidaMat.Size = new System.Drawing.Size(768, 459);
            this.DataSalidaMat.TabIndex = 118;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.FillWeight = 85.5615F;
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Material.FillWeight = 114.4385F;
            this.Material.HeaderText = "Nombre Material";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 250;
            // 
            // marca
            // 
            this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 120;
            // 
            // autorizado
            // 
            this.autorizado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.autorizado.HeaderText = "Autorizado Por";
            this.autorizado.MinimumWidth = 6;
            this.autorizado.Name = "autorizado";
            this.autorizado.ReadOnly = true;
            this.autorizado.Width = 200;
            // 
            // retirado
            // 
            this.retirado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.retirado.HeaderText = "Retirado Por";
            this.retirado.MinimumWidth = 6;
            this.retirado.Name = "retirado";
            this.retirado.ReadOnly = true;
            this.retirado.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 80;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // area
            // 
            this.area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.area.HeaderText = "Area";
            this.area.MinimumWidth = 6;
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // BtnSolicitud
            // 
            this.BtnSolicitud.BackColor = System.Drawing.Color.Teal;
            this.BtnSolicitud.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnSolicitud.BorderColor = System.Drawing.Color.Black;
            this.BtnSolicitud.BorderRadius = 15;
            this.BtnSolicitud.BorderSize = 2;
            this.BtnSolicitud.FlatAppearance.BorderSize = 0;
            this.BtnSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolicitud.ForeColor = System.Drawing.Color.White;
            this.BtnSolicitud.Location = new System.Drawing.Point(1140, 426);
            this.BtnSolicitud.Name = "BtnSolicitud";
            this.BtnSolicitud.Size = new System.Drawing.Size(204, 61);
            this.BtnSolicitud.TabIndex = 98;
            this.BtnSolicitud.Text = "Solicitud de Materiales";
            this.BtnSolicitud.TextColor = System.Drawing.Color.White;
            this.BtnSolicitud.UseVisualStyleBackColor = false;
            this.BtnSolicitud.Click += new System.EventHandler(this.BtnSolicitud_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Teal;
            this.BtnEditar.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnEditar.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.BorderRadius = 15;
            this.BtnEditar.BorderSize = 2;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(1140, 284);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(204, 61);
            this.BtnEditar.TabIndex = 97;
            this.BtnEditar.Text = "Ingreso Material Existente";
            this.BtnEditar.TextColor = System.Drawing.Color.White;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.BackColor = System.Drawing.Color.Green;
            this.BtnIngreso.BackgroundColor = System.Drawing.Color.Green;
            this.BtnIngreso.BorderColor = System.Drawing.Color.Black;
            this.BtnIngreso.BorderRadius = 15;
            this.BtnIngreso.BorderSize = 2;
            this.BtnIngreso.FlatAppearance.BorderSize = 0;
            this.BtnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.ForeColor = System.Drawing.Color.White;
            this.BtnIngreso.Location = new System.Drawing.Point(1140, 144);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(204, 61);
            this.BtnIngreso.TabIndex = 95;
            this.BtnIngreso.Text = "Ingreso Nuevo Material";
            this.BtnIngreso.TextColor = System.Drawing.Color.White;
            this.BtnIngreso.UseVisualStyleBackColor = false;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.Teal;
            this.BtnConfirmar.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnConfirmar.BorderRadius = 15;
            this.BtnConfirmar.BorderSize = 0;
            this.BtnConfirmar.FlatAppearance.BorderSize = 0;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(266, 561);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(210, 57);
            this.BtnConfirmar.TabIndex = 119;
            this.BtnConfirmar.Text = "Confirmar Entrega Material";
            this.BtnConfirmar.TextColor = System.Drawing.Color.White;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 804);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Materiales.ResumeLayout(false);
            this.Materiales.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSalidaMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PicLogo;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Materiales;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxxtBuscarHerramienta;
        private Componentes.BotonesRedondos BtnIngreso;
        private System.Windows.Forms.ListView ListaMateriales;
        private Componentes.BotonesRedondos BtnEditar;
        private Componentes.BotonesRedondos BtnSolicitud;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarMaterialToolStripMenuItem;
        private System.Windows.Forms.ListView ListaEntregaMateriales;
        private System.Windows.Forms.DataGridView DataSalidaMat;
        private Componentes.BotonesRedondos BtnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn retirado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}