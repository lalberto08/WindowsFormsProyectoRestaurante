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
    public partial class frmAgregaPlatillo : Form
    {
        ListPlatillosPedidos lPLaPedidos;
        DictionaryPedidos dPedidos;
        public frmAgregaPlatillo(DictionaryPedidos dP, ListPlatillosPedidos lPlaPe)
        {
            InitializeComponent();
            lPLaPedidos = lPlaPe;
            dPedidos = dP;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
