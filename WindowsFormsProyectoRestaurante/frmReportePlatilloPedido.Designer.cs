namespace WindowsFormsProyectoRestaurante
{
    partial class frmReportePlatilloPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGReportePlaPed = new System.Windows.Forms.DataGridView();
            this.NumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPlatillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGReportePlaPed)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGReportePlaPed
            // 
            this.DataGReportePlaPed.AllowUserToAddRows = false;
            this.DataGReportePlaPed.AllowUserToDeleteRows = false;
            this.DataGReportePlaPed.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.DataGReportePlaPed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGReportePlaPed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGReportePlaPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGReportePlaPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPedido,
            this.NumPlatillo,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGReportePlaPed.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGReportePlaPed.EnableHeadersVisualStyles = false;
            this.DataGReportePlaPed.Location = new System.Drawing.Point(-1, 0);
            this.DataGReportePlaPed.Name = "DataGReportePlaPed";
            this.DataGReportePlaPed.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGReportePlaPed.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGReportePlaPed.RowHeadersVisible = false;
            this.DataGReportePlaPed.Size = new System.Drawing.Size(341, 263);
            this.DataGReportePlaPed.TabIndex = 0;
            // 
            // NumPedido
            // 
            this.NumPedido.HeaderText = "Numero de Pedido";
            this.NumPedido.Name = "NumPedido";
            this.NumPedido.ReadOnly = true;
            this.NumPedido.Width = 110;
            // 
            // NumPlatillo
            // 
            this.NumPlatillo.HeaderText = "Numero de Platillo";
            this.NumPlatillo.Name = "NumPlatillo";
            this.NumPlatillo.ReadOnly = true;
            this.NumPlatillo.Width = 110;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 110;
            // 
            // frmReportePlatilloPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.DataGReportePlaPed);
            this.Name = "frmReportePlatilloPedido";
            this.Text = "Reporte Platillo Pedidos";
            this.Load += new System.EventHandler(this.frmReportePlatilloPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGReportePlaPed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGReportePlaPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPlatillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}