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

        private void frmReportePlatilloPedido_Load(object sender, EventArgs e)
        {
            int[] numPe = lPlaPe.RetornaNumPedidos();
            int[] ClaveP = lPlaPe.RetornaClvsP();
            int[] Cant = lPlaPe.RetornaCant();
            for (int i = 0; i < numPe.Length; i++)
            {
                DataGReportePlaPed.Rows.Add(numPe[i], ClaveP[i],Cant[i]);
            }
        }
    }
}
