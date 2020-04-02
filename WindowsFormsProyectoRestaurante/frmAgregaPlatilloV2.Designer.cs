namespace WindowsFormsProyectoRestaurante
{
    partial class frmAgregaPlatilloV2
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
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgvPlatillo = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numUpCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQuitar.Location = new System.Drawing.Point(322, 126);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(137, 24);
            this.btnQuitar.TabIndex = 20;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.Location = new System.Drawing.Point(31, 36);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(138, 16);
            this.lblNumPedido.TabIndex = 19;
            this.lblNumPedido.Text = "Numero de Pedido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(370, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // dtgvPlatillo
            // 
            this.dtgvPlatillo.AllowUserToAddRows = false;
            this.dtgvPlatillo.AllowUserToDeleteRows = false;
            this.dtgvPlatillo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvPlatillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPlatillo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cant,
            this.Importe,
            this.Tiempo});
            this.dtgvPlatillo.Location = new System.Drawing.Point(17, 156);
            this.dtgvPlatillo.Name = "dtgvPlatillo";
            this.dtgvPlatillo.ReadOnly = true;
            this.dtgvPlatillo.Size = new System.Drawing.Size(545, 183);
            this.dtgvPlatillo.TabIndex = 16;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo de Preparacion";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(229, 373);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(105, 34);
            this.btnTerminar.TabIndex = 15;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(168, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 24);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numUpCantidad
            // 
            this.numUpCantidad.Location = new System.Drawing.Point(446, 81);
            this.numUpCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpCantidad.Name = "numUpCantidad";
            this.numUpCantidad.Size = new System.Drawing.Size(82, 20);
            this.numUpCantidad.TabIndex = 13;
            this.numUpCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(370, 81);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 16);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(209, 80);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(138, 21);
            this.cmbDescripcion.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(165, 16);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion de Platillo";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(209, 35);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.ReadOnly = true;
            this.txtNumPedido.Size = new System.Drawing.Size(120, 20);
            this.txtNumPedido.TabIndex = 21;
            // 
            // frmAgregaPlatilloV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.ControlBox = false;
            this.Controls.Add(this.txtNumPedido);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblNumPedido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtgvPlatillo);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numUpCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmAgregaPlatilloV2";
            this.Text = "Agrega Platillo";
            this.Load += new System.EventHandler(this.frmAgregaPlatilloV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgvPlatillo;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numUpCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
    }
}