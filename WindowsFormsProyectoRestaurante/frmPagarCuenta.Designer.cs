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
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.cmbNumPe = new System.Windows.Forms.ComboBox();
            this.cbxDescuento = new System.Windows.Forms.CheckBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.Location = new System.Drawing.Point(36, 35);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(125, 16);
            this.lblNumPedido.TabIndex = 0;
            this.lblNumPedido.Text = "Numero del Pedido";
            // 
            // cmbNumPe
            // 
            this.cmbNumPe.FormattingEnabled = true;
            this.cmbNumPe.Location = new System.Drawing.Point(39, 71);
            this.cmbNumPe.Name = "cmbNumPe";
            this.cmbNumPe.Size = new System.Drawing.Size(121, 21);
            this.cmbNumPe.TabIndex = 0;
            // 
            // cbxDescuento
            // 
            this.cbxDescuento.AutoSize = true;
            this.cbxDescuento.Location = new System.Drawing.Point(39, 128);
            this.cbxDescuento.Name = "cbxDescuento";
            this.cbxDescuento.Size = new System.Drawing.Size(78, 17);
            this.cbxDescuento.TabIndex = 1;
            this.cbxDescuento.Text = "Descuento";
            this.cbxDescuento.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(49, 230);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(101, 39);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(57, 167);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total a pagar";
            // 
            // frmPagarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 288);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cbxDescuento);
            this.Controls.Add(this.cmbNumPe);
            this.Controls.Add(this.lblNumPedido);
            this.Name = "frmPagarCuenta";
            this.Text = "Pagar Cuenta";
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
    }
}