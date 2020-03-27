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
    public partial class frmPedidos : Form
    {
        DictionaryPedidos dPedidos;
        ListPlatillosPedidos lPLaPedidos;
        public frmPedidos(DictionaryPedidos dP, ListPlatillosPedidos lPlaPe)
        {
            InitializeComponent();
            dPedidos = dP;
            lPLaPedidos = lPlaPe;
        }

        private void btnAgregaPlatillo_Click(object sender, EventArgs e)
        {
            frmAgregaPlatillo agrega = new frmAgregaPlatillo(dPedidos, lPLaPedidos);
            agrega.ShowDialog();
        }
    }
}
