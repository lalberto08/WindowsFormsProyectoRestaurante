﻿namespace WindowsFormsProyectoRestaurante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumPe = new System.Windows.Forms.TextBox();
            this.lblNumPe = new System.Windows.Forms.Label();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.cmbNumMesa = new System.Windows.Forms.ComboBox();
            this.lblNumBebidas = new System.Windows.Forms.Label();
            this.numUpBebidas = new System.Windows.Forms.NumericUpDown();
            this.btnAgregaPlatillo = new System.Windows.Forms.Button();
            this.btmGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.ErrorPPedido = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTPedido = new System.Windows.Forms.ToolTip(this.components);
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPe
            // 
            this.txtNumPe.CausesValidation = false;
            this.txtNumPe.Location = new System.Drawing.Point(394, 116);
            this.txtNumPe.Name = "txtNumPe";
            this.txtNumPe.Size = new System.Drawing.Size(150, 20);
            this.txtNumPe.TabIndex = 0;
            this.ToolTPedido.SetToolTip(this.txtNumPe, "Numero Del Pedido");
            this.txtNumPe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPe_KeyPress);
            this.txtNumPe.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumPe_Validating);
            // 
            // lblNumPe
            // 
            this.lblNumPe.AutoSize = true;
            this.lblNumPe.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPe.Location = new System.Drawing.Point(391, 97);
            this.lblNumPe.Name = "lblNumPe";
            this.lblNumPe.Size = new System.Drawing.Size(153, 17);
            this.lblNumPe.TabIndex = 1;
            this.lblNumPe.Text = "Numero de Pedido";
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(59, 95);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(140, 17);
            this.lblNumMesa.TabIndex = 2;
            this.lblNumMesa.Text = "Numero de Mesa";
            // 
            // cmbNumMesa
            // 
            this.cmbNumMesa.CausesValidation = false;
            this.cmbNumMesa.FormattingEnabled = true;
            this.cmbNumMesa.Location = new System.Drawing.Point(62, 116);
            this.cmbNumMesa.Name = "cmbNumMesa";
            this.cmbNumMesa.Size = new System.Drawing.Size(137, 21);
            this.cmbNumMesa.TabIndex = 0;
            this.ToolTPedido.SetToolTip(this.cmbNumMesa, "Numero De Mesa");
            this.cmbNumMesa.SelectedIndexChanged += new System.EventHandler(this.cmbNumMesa_SelectedIndexChanged);
            this.cmbNumMesa.Validating += new System.ComponentModel.CancelEventHandler(this.cmbNumMesa_Validating);
            this.cmbNumMesa.Validated += new System.EventHandler(this.cmbNumMesa_Validated);
            // 
            // lblNumBebidas
            // 
            this.lblNumBebidas.AutoSize = true;
            this.lblNumBebidas.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBebidas.Location = new System.Drawing.Point(12, 262);
            this.lblNumBebidas.Name = "lblNumBebidas";
            this.lblNumBebidas.Size = new System.Drawing.Size(160, 17);
            this.lblNumBebidas.TabIndex = 4;
            this.lblNumBebidas.Text = "Numero de Bebidas";
            // 
            // numUpBebidas
            // 
            this.numUpBebidas.Location = new System.Drawing.Point(178, 262);
            this.numUpBebidas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpBebidas.Name = "numUpBebidas";
            this.numUpBebidas.Size = new System.Drawing.Size(51, 20);
            this.numUpBebidas.TabIndex = 1;
            this.ToolTPedido.SetToolTip(this.numUpBebidas, "Numero De Bebidas");
            // 
            // btnAgregaPlatillo
            // 
            this.btnAgregaPlatillo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregaPlatillo.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaPlatillo.Location = new System.Drawing.Point(394, 254);
            this.btnAgregaPlatillo.Name = "btnAgregaPlatillo";
            this.btnAgregaPlatillo.Size = new System.Drawing.Size(144, 32);
            this.btnAgregaPlatillo.TabIndex = 2;
            this.btnAgregaPlatillo.Text = "Agrega Platillo";
            this.ToolTPedido.SetToolTip(this.btnAgregaPlatillo, "Click Para Agregar Platillo");
            this.btnAgregaPlatillo.UseVisualStyleBackColor = true;
            this.btnAgregaPlatillo.Click += new System.EventHandler(this.btnAgregaPlatillo_Click);
            // 
            // btmGuardar
            // 
            this.btmGuardar.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGuardar.Location = new System.Drawing.Point(225, 317);
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(146, 49);
            this.btmGuardar.TabIndex = 3;
            this.btmGuardar.Text = "Guardar Pedido";
            this.ToolTPedido.SetToolTip(this.btmGuardar, "Click Para Guardar Pedido");
            this.btmGuardar.UseVisualStyleBackColor = true;
            this.btmGuardar.Click += new System.EventHandler(this.btmGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(180, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 38);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Alta de Pedidos";
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesas.EnableHeadersVisualStyles = false;
            this.dgvMesas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMesas.Location = new System.Drawing.Point(-1, 152);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.Size = new System.Drawing.Size(611, 74);
            this.dgvMesas.TabIndex = 9;
            this.ToolTPedido.SetToolTip(this.dgvMesas, "Informacion De La Mesa");
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(215, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 17);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.Location = new System.Drawing.Point(218, 116);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(153, 20);
            this.txtNombrecliente.TabIndex = 11;
            this.ToolTPedido.SetToolTip(this.txtNombrecliente, "Nombre Del Cliente Asignado");
            // 
            // ErrorPPedido
            // 
            this.ErrorPPedido.ContainerControl = this;
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
            this.Descripcion.Width = 110;
            // 
            // NumPersonas
            // 
            this.NumPersonas.HeaderText = "Numero de Personas";
            this.NumPersonas.Name = "NumPersonas";
            this.NumPersonas.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 120;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(609, 378);
            this.Controls.Add(this.txtNombrecliente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btmGuardar);
            this.Controls.Add(this.btnAgregaPlatillo);
            this.Controls.Add(this.numUpBebidas);
            this.Controls.Add(this.lblNumBebidas);
            this.Controls.Add(this.cmbNumMesa);
            this.Controls.Add(this.lblNumMesa);
            this.Controls.Add(this.lblNumPe);
            this.Controls.Add(this.txtNumPe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidos";
            this.Text = "Alta De Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPedido)).EndInit();
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.ToolTip ToolTPedido;
        private System.Windows.Forms.ErrorProvider ErrorPPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}