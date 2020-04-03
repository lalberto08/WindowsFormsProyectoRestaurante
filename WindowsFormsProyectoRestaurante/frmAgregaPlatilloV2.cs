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
    public partial class frmAgregaPlatilloV2 : Form
    {
        ListPlatillos listPlatillos;
        ListPlatillosPedidos lPLaPedidos;
        DictionaryPedidos dPedidos;
        AdministraMesa admMesa;
        int numPe, numMesa, op=1;
        public frmAgregaPlatilloV2(ListPlatillos lPlatillos, DictionaryPedidos dP, ListPlatillosPedidos lPlaPe, AdministraMesa aM)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
            lPLaPedidos = lPlaPe;
            dPedidos = dP;
            admMesa = aM;

        }
        public frmAgregaPlatilloV2(ListPlatillos lPlatillos, DictionaryPedidos dP, ListPlatillosPedidos lPlaPe, AdministraMesa aM, int numP, int numM, int op2)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
            lPLaPedidos = lPlaPe;
            dPedidos = dP;
            admMesa = aM;
            numPe = numP;
            numMesa = numM;
            op = op2;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {   
            DialogResult result = MessageBox.Show("¿Estas Seguro De Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            dtgvPlatillo.Rows.Clear();
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int clavePla = Convert.ToInt32(dtgvPlatillo.CurrentRow.Cells[0].Value);
            lPLaPedidos.QuitarPlatillo(numPe, clavePla);
            dPedidos.ActualizaPedido(numPe);

            dtgvPlatillo.Rows.Clear();
            string[] Aclave = lPLaPedidos.RegresaPlatilloClaves(numPe);
            string[] Adesc = lPLaPedidos.RegresaPlatilloDescripcion(numPe);
            string[] Aimporte = lPLaPedidos.RegresaPlatilloImporte(numPe);
            string[] Atiempo = lPLaPedidos.RegresaPlatilloTiempo(numPe);
            for (int i = 0; i < Aclave.Length; i++)
            {
                dtgvPlatillo.Rows.Add(Aclave[i], Adesc[i], Aimporte[i], Atiempo[i]);
            }
        }

        private void cmbNumPe_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvPlatillo.Rows.Clear();
            numPe = Convert.ToInt32(cmbNumPe.SelectedItem.ToString());
            numMesa = dPedidos.PedidoMesa(numPe);
            string nombreC = admMesa.RegresaNombreCliente(numMesa);
            lblNombre.Text = nombreC;

            string[] Aclave = lPLaPedidos.RegresaPlatilloClaves(numPe);
            string[] Adesc = lPLaPedidos.RegresaPlatilloDescripcion(numPe);
            string[] Aimporte = lPLaPedidos.RegresaPlatilloImporte(numPe);
            string[] Atiempo = lPLaPedidos.RegresaPlatilloTiempo(numPe);
            for (int i = 0; i < Aclave.Length; i++)
            {
                dtgvPlatillo.Rows.Add(Aclave[i], Adesc[i], Aimporte[i], Atiempo[i]);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(numUpCantidad.Value.ToString());
            string desc = cmbDescripcion.SelectedItem.ToString();
            int clavePla = listPlatillos.NombreAClave(desc);
            double importe = listPlatillos.RegresaImporte(clavePla);
            int tiempo = listPlatillos.RegresaTiempo(clavePla);
            lPLaPedidos.AgregarPlatillo(numPe, clavePla, cant);
            dPedidos.ActualizaPedido(numPe);
            //agrega al grid
            dtgvPlatillo.Rows.Clear();
            string[] Aclave = lPLaPedidos.RegresaPlatilloClaves(numPe);
            string[] Adesc = lPLaPedidos.RegresaPlatilloDescripcion(numPe);
            string[] Aimporte = lPLaPedidos.RegresaPlatilloImporte(numPe);
            string[] Atiempo = lPLaPedidos.RegresaPlatilloTiempo(numPe);
            for (int i = 0; i < Aclave.Length; i++)
            {
                dtgvPlatillo.Rows.Add(Aclave[i], Adesc[i], Aimporte[i], Atiempo[i]);
            }
        }

        private void frmAgregaPlatilloV2_Load(object sender, EventArgs e)
        {
            string[] numPedidos = dPedidos.arregloNumPedidos();
            for (int i = 0; i < numPedidos.Length; i++)
            {
                cmbNumPe.Items.Add(numPedidos[i]);
            }
            string[] descripcion = listPlatillos.arregloDescripcion();
            for (int i = 0; i < descripcion.Length; i++)
            {
                cmbDescripcion.Items.Add(descripcion[i]);
            }

            if (op != 1)
            {
                cmbNumPe.Enabled = false;
                cmbNumPe.Text = numPe.ToString();
                string nombreC = admMesa.RegresaNombreCliente(numMesa);
                lblNombre.Text = nombreC;

                string[] Aclave = lPLaPedidos.RegresaPlatilloClaves(numPe);
                string[] Adesc = lPLaPedidos.RegresaPlatilloDescripcion(numPe);
                string[] Aimporte = lPLaPedidos.RegresaPlatilloImporte(numPe);
                string[] Atiempo = lPLaPedidos.RegresaPlatilloTiempo(numPe);
                for (int i = 0; i < Aclave.Length; i++)
                {
                    dtgvPlatillo.Rows.Add(Aclave[i], Adesc[i], Aimporte[i], Atiempo[i]);
                }
            }

        }
    }
}
