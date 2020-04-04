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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.NumPe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumBebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPlatillos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPe,
            this.NumMesa,
            this.NumBebidas,
            this.NumPlatillos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.Location = new System.Drawing.Point(1, -3);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.Size = new System.Drawing.Size(485, 247);
            this.dgvPedidos.TabIndex = 0;
            // 
            // NumPe
            // 
            this.NumPe.HeaderText = "Numero de Pedido";
            this.NumPe.Name = "NumPe";
            this.NumPe.ReadOnly = true;
            this.NumPe.Width = 110;
            // 
            // NumMesa
            // 
            this.NumMesa.HeaderText = "Numero de Mesa";
            this.NumMesa.Name = "NumMesa";
            this.NumMesa.ReadOnly = true;
            this.NumMesa.Width = 110;
            // 
            // NumBebidas
            // 
            this.NumBebidas.HeaderText = "Numero de Bebidas";
            this.NumBebidas.Name = "NumBebidas";
            this.NumBebidas.ReadOnly = true;
            this.NumBebidas.Width = 130;
            // 
            // NumPlatillos
            // 
            this.NumPlatillos.HeaderText = "Numero de Platillos";
            this.NumPlatillos.Name = "NumPlatillos";
            this.NumPlatillos.ReadOnly = true;
            this.NumPlatillos.Width = 130;
            // 
            // frmReportePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 245);
            this.Controls.Add(this.dgvPedidos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportePedidos";
            this.Text = "Reporte De Pedidos";
            this.Load += new System.EventHandler(this.frmReportePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPlatillos;
    }
}