namespace WindowsFormsProyectoRestaurante
{
    partial class frmConsultaMesas
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
            this.dgvConsultaMesas = new System.Windows.Forms.DataGridView();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaMesas
            // 
            this.dgvConsultaMesas.AllowUserToAddRows = false;
            this.dgvConsultaMesas.AllowUserToDeleteRows = false;
            this.dgvConsultaMesas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvConsultaMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumMesa,
            this.NombreCliente,
            this.Descripcion,
            this.NumPersonas,
            this.Estatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaMesas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaMesas.EnableHeadersVisualStyles = false;
            this.dgvConsultaMesas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConsultaMesas.Location = new System.Drawing.Point(-1, 1);
            this.dgvConsultaMesas.Name = "dgvConsultaMesas";
            this.dgvConsultaMesas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaMesas.RowHeadersVisible = false;
            this.dgvConsultaMesas.Size = new System.Drawing.Size(614, 287);
            this.dgvConsultaMesas.TabIndex = 0;
            // 
            // NumMesa
            // 
            this.NumMesa.HeaderText = "Numero De Mesa";
            this.NumMesa.Name = "NumMesa";
            this.NumMesa.ReadOnly = true;
            this.NumMesa.Width = 80;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Del Cliente";
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
            this.Estatus.Width = 150;
            // 
            // frmConsultaMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 290);
            this.Controls.Add(this.dgvConsultaMesas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaMesas";
            this.Text = "Consulta De Mesas";
            this.Load += new System.EventHandler(this.frmConsultaMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}