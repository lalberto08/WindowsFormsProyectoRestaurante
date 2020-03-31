namespace WindowsFormsProyectoRestaurante
{
    partial class frmReportePedidos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumPe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumBebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPlatillos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPe,
            this.NumMesa,
            this.NumBebidas,
            this.NumPlatillos});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // NumPe
            // 
            this.NumPe.HeaderText = "Numero de Pedido";
            this.NumPe.Name = "NumPe";
            this.NumPe.ReadOnly = true;
            // 
            // NumMesa
            // 
            this.NumMesa.HeaderText = "Numero de Mesa";
            this.NumMesa.Name = "NumMesa";
            this.NumMesa.ReadOnly = true;
            // 
            // NumBebidas
            // 
            this.NumBebidas.HeaderText = "Numero de Bebidas";
            this.NumBebidas.Name = "NumBebidas";
            this.NumBebidas.ReadOnly = true;
            // 
            // NumPlatillos
            // 
            this.NumPlatillos.HeaderText = "Numero de Platillos";
            this.NumPlatillos.Name = "NumPlatillos";
            this.NumPlatillos.ReadOnly = true;
            // 
            // frmReportePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 245);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmReportePedidos";
            this.Text = "frmReportePedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPlatillos;
    }
}