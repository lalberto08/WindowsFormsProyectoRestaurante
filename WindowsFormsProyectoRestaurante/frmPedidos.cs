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
        AdministraMesa admMesa;
        public frmPedidos(DictionaryPedidos dP, ListPlatillosPedidos lPlaPe,AdministraMesa aM)
        {
            InitializeComponent();
            dPedidos = dP;
            lPLaPedidos = lPlaPe;
            admMesa = aM;
        }

        private void btnAgregaPlatillo_Click(object sender, EventArgs e)
        {
            frmAgregaPlatilloV2 agrega = new frmAgregaPlatilloV2(dPedidos, lPLaPedidos);
            agrega.ShowDialog();
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            int numPe = Convert.ToInt32(txtNumPe.Text);
            int numM =Convert.ToInt32(cmbNumMesa.SelectedItem);
            int numBe = Convert.ToInt32(numUpBebidas.Value);
        }

        private void cmbNumMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre del Cliente";
            dgvMesas.Rows.Clear();
            int numM = Convert.ToInt32(cmbNumMesa.SelectedItem.ToString());
            string desc = admMesa.RegresaDescripcion(numM);
            string estatus = admMesa.RegresaEstatus(numM);
            string nombreC = admMesa.RegresaNombreCliente(numM);
            int numP = admMesa.RegresaNumPersonas(numM);
            lblNombre.Text = nombreC;
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
    }
}
