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
    public partial class frmReportePlatilloPedido : Form
    {
        ListPlatillosPedidos lPlaPe;
        public frmReportePlatilloPedido(ListPlatillosPedidos lpp)
        {
            InitializeComponent();
            lPlaPe = lpp;
        }
    }
}
