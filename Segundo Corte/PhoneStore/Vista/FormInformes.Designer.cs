namespace PhoneStore.Vista
{
    partial class FormInformes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelResumen1 = new System.Windows.Forms.Panel();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblEntradasTexto = new System.Windows.Forms.Label();
            this.panelResumen2 = new System.Windows.Forms.Panel();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.lblSalidasTexto = new System.Windows.Forms.Label();
            this.panelResumen3 = new System.Windows.Forms.Panel();
            this.lblStockBajo = new System.Windows.Forms.Label();
            this.lblStockBajoTexto = new System.Windows.Forms.Label();
            this.lblFiltroProducto = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lblFiltroTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupStock = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelResumen1.SuspendLayout();
            this.panelResumen2.SuspendLayout();
            this.panelResumen3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.groupStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 90);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(298, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Revisa los movimientos y  los Stock";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(295, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gestión de Informes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelResumen1);
            this.groupBox1.Controls.Add(this.panelResumen2);
            this.groupBox1.Controls.Add(this.panelResumen3);
            this.groupBox1.Controls.Add(this.lblFiltroProducto);
            this.groupBox1.Controls.Add(this.cbProducto);
            this.groupBox1.Controls.Add(this.lblFiltroTipo);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.btnVerTodo);
            this.groupBox1.Controls.Add(this.dgvMovimientos);
            this.groupBox1.Controls.Add(this.groupStock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 560);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // panelResumen1
            // 
            this.panelResumen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen1.Controls.Add(this.lblEntradas);
            this.panelResumen1.Controls.Add(this.lblEntradasTexto);
            this.panelResumen1.Location = new System.Drawing.Point(20, 20);
            this.panelResumen1.Name = "panelResumen1";
            this.panelResumen1.Size = new System.Drawing.Size(290, 70);
            this.panelResumen1.TabIndex = 12;
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEntradas.ForeColor = System.Drawing.Color.Green;
            this.lblEntradas.Location = new System.Drawing.Point(113, 10);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(42, 30);
            this.lblEntradas.TabIndex = 0;
            this.lblEntradas.Text = "+0";
            // 
            // lblEntradasTexto
            // 
            this.lblEntradasTexto.AutoSize = true;
            this.lblEntradasTexto.Location = new System.Drawing.Point(53, 45);
            this.lblEntradasTexto.Name = "lblEntradasTexto";
            this.lblEntradasTexto.Size = new System.Drawing.Size(163, 18);
            this.lblEntradasTexto.TabIndex = 1;
            this.lblEntradasTexto.Text = "Total unidades ingresadas";
            // 
            // panelResumen2
            // 
            this.panelResumen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen2.Controls.Add(this.lblSalidas);
            this.panelResumen2.Controls.Add(this.lblSalidasTexto);
            this.panelResumen2.Location = new System.Drawing.Point(330, 20);
            this.panelResumen2.Name = "panelResumen2";
            this.panelResumen2.Size = new System.Drawing.Size(290, 70);
            this.panelResumen2.TabIndex = 13;
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSalidas.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSalidas.Location = new System.Drawing.Point(120, 10);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(35, 30);
            this.lblSalidas.TabIndex = 0;
            this.lblSalidas.Text = "-0";
            // 
            // lblSalidasTexto
            // 
            this.lblSalidasTexto.AutoSize = true;
            this.lblSalidasTexto.Location = new System.Drawing.Point(59, 40);
            this.lblSalidasTexto.Name = "lblSalidasTexto";
            this.lblSalidasTexto.Size = new System.Drawing.Size(175, 18);
            this.lblSalidasTexto.TabIndex = 1;
            this.lblSalidasTexto.Text = "Total unidades despachadas";
            // 
            // panelResumen3
            // 
            this.panelResumen3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen3.Controls.Add(this.lblStockBajo);
            this.panelResumen3.Controls.Add(this.lblStockBajoTexto);
            this.panelResumen3.Location = new System.Drawing.Point(640, 20);
            this.panelResumen3.Name = "panelResumen3";
            this.panelResumen3.Size = new System.Drawing.Size(290, 70);
            this.panelResumen3.TabIndex = 14;
            // 
            // lblStockBajo
            // 
            this.lblStockBajo.AutoSize = true;
            this.lblStockBajo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStockBajo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStockBajo.Location = new System.Drawing.Point(134, 10);
            this.lblStockBajo.Name = "lblStockBajo";
            this.lblStockBajo.Size = new System.Drawing.Size(26, 30);
            this.lblStockBajo.TabIndex = 0;
            this.lblStockBajo.Text = "0";
            // 
            // lblStockBajoTexto
            // 
            this.lblStockBajoTexto.AutoSize = true;
            this.lblStockBajoTexto.Location = new System.Drawing.Point(68, 45);
            this.lblStockBajoTexto.Name = "lblStockBajoTexto";
            this.lblStockBajoTexto.Size = new System.Drawing.Size(157, 18);
            this.lblStockBajoTexto.TabIndex = 1;
            this.lblStockBajoTexto.Text = "Productos con stock bajo";
            // 
            // lblFiltroProducto
            // 
            this.lblFiltroProducto.AutoSize = true;
            this.lblFiltroProducto.Location = new System.Drawing.Point(25, 110);
            this.lblFiltroProducto.Name = "lblFiltroProducto";
            this.lblFiltroProducto.Size = new System.Drawing.Size(66, 18);
            this.lblFiltroProducto.TabIndex = 15;
            this.lblFiltroProducto.Text = "Producto:";
            // 
            // cbProducto
            // 
            this.cbProducto.BackColor = System.Drawing.Color.White;
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.Location = new System.Drawing.Point(97, 105);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(200, 26);
            this.cbProducto.TabIndex = 16;
            // 
            // lblFiltroTipo
            // 
            this.lblFiltroTipo.AutoSize = true;
            this.lblFiltroTipo.Location = new System.Drawing.Point(305, 110);
            this.lblFiltroTipo.Name = "lblFiltroTipo";
            this.lblFiltroTipo.Size = new System.Drawing.Size(42, 18);
            this.lblFiltroTipo.TabIndex = 17;
            this.lblFiltroTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.White;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbTipo.Location = new System.Drawing.Point(345, 107);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(150, 26);
            this.cbTipo.TabIndex = 18;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(515, 105);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 25);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.BackColor = System.Drawing.Color.White;
            this.btnVerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerTodo.Location = new System.Drawing.Point(620, 105);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(90, 25);
            this.btnVerTodo.TabIndex = 20;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = false;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click_1);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colProducto,
            this.colTipo,
            this.colCantidad,
            this.colObservacion});
            this.dgvMovimientos.Location = new System.Drawing.Point(20, 145);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.Size = new System.Drawing.Size(910, 180);
            this.dgvMovimientos.TabIndex = 21;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colObservacion
            // 
            this.colObservacion.HeaderText = "Observación";
            this.colObservacion.Name = "colObservacion";
            // 
            // groupStock
            // 
            this.groupStock.Controls.Add(this.dgvStock);
            this.groupStock.Location = new System.Drawing.Point(20, 340);
            this.groupStock.Name = "groupStock";
            this.groupStock.Size = new System.Drawing.Size(910, 200);
            this.groupStock.TabIndex = 22;
            this.groupStock.TabStop = false;
            this.groupStock.Text = "Stock actual por producto";
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colStock});
            this.dgvStock.Location = new System.Drawing.Point(10, 20);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(890, 170);
            this.dgvStock.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelResumen1.ResumeLayout(false);
            this.panelResumen1.PerformLayout();
            this.panelResumen2.ResumeLayout(false);
            this.panelResumen2.PerformLayout();
            this.panelResumen3.ResumeLayout(false);
            this.panelResumen3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.groupStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelResumen1;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblEntradasTexto;
        private System.Windows.Forms.Panel panelResumen2;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.Label lblSalidasTexto;
        private System.Windows.Forms.Panel panelResumen3;
        private System.Windows.Forms.Label lblStockBajo;
        private System.Windows.Forms.Label lblStockBajoTexto;
        private System.Windows.Forms.Label lblFiltroProducto;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label lblFiltroTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private System.Windows.Forms.GroupBox groupStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}