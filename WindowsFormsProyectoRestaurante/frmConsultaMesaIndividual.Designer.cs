namespace WindowsFormsProyectoRestaurante
{
    partial class frmConsultaMesaIndividual
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
            this.cmbNumMesa = new System.Windows.Forms.ComboBox();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNumMesa
            // 
            this.cmbNumMesa.FormattingEnabled = true;
            this.cmbNumMesa.Location = new System.Drawing.Point(229, 54);
            this.cmbNumMesa.Name = "cmbNumMesa";
            this.cmbNumMesa.Size = new System.Drawing.Size(101, 21);
            this.cmbNumMesa.TabIndex = 4;
            this.cmbNumMesa.SelectedIndexChanged += new System.EventHandler(this.cmbNumMesa_SelectedIndexChanged);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesas.EnableHeadersVisualStyles = false;
            this.dgvMesas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMesas.Location = new System.Drawing.Point(0, 114);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.Size = new System.Drawing.Size(604, 76);
            this.dgvMesas.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(353, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(221, 24);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(12, 51);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(197, 24);
            this.lblNumMesa.TabIndex = 6;
            this.lblNumMesa.Text = "Numero de Mesa";
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
            // frmConsultaMesaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(601, 188);
            this.Controls.Add(this.cmbNumMesa);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumMesa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaMesaIndividual";
            this.Text = "Consulta Mesa Individual";
            this.Load += new System.EventHandler(this.frmConsultaMesaIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNumMesa;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}