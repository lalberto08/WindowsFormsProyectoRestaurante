namespace WindowsFormsProyectoRestaurante
{
    partial class frmPagarCuenta
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
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.cmbNumPe = new System.Windows.Forms.ComboBox();
            this.cbxDescuento = new System.Windows.Forms.CheckBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvPagarCuenta = new System.Windows.Forms.DataGridView();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumBebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPlatillos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagarCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.Location = new System.Drawing.Point(12, 19);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(158, 17);
            this.lblNumPedido.TabIndex = 0;
            this.lblNumPedido.Text = "Numero del Pedido";
            // 
            // cmbNumPe
            // 
            this.cmbNumPe.FormattingEnabled = true;
            this.cmbNumPe.Location = new System.Drawing.Point(171, 19);
            this.cmbNumPe.Name = "cmbNumPe";
            this.cmbNumPe.Size = new System.Drawing.Size(121, 21);
            this.cmbNumPe.TabIndex = 0;
            this.cmbNumPe.SelectedIndexChanged += new System.EventHandler(this.cmbNumPe_SelectedIndexChanged);
            // 
            // cbxDescuento
            // 
            this.cbxDescuento.AutoSize = true;
            this.cbxDescuento.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDescuento.Location = new System.Drawing.Point(332, 16);
            this.cbxDescuento.Name = "cbxDescuento";
            this.cbxDescuento.Size = new System.Drawing.Size(103, 20);
            this.cbxDescuento.TabIndex = 1;
            this.cbxDescuento.Text = "Descuento";
            this.cbxDescuento.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(332, 42);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(117, 39);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(49, 62);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(116, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total a pagar";
            // 
            // dgvPagarCuenta
            // 
            this.dgvPagarCuenta.AllowUserToAddRows = false;
            this.dgvPagarCuenta.AllowUserToDeleteRows = false;
            this.dgvPagarCuenta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvPagarCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagarCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagarCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagarCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagarCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumMesa,
            this.NumBebidas,
            this.ImporteB,
            this.NumeroPlatillos,
            this.Importe});
            this.dgvPagarCuenta.Location = new System.Drawing.Point(1, 99);
            this.dgvPagarCuenta.Name = "dgvPagarCuenta";
            this.dgvPagarCuenta.ReadOnly = true;
            this.dgvPagarCuenta.RowHeadersVisible = false;
            this.dgvPagarCuenta.Size = new System.Drawing.Size(482, 122);
            this.dgvPagarCuenta.TabIndex = 5;
            // 
            // NumMesa
            // 
            this.NumMesa.HeaderText = "Numero De Mesa";
            this.NumMesa.Name = "NumMesa";
            this.NumMesa.ReadOnly = true;
            // 
            // NumBebidas
            // 
            this.NumBebidas.HeaderText = "Numero De Bebidas";
            this.NumBebidas.Name = "NumBebidas";
            this.NumBebidas.ReadOnly = true;
            this.NumBebidas.Width = 80;
            // 
            // ImporteB
            // 
            this.ImporteB.HeaderText = "Importe Bebidas";
            this.ImporteB.Name = "ImporteB";
            this.ImporteB.ReadOnly = true;
            // 
            // NumeroPlatillos
            // 
            this.NumeroPlatillos.HeaderText = "Cantidad De Platillos";
            this.NumeroPlatillos.Name = "NumeroPlatillos";
            this.NumeroPlatillos.ReadOnly = true;
            this.NumeroPlatillos.Width = 80;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe Platillos";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 120;
            // 
            // frmPagarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(480, 238);
            this.Controls.Add(this.dgvPagarCuenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cbxDescuento);
            this.Controls.Add(this.cmbNumPe);
            this.Controls.Add(this.lblNumPedido);
            this.Name = "frmPagarCuenta";
            this.Text = "Pagar Cuenta";
            this.Load += new System.EventHandler(this.frmPagarCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagarCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.ComboBox cmbNumPe;
        private System.Windows.Forms.CheckBox cbxDescuento;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvPagarCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPlatillos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}