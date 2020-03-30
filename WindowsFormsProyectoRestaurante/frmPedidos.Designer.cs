namespace WindowsFormsProyectoRestaurante
{
    partial class frmPedidos
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
            this.txtNumPe = new System.Windows.Forms.TextBox();
            this.lblNumPe = new System.Windows.Forms.Label();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.cmbNumMesa = new System.Windows.Forms.ComboBox();
            this.lblNumBebidas = new System.Windows.Forms.Label();
            this.numUpBebidas = new System.Windows.Forms.NumericUpDown();
            this.btnAgregaPlatillo = new System.Windows.Forms.Button();
            this.btmGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPe
            // 
            this.txtNumPe.Location = new System.Drawing.Point(76, 118);
            this.txtNumPe.Name = "txtNumPe";
            this.txtNumPe.Size = new System.Drawing.Size(100, 20);
            this.txtNumPe.TabIndex = 0;
            // 
            // lblNumPe
            // 
            this.lblNumPe.AutoSize = true;
            this.lblNumPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPe.Location = new System.Drawing.Point(73, 87);
            this.lblNumPe.Name = "lblNumPe";
            this.lblNumPe.Size = new System.Drawing.Size(122, 16);
            this.lblNumPe.TabIndex = 1;
            this.lblNumPe.Text = "Numero de Pedido";
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(232, 87);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(112, 16);
            this.lblNumMesa.TabIndex = 2;
            this.lblNumMesa.Text = "Numero de Mesa";
            // 
            // cmbNumMesa
            // 
            this.cmbNumMesa.FormattingEnabled = true;
            this.cmbNumMesa.Location = new System.Drawing.Point(235, 117);
            this.cmbNumMesa.Name = "cmbNumMesa";
            this.cmbNumMesa.Size = new System.Drawing.Size(121, 21);
            this.cmbNumMesa.TabIndex = 0;
            this.cmbNumMesa.SelectedIndexChanged += new System.EventHandler(this.cmbNumMesa_SelectedIndexChanged);
            // 
            // lblNumBebidas
            // 
            this.lblNumBebidas.AutoSize = true;
            this.lblNumBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBebidas.Location = new System.Drawing.Point(155, 303);
            this.lblNumBebidas.Name = "lblNumBebidas";
            this.lblNumBebidas.Size = new System.Drawing.Size(129, 16);
            this.lblNumBebidas.TabIndex = 4;
            this.lblNumBebidas.Text = "Numero de Bebidas";
            // 
            // numUpBebidas
            // 
            this.numUpBebidas.Location = new System.Drawing.Point(155, 342);
            this.numUpBebidas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpBebidas.Name = "numUpBebidas";
            this.numUpBebidas.Size = new System.Drawing.Size(69, 20);
            this.numUpBebidas.TabIndex = 1;
            // 
            // btnAgregaPlatillo
            // 
            this.btnAgregaPlatillo.Location = new System.Drawing.Point(319, 337);
            this.btnAgregaPlatillo.Name = "btnAgregaPlatillo";
            this.btnAgregaPlatillo.Size = new System.Drawing.Size(104, 27);
            this.btnAgregaPlatillo.TabIndex = 2;
            this.btnAgregaPlatillo.Text = "Agrega Platillo";
            this.btnAgregaPlatillo.UseVisualStyleBackColor = true;
            this.btnAgregaPlatillo.Click += new System.EventHandler(this.btnAgregaPlatillo_Click);
            // 
            // btmGuardar
            // 
            this.btmGuardar.Enabled = false;
            this.btmGuardar.Location = new System.Drawing.Point(235, 392);
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(118, 43);
            this.btmGuardar.TabIndex = 3;
            this.btmGuardar.Text = "Guarda Pedido";
            this.btmGuardar.UseVisualStyleBackColor = true;
            this.btmGuardar.Click += new System.EventHandler(this.btmGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(220, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Alta de Pedidos";
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumMesa,
            this.NombreCliente,
            this.Descripcion,
            this.NumPersonas,
            this.Estatus});
            this.dgvMesas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMesas.Location = new System.Drawing.Point(-1, 156);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.Size = new System.Drawing.Size(604, 123);
            this.dgvMesas.TabIndex = 9;
            // 
            // NumMesa
            // 
            this.NumMesa.HeaderText = "Numero de Mesa";
            this.NumMesa.Name = "NumMesa";
            this.NumMesa.ReadOnly = true;
            this.NumMesa.Width = 80;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre del Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // NumPersonas
            // 
            this.NumPersonas.HeaderText = "Numero de Personas";
            this.NumPersonas.Name = "NumPersonas";
            this.NumPersonas.ReadOnly = true;
            this.NumPersonas.Width = 80;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(385, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 447);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btmGuardar);
            this.Controls.Add(this.btnAgregaPlatillo);
            this.Controls.Add(this.numUpBebidas);
            this.Controls.Add(this.lblNumBebidas);
            this.Controls.Add(this.cmbNumMesa);
            this.Controls.Add(this.lblNumMesa);
            this.Controls.Add(this.lblNumPe);
            this.Controls.Add(this.txtNumPe);
            this.Name = "frmPedidos";
            this.Text = "Alta De Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumPe;
        private System.Windows.Forms.Label lblNumPe;
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.ComboBox cmbNumMesa;
        private System.Windows.Forms.Label lblNumBebidas;
        private System.Windows.Forms.NumericUpDown numUpBebidas;
        private System.Windows.Forms.Button btnAgregaPlatillo;
        private System.Windows.Forms.Button btmGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.Label lblNombre;
    }
}