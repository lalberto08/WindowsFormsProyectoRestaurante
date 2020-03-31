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
        ListPlatillos listPlatillos;
        DictionaryPedidos dPedidos;
        ListPlatillosPedidos lPLaPedidos;
        AdministraMesa admMesa;
        public frmPedidos(ListPlatillos lPlatillos, DictionaryPedidos dP, ListPlatillosPedidos lPlaPe,AdministraMesa aM)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
            dPedidos = dP;
            lPLaPedidos = lPlaPe;
            admMesa = aM;
        }

        private void btnAgregaPlatillo_Click(object sender, EventArgs e)
        {
            int numPe = Convert.ToInt32(txtNumPe.Text);
            int numM = Convert.ToInt32(cmbNumMesa.SelectedItem);
            frmAgregaPlatilloV2 agrega = new frmAgregaPlatilloV2(listPlatillos, dPedidos, lPLaPedidos,admMesa,numPe, numM,2);
            agrega.ShowDialog();
            txtNumPe.Enabled = false;
            cmbNumMesa.Enabled = false;
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            int numPe = Convert.ToInt32(txtNumPe.Text);
            int numM =Convert.ToInt32(cmbNumMesa.SelectedItem);
            int numBe = Convert.ToInt32(numUpBebidas.Value);
            int numPla = lPLaPedidos.CalcularNumPlatillos(numPe);
            dPedidos.AgregaPedido(numPe,numM,numBe,numPla);
            MessageBox.Show("Pedido Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbNumMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMesas.Rows.Clear();
            int numM = Convert.ToInt32(cmbNumMesa.SelectedItem.ToString());
            string desc = admMesa.RegresaDescripcion(numM);
            string estatus = admMesa.RegresaEstatus(numM);
            string nombreC = admMesa.RegresaNombreCliente(numM);
            int numP = admMesa.RegresaNumPersonas(numM);
            txtNombrecliente.Text = nombreC;
            dgvMesas.Rows.Add(numM, nombreC, desc, numP, estatus);
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            string[] arreglo = admMesa.NumeroDeMesas();
            for (int i = 0; i < arreglo.Length; i++)
            {
                cmbNumMesa.Items.Add(arreglo[i]);
            }
        }

        private void txtNumPe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
