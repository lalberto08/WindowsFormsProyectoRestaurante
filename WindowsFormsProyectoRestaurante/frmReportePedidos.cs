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

        private void frmReportePedidos_Load(object sender, EventArgs e)
        {
            string[] numPe = dPedidos.arregloNumPedidos();
            string[] numMesa = dPedidos.arregloNumMesa();
            string[] numBebidas = dPedidos.arregloNumBebidas();
            string[] numPla = dPedidos.arregloNumPlatillos();
            for (int i = 0; i < numPe.Length; i++)
            {
                dgvPedidos.Rows.Add(numPe[i], numMesa[i], numBebidas[i], numPla[i]);
            }
        }
    }
}
