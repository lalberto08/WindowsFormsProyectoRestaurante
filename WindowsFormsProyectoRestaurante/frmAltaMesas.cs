using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProyectoRestaurante
{
    public partial class frmAltaMesas : Form
    {
        AdministraMesa admMesas;
        public frmAltaMesas(AdministraMesa aMesas)
        {
            InitializeComponent();
            admMesas = aMesas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
