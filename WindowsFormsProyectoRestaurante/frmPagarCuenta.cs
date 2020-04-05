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
    public partial class frmPagarCuenta : Form
    {
        ListPlatillos listPlatillos;
        ListPlatillosPedidos lPLaPedidos;
        DictionaryPedidos dPedidos;
        AdministraMesa admMesa;
        public frmPagarCuenta(ListPlatillos lPlatillos, DictionaryPedidos dP, ListPlatillosPedidos lPlaPe, AdministraMesa aM)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
            lPLaPedidos = lPlaPe;
            admMesa = aM;
            dPedidos = dP;

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

        private void frmPagarCuenta_Load(object sender, EventArgs e)
        {
            string[] numPedidos = dPedidos.arregloNumPedidos();
            for (int i = 0; i < numPedidos.Length; i++)
            {
                cmbNumPe.Items.Add(numPedidos[i]);
            }
        }

        private void cmbNumPe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NumPe = Convert.ToInt32(cmbNumPe.SelectedItem.ToString());
            int numMesa = dPedidos.RegresaNumMesa(NumPe);
            int numBebidas = dPedidos.RegresaNumBebibas(NumPe);
            double importeBebidas = dPedidos.ImporteBebidas(NumPe);
            int platillos = dPedidos.RegresaNumPla(NumPe);
            double importePlatillos = dPedidos.ImportePlatillos(NumPe);

            dgvPagarCuenta.Rows.Add(numMesa,numBebidas,importeBebidas,platillos,importePlatillos);

        }
    }
}
