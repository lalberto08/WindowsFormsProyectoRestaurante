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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConsultaPlatillos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvConsultaPlatillos.BackgroundColor = System.Drawing.Color.Crimson;
            this.dgvConsultaPlatillos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaPlatillos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPlatillos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClavePlatillo,
            this.Descripcion,
            this.Importe,
            this.Tiempo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaPlatillos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultaPlatillos.EnableHeadersVisualStyles = false;
            this.dgvConsultaPlatillos.Location = new System.Drawing.Point(-3, 48);
            this.dgvConsultaPlatillos.Name = "dgvConsultaPlatillos";
            this.dgvConsultaPlatillos.ReadOnly = true;
            this.dgvConsultaPlatillos.RowHeadersVisible = false;
            this.dgvConsultaPlatillos.Size = new System.Drawing.Size(543, 324);
            this.dgvConsultaPlatillos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÚ DE PLATILLOS";
            // 
            // ClavePlatillo
            // 
            this.ClavePlatillo.HeaderText = "Clave del Platillo";
            this.ClavePlatillo.Name = "ClavePlatillo";
            this.ClavePlatillo.ReadOnly = true;
            this.ClavePlatillo.Width = 110;
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
            this.Importe.Width = 110;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo de Preparacion";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            this.Tiempo.Width = 120;
            // 
            // frmConsultaPlatillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(539, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultaPlatillos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaPlatillos";
            this.Text = "Consulta de Platillos";
            this.Load += new System.EventHandler(this.frmConsultaPlatillos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPlatillos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaPlatillos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClavePlatillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.Label label1;
    }
}