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
    public partial class frmConsultaMesas : Form
    {
        AdministraMesa admMesa;
        public frmConsultaMesas(AdministraMesa aMesa)
        {
            InitializeComponent();
            admMesa = aMesa;
        }

        private void frmConsultaMesas_Load(object sender, EventArgs e)
        {

        }
    }
}
