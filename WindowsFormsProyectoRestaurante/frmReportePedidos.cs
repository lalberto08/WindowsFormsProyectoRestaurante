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
    public partial class frmReportePedidos : Form
    {
        DictionaryPedidos dPedidos;
        public frmReportePedidos(DictionaryPedidos dP)
        {
            InitializeComponent();
            dPedidos = dP;
        }
    }
}
