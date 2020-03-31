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
            this.components = new System.ComponentModel.Container();
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
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.ErrorPPedido = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTPedido = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPe
            // 
            this.txtNumPe.Location = new System.Drawing.Point(407, 116);
            this.txtNumPe.Name = "txtNumPe";
            this.txtNumPe.Size = new System.Drawing.Size(135, 20);
            this.txtNumPe.TabIndex = 0;
            this.ToolTPedido.SetToolTip(this.txtNumPe, "Numero Del Pedido");
            this.txtNumPe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPe_KeyPress);
            // 
            // lblNumPe
            // 
            this.lblNumPe.AutoSize = true;
            this.lblNumPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPe.Location = new System.Drawing.Point(404, 97);
            this.lblNumPe.Name = "lblNumPe";
            this.lblNumPe.Size = new System.Drawing.Size(138, 16);
            this.lblNumPe.TabIndex = 1;
            this.lblNumPe.Text = "Numero de Pedido";
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(72, 95);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(126, 16);
            this.lblNumMesa.TabIndex = 2;
            this.lblNumMesa.Text = "Numero de Mesa";
            // 
            // cmbNumMesa
            // 
            this.cmbNumMesa.FormattingEnabled = true;
            this.cmbNumMesa.Location = new System.Drawing.Point(75, 116);
            this.cmbNumMesa.Name = "cmbNumMesa";
            this.cmbNumMesa.Size = new System.Drawing.Size(121, 21);
            this.cmbNumMesa.TabIndex = 0;
            this.ToolTPedido.SetToolTip(this.cmbNumMesa, "Numero De Mesa");
            this.cmbNumMesa.SelectedIndexChanged += new System.EventHandler(this.cmbNumMesa_SelectedIndexChanged);
            // 
            // lblNumBebidas
            // 
            this.lblNumBebidas.AutoSize = true;
            this.lblNumBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBebidas.Location = new System.Drawing.Point(12, 305);
            this.lblNumBebidas.Name = "lblNumBebidas";
            this.lblNumBebidas.Size = new System.Drawing.Size(134, 15);
            this.lblNumBebidas.TabIndex = 4;
            this.lblNumBebidas.Text = "Numero de Bebidas";
            // 
            // numUpBebidas
            // 
            this.numUpBebidas.Location = new System.Drawing.Point(152, 305);
            this.numUpBebidas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpBebidas.Name = "numUpBebidas";
            this.numUpBebidas.Size = new System.Drawing.Size(69, 20);
            this.numUpBebidas.TabIndex = 1;
            this.ToolTPedido.SetToolTip(this.numUpBebidas, "Numero De Bebidas");
            // 
            // btnAgregaPlatillo
            // 
            this.btnAgregaPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaPlatillo.Location = new System.Drawing.Point(356, 296);
            this.btnAgregaPlatillo.Name = "btnAgregaPlatillo";
            this.btnAgregaPlatillo.Size = new System.Drawing.Size(104, 35);
            this.btnAgregaPlatillo.TabIndex = 2;
            this.btnAgregaPlatillo.Text = "Agrega Platillo";
            this.ToolTPedido.SetToolTip(this.btnAgregaPlatillo, "Click Para Agregar Platillo");
            this.btnAgregaPlatillo.UseVisualStyleBackColor = true;
            this.btnAgregaPlatillo.Click += new System.EventHandler(this.btnAgregaPlatillo_Click);
            // 
            // btmGuardar
            // 
            this.btmGuardar.Enabled = false;
            this.btmGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGuardar.Location = new System.Drawing.Point(226, 375);
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(118, 43);
            this.btmGuardar.TabIndex = 3;
            this.btmGuardar.Text = "Guardar Pedido";
            this.ToolTPedido.SetToolTip(this.btmGuardar, "Click Para Guardar Pedido");
            this.btmGuardar.UseVisualStyleBackColor = true;
            this.btmGuardar.Click += new System.EventHandler(this.btmGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(180, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 38);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Alta de Pedidos";
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.LightGray;
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
            this.ToolTPedido.SetToolTip(this.dgvMesas, "Informacion De La Mesa");
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
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(228, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(152, 18);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.Location = new System.Drawing.Point(231, 116);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(153, 20);
            this.txtNombrecliente.TabIndex = 11;
            this.ToolTPedido.SetToolTip(this.txtNombrecliente, "Nombre Del Cliente Asignado");
            // 
            // ErrorPPedido
            // 
            this.ErrorPPedido.ContainerControl = this;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 447);
            this.Controls.Add(this.txtNombrecliente);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidos";
            this.Text = "Alta De Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPedido)).EndInit();
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
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.ToolTip ToolTPedido;
        private System.Windows.Forms.ErrorProvider ErrorPPedido;
    }
}