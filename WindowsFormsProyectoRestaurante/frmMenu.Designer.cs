namespace WindowsFormsProyectoRestaurante
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsignartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.platillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePlatillosPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaPlatilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitaPlatilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesasToolStripMenuItem,
            this.platillosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.manejoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.mesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.AsignartoolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem1});
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mesasToolStripMenuItem.Text = "Mesas";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem,
            this.todasToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.individualToolStripMenuItem.Text = "Individual";
            // 
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.todasToolStripMenuItem.Text = "Todas";
            this.todasToolStripMenuItem.Click += new System.EventHandler(this.todasToolStripMenuItem_Click);
            // 
            // AsignartoolStripMenuItem
            // 
            this.AsignartoolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.AsignartoolStripMenuItem.Name = "AsignartoolStripMenuItem";
            this.AsignartoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AsignartoolStripMenuItem.Text = "Asignar";
            this.AsignartoolStripMenuItem.Click += new System.EventHandler(this.AsignartoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // platillosToolStripMenuItem
            // 
            this.platillosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.consultarToolStripMenuItem1,
            this.reportePlatillosPedidosToolStripMenuItem});
            this.platillosToolStripMenuItem.Name = "platillosToolStripMenuItem";
            this.platillosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.platillosToolStripMenuItem.Text = "Platillos";
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.consultarToolStripMenuItem1.Text = "Consulta";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // reportePlatillosPedidosToolStripMenuItem
            // 
            this.reportePlatillosPedidosToolStripMenuItem.Name = "reportePlatillosPedidosToolStripMenuItem";
            this.reportePlatillosPedidosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.reportePlatillosPedidosToolStripMenuItem.Text = "Reporte Platillos Pedidos";
            this.reportePlatillosPedidosToolStripMenuItem.Click += new System.EventHandler(this.reportePlatillosPedidosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem2,
            this.reporteToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // registrarToolStripMenuItem2
            // 
            this.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2";
            this.registrarToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.registrarToolStripMenuItem2.Text = "Registrar";
            this.registrarToolStripMenuItem2.Click += new System.EventHandler(this.registrarToolStripMenuItem2_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem1,
            this.todosToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // individualToolStripMenuItem1
            // 
            this.individualToolStripMenuItem1.Name = "individualToolStripMenuItem1";
            this.individualToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.individualToolStripMenuItem1.Text = "Individual";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaPlatilloToolStripMenuItem,
            this.quitaPlatilloToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // agregaPlatilloToolStripMenuItem
            // 
            this.agregaPlatilloToolStripMenuItem.Name = "agregaPlatilloToolStripMenuItem";
            this.agregaPlatilloToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.agregaPlatilloToolStripMenuItem.Text = "Agrega Platillo";
            // 
            // quitaPlatilloToolStripMenuItem
            // 
            this.quitaPlatilloToolStripMenuItem.Name = "quitaPlatilloToolStripMenuItem";
            this.quitaPlatilloToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.quitaPlatilloToolStripMenuItem.Text = "Quita Platillo";
            // 
            // manejoToolStripMenuItem
            // 
            this.manejoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagarCuentaToolStripMenuItem,
            this.cierreDelDiaToolStripMenuItem});
            this.manejoToolStripMenuItem.Name = "manejoToolStripMenuItem";
            this.manejoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.manejoToolStripMenuItem.Text = "Manejo";
            // 
            // pagarCuentaToolStripMenuItem
            // 
            this.pagarCuentaToolStripMenuItem.Name = "pagarCuentaToolStripMenuItem";
            this.pagarCuentaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pagarCuentaToolStripMenuItem.Text = "Pagar Cuenta";
            this.pagarCuentaToolStripMenuItem.Click += new System.EventHandler(this.pagarCuentaToolStripMenuItem_Click);
            // 
            // cierreDelDiaToolStripMenuItem
            // 
            this.cierreDelDiaToolStripMenuItem.Name = "cierreDelDiaToolStripMenuItem";
            this.cierreDelDiaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cierreDelDiaToolStripMenuItem.Text = "Cierre del Dia";
            this.cierreDelDiaToolStripMenuItem.Click += new System.EventHandler(this.cierreDelDiaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.salirToolStripMenuItem.Text = "Ayuda";
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::WindowsFormsProyectoRestaurante.Properties.Resources.plugin_restaurante;
            this.pbMenu.Location = new System.Drawing.Point(0, 27);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(491, 307);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(491, 332);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Aplicacion De Restaurante";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platillosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AsignartoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePlatillosPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaPlatilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitaPlatilloToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbMenu;
    }
}

