namespace WindowsFormsProyectoRestaurante
{
    partial class frmConsultaPlatillos
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
            this.dgvConsultaPlatillos = new System.Windows.Forms.DataGridView();
            this.ClavePlatillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPlatillos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaPlatillos
            // 
            this.dgvConsultaPlatillos.AllowUserToAddRows = false;
            this.dgvConsultaPlatillos.AllowUserToDeleteRows = false;
            this.dgvConsultaPlatillos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConsultaPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPlatillos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClavePlatillo,
            this.Descripcion,
            this.Importe,
            this.Tiempo});
            this.dgvConsultaPlatillos.Location = new System.Drawing.Point(-2, -1);
            this.dgvConsultaPlatillos.Name = "dgvConsultaPlatillos";
            this.dgvConsultaPlatillos.ReadOnly = true;
            this.dgvConsultaPlatillos.Size = new System.Drawing.Size(543, 336);
            this.dgvConsultaPlatillos.TabIndex = 0;
            // 
            // ClavePlatillo
            // 
            this.ClavePlatillo.HeaderText = "Clave del Platillo";
            this.ClavePlatillo.Name = "ClavePlatillo";
            this.ClavePlatillo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
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
            // frmConsultaPlatillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 333);
            this.Controls.Add(this.dgvConsultaPlatillos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaPlatillos";
            this.Text = "Consulta de Platillos";
            this.Load += new System.EventHandler(this.frmConsultaPlatillos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPlatillos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaPlatillos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClavePlatillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
    }
}