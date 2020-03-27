namespace WindowsFormsProyectoRestaurante
{
    partial class frmAltaMesas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumUpMesa = new System.Windows.Forms.NumericUpDown();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ErrorPMesas = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolPMesas = new System.Windows.Forms.ToolTip(this.components);
            this.numUpNumPer = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpNumPer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(117, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alta De Mesas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero De Mesa";
            // 
            // NumUpMesa
            // 
            this.NumUpMesa.Location = new System.Drawing.Point(188, 99);
            this.NumUpMesa.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumUpMesa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpMesa.Name = "NumUpMesa";
            this.NumUpMesa.Size = new System.Drawing.Size(74, 20);
            this.NumUpMesa.TabIndex = 0;
            this.toolPMesas.SetToolTip(this.NumUpMesa, "Selecciona Un Numero De Mesa");
            this.NumUpMesa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersonas.Location = new System.Drawing.Point(31, 206);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(136, 16);
            this.lblNumPersonas.TabIndex = 2;
            this.lblNumPersonas.Text = "Numero de Personas";
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Items.AddRange(new object[] {
            "Chica",
            "Mediana",
            "Grande",
            "Familiar",
            "Individual"});
            this.cmbDescripcion.Location = new System.Drawing.Point(188, 154);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(121, 21);
            this.cmbDescripcion.TabIndex = 1;
            this.toolPMesas.SetToolTip(this.cmbDescripcion, "Seleccione Un Tipo De Mesa");
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 155);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(66, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.toolPMesas.SetToolTip(this.btnGuardar, "Click Para Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(215, 284);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.toolPMesas.SetToolTip(this.btnSalir, "Click Para Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ErrorPMesas
            // 
            this.ErrorPMesas.ContainerControl = this;
            // 
            // numUpNumPer
            // 
            this.numUpNumPer.Location = new System.Drawing.Point(188, 206);
            this.numUpNumPer.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpNumPer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpNumPer.Name = "numUpNumPer";
            this.numUpNumPer.Size = new System.Drawing.Size(74, 20);
            this.numUpNumPer.TabIndex = 2;
            this.numUpNumPer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmAltaMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(366, 340);
            this.ControlBox = false;
            this.Controls.Add(this.numUpNumPer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbDescripcion);
            this.Controls.Add(this.lblNumPersonas);
            this.Controls.Add(this.NumUpMesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaMesas";
            this.Text = "Alta De Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpNumPer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumUpMesa;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolPMesas;
        private System.Windows.Forms.ErrorProvider ErrorPMesas;
        private System.Windows.Forms.NumericUpDown numUpNumPer;
    }
}