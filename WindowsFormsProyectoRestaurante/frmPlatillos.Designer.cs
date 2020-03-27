namespace WindowsFormsProyectoRestaurante
{
    partial class frmPlatillos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClavePlatillo = new System.Windows.Forms.Label();
            this.txtClavePlatillo = new System.Windows.Forms.TextBox();
            this.ErrorPPlatillos = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTPlatillos = new System.Windows.Forms.ToolTip(this.components);
            this.txtImportePlatillo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.numUpTiempo = new System.Windows.Forms.NumericUpDown();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPlatillos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta De Platillos";
            // 
            // lblClavePlatillo
            // 
            this.lblClavePlatillo.AutoSize = true;
            this.lblClavePlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClavePlatillo.Location = new System.Drawing.Point(27, 85);
            this.lblClavePlatillo.Name = "lblClavePlatillo";
            this.lblClavePlatillo.Size = new System.Drawing.Size(124, 16);
            this.lblClavePlatillo.TabIndex = 1;
            this.lblClavePlatillo.Text = "Clave De Platillo";
            // 
            // txtClavePlatillo
            // 
            this.txtClavePlatillo.BackColor = System.Drawing.SystemColors.Control;
            this.txtClavePlatillo.Location = new System.Drawing.Point(30, 119);
            this.txtClavePlatillo.Name = "txtClavePlatillo";
            this.txtClavePlatillo.ReadOnly = true;
            this.txtClavePlatillo.Size = new System.Drawing.Size(125, 20);
            this.txtClavePlatillo.TabIndex = 10;
            this.toolTPlatillos.SetToolTip(this.txtClavePlatillo, "Clave Del Platillo");
            this.txtClavePlatillo.TextChanged += new System.EventHandler(this.txtClavePlatillo_TextChanged);
            // 
            // ErrorPPlatillos
            // 
            this.ErrorPPlatillos.ContainerControl = this;
            // 
            // txtImportePlatillo
            // 
            this.txtImportePlatillo.Location = new System.Drawing.Point(209, 168);
            this.txtImportePlatillo.Name = "txtImportePlatillo";
            this.txtImportePlatillo.Size = new System.Drawing.Size(92, 20);
            this.txtImportePlatillo.TabIndex = 1;
            this.toolTPlatillos.SetToolTip(this.txtImportePlatillo, "Costo Del Platillo");
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(76, 266);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 34);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.toolTPlatillos.SetToolTip(this.btnRegistrar, "Click Para Registrar");
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(199, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.toolTPlatillos.SetToolTip(this.btnSalir, "Click Para Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // numUpTiempo
            // 
            this.numUpTiempo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpTiempo.Location = new System.Drawing.Point(209, 207);
            this.numUpTiempo.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpTiempo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpTiempo.Name = "numUpTiempo";
            this.numUpTiempo.Size = new System.Drawing.Size(60, 20);
            this.numUpTiempo.TabIndex = 2;
            this.numUpTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTPlatillos.SetToolTip(this.numUpTiempo, "Tiempo De Preparacion En Minutos");
            this.numUpTiempo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numUpTiempo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(27, 169);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(131, 15);
            this.lblImporte.TabIndex = 3;
            this.lblImporte.Text = "Importe Del Platillo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(210, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 16);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tiempo De Preparacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(187, 119);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(137, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // frmPlatillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(351, 334);
            this.ControlBox = false;
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpTiempo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtImportePlatillo);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtClavePlatillo);
            this.Controls.Add(this.lblClavePlatillo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlatillos";
            this.Text = "Alta De Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPlatillos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClavePlatillo;
        private System.Windows.Forms.TextBox txtClavePlatillo;
        private System.Windows.Forms.ErrorProvider ErrorPPlatillos;
        private System.Windows.Forms.TextBox txtImportePlatillo;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.ToolTip toolTPlatillos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpTiempo;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}