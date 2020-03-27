namespace WindowsFormsProyectoRestaurante
{
    partial class frmCierreDia
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
            this.VentasRealizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPlaPe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumBebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VentasRealizadas,
            this.numPlaPe,
            this.numPe,
            this.Importe,
            this.NumBebidas,
            this.ImporteB});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // VentasRealizadas
            // 
            this.VentasRealizadas.HeaderText = "Ventas Realizadas";
            this.VentasRealizadas.Name = "VentasRealizadas";
            this.VentasRealizadas.ReadOnly = true;
            // 
            // numPlaPe
            // 
            this.numPlaPe.HeaderText = "Numero de Platillo";
            this.numPlaPe.Name = "numPlaPe";
            this.numPlaPe.ReadOnly = true;
            // 
            // numPe
            // 
            this.numPe.HeaderText = "Numero de Pedido";
            this.numPe.Name = "numPe";
            this.numPe.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // NumBebidas
            // 
            this.NumBebidas.HeaderText = "Numero de Bebidas";
            this.NumBebidas.Name = "NumBebidas";
            this.NumBebidas.ReadOnly = true;
            // 
            // ImporteB
            // 
            this.ImporteB.HeaderText = "Importe";
            this.ImporteB.Name = "ImporteB";
            this.ImporteB.ReadOnly = true;
            // 
            // frmCierreDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 324);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCierreDia";
            this.Text = "frmCierreDia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasRealizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPlaPe;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteB;
    }
}