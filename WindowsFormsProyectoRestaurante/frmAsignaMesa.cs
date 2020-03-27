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
    public partial class frmAsignaMesa : Form
    {
        AdministraMesa admMesa;
        public frmAsignaMesa(AdministraMesa admM)
        {
            InitializeComponent();
            admMesa = admM;
        }
    }
}
