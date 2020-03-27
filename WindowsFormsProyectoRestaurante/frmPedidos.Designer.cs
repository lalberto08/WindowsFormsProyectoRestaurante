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
            this.txtNumPe = new System.Windows.Forms.TextBox();
            this.lblNumPe = new System.Windows.Forms.Label();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.cmbNumMesa = new System.Windows.Forms.ComboBox();
            this.lblNumBebidas = new System.Windows.Forms.Label();
            this.numUpBebidas = new System.Windows.Forms.NumericUpDown();
            this.btnAgregaPlatillo = new System.Windows.Forms.Button();
            this.btmGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPe
            // 
            this.txtNumPe.Location = new System.Drawing.Point(66, 62);
            this.txtNumPe.Name = "txtNumPe";
            this.txtNumPe.ReadOnly = true;
            this.txtNumPe.Size = new System.Drawing.Size(100, 20);
            this.txtNumPe.TabIndex = 0;
            // 
            // lblNumPe
            // 
            this.lblNumPe.AutoSize = true;
            this.lblNumPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPe.Location = new System.Drawing.Point(63, 31);
            this.lblNumPe.Name = "lblNumPe";
            this.lblNumPe.Size = new System.Drawing.Size(122, 16);
            this.lblNumPe.TabIndex = 1;
            this.lblNumPe.Text = "Numero de Pedido";
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(222, 31);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(112, 16);
            this.lblNumMesa.TabIndex = 2;
            this.lblNumMesa.Text = "Numero de Mesa";
            // 
            // cmbNumMesa
            // 
            this.cmbNumMesa.FormattingEnabled = true;
            this.cmbNumMesa.Location = new System.Drawing.Point(225, 61);
            this.cmbNumMesa.Name = "cmbNumMesa";
            this.cmbNumMesa.Size = new System.Drawing.Size(121, 21);
            this.cmbNumMesa.TabIndex = 3;
            // 
            // lblNumBebidas
            // 
            this.lblNumBebidas.AutoSize = true;
            this.lblNumBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBebidas.Location = new System.Drawing.Point(66, 122);
            this.lblNumBebidas.Name = "lblNumBebidas";
            this.lblNumBebidas.Size = new System.Drawing.Size(129, 16);
            this.lblNumBebidas.TabIndex = 4;
            this.lblNumBebidas.Text = "Numero de Bebidas";
            // 
            // numUpBebidas
            // 
            this.numUpBebidas.Location = new System.Drawing.Point(66, 161);
            this.numUpBebidas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpBebidas.Name = "numUpBebidas";
            this.numUpBebidas.Size = new System.Drawing.Size(69, 20);
            this.numUpBebidas.TabIndex = 5;
            // 
            // btnAgregaPlatillo
            // 
            this.btnAgregaPlatillo.Location = new System.Drawing.Point(230, 156);
            this.btnAgregaPlatillo.Name = "btnAgregaPlatillo";
            this.btnAgregaPlatillo.Size = new System.Drawing.Size(104, 27);
            this.btnAgregaPlatillo.TabIndex = 6;
            this.btnAgregaPlatillo.Text = "Agrega Platillo";
            this.btnAgregaPlatillo.UseVisualStyleBackColor = true;
            this.btnAgregaPlatillo.Click += new System.EventHandler(this.btnAgregaPlatillo_Click);
            // 
            // btmGuardar
            // 
            this.btmGuardar.Location = new System.Drawing.Point(141, 215);
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(118, 43);
            this.btmGuardar.TabIndex = 7;
            this.btmGuardar.Text = "Guarda Pedido";
            this.btmGuardar.UseVisualStyleBackColor = true;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 282);
            this.Controls.Add(this.btmGuardar);
            this.Controls.Add(this.btnAgregaPlatillo);
            this.Controls.Add(this.numUpBebidas);
            this.Controls.Add(this.lblNumBebidas);
            this.Controls.Add(this.cmbNumMesa);
            this.Controls.Add(this.lblNumMesa);
            this.Controls.Add(this.lblNumPe);
            this.Controls.Add(this.txtNumPe);
            this.Name = "frmPedidos";
            this.Text = "Alta De Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).EndInit();
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
    }
}