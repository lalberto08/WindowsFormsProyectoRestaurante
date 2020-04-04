namespace WindowsFormsProyectoRestaurante
{
    partial class frmAsignaMesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.errorpAsignaMesa = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipAsigna = new System.Windows.Forms.ToolTip(this.components);
            this.cmbNumMesa = new System.Windows.Forms.ComboBox();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorpAsignaMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(12, 38);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(140, 17);
            this.lblNumMesa.TabIndex = 1;
            this.lblNumMesa.Text = "Numero de Mesa";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCliente.Location = new System.Drawing.Point(174, 90);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(180, 20);
            this.txtNombreCliente.TabIndex = 1;
            this.toolTipAsigna.SetToolTip(this.txtNombreCliente, "Ingresa el nombre del Cliente");
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            this.txtNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreCliente_Validating);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(215, 215);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(139, 34);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.toolTipAsigna.SetToolTip(this.btnAsignar, "Click Para Asignar Mesa A Cliente");
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // errorpAsignaMesa
            // 
            this.errorpAsignaMesa.ContainerControl = this;
            // 
            // cmbNumMesa
            // 
            this.cmbNumMesa.CausesValidation = false;
            this.cmbNumMesa.FormattingEnabled = true;
            this.cmbNumMesa.Location = new System.Drawing.Point(174, 37);
            this.cmbNumMesa.Name = "cmbNumMesa";
            this.cmbNumMesa.Size = new System.Drawing.Size(79, 21);
            this.cmbNumMesa.TabIndex = 0;
            this.toolTipAsigna.SetToolTip(this.cmbNumMesa, "Selecciona Numero de Mesa");
            this.cmbNumMesa.SelectedIndexChanged += new System.EventHandler(this.cmbNumMesa_SelectedIndexChanged);
            this.cmbNumMesa.Validating += new System.ComponentModel.CancelEventHandler(this.cmbNumMesa_Validating);
            this.cmbNumMesa.Validated += new System.EventHandler(this.cmbNumMesa_Validated);
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumMesa,
            this.NombreCliente,
            this.Descripcion,
            this.NumPersonas,
            this.Estatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesas.EnableHeadersVisualStyles = false;
            this.dgvMesas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMesas.Location = new System.Drawing.Point(-1, 130);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.Size = new System.Drawing.Size(604, 79);
            this.dgvMesas.TabIndex = 3;
            this.toolTipAsigna.SetToolTip(this.dgvMesas, "Informacion de la Mesa");
            // 
            // NumMesa
            // 
            this.NumMesa.HeaderText = "Numero de Mesa";
            this.NumMesa.Name = "NumMesa";
            this.NumMesa.ReadOnly = true;
            this.NumMesa.Width = 80;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre del Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // NumPersonas
            // 
            this.NumPersonas.HeaderText = "Numero de Personas";
            this.NumPersonas.Name = "NumPersonas";
            this.NumPersonas.ReadOnly = true;
            this.NumPersonas.Width = 80;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 140;
            // 
            // frmAsignaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(600, 257);
            this.Controls.Add(this.cmbNumMesa);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumMesa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignaMesa";
            this.Text = "Asignar Mesa";
            this.Load += new System.EventHandler(this.frmAsignaMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorpAsignaMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ToolTip toolTipAsigna;
        private System.Windows.Forms.ErrorProvider errorpAsignaMesa;
        private System.Windows.Forms.ComboBox cmbNumMesa;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}