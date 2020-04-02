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
    public partial class frmMenu : Form
    {
        AdministraMesa admMesas;
        ListPlatillos LPlatillos;
        DictionaryPedidos dPedidos;
        ListPlatillosPedidos lPlaPe;
        public frmMenu()
        {
            InitializeComponent();
            admMesas = new AdministraMesa();
            LPlatillos = new ListPlatillos();
            lPlaPe = new ListPlatillosPedidos(LPlatillos);
            dPedidos = new DictionaryPedidos(lPlaPe);
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMesas AltaMesas = new frmAltaMesas(admMesas);
            AltaMesas.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMesas ConsultaMesas = new frmConsultaMesas(admMesas);
            ConsultaMesas.ShowDialog();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPlatillos RegistraPlatillos = new frmPlatillos(LPlatillos);
            RegistraPlatillos.ShowDialog();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPlatillos ConsultaPlatillo = new frmConsultaPlatillos(LPlatillos);
            ConsultaPlatillo.ShowDialog();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPedidos registraPedidos = new frmPedidos(LPlatillos, dPedidos, lPlaPe,admMesas);
            registraPedidos.ShowDialog();
        }

        private void AsignartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignaMesa asigna = new frmAsignaMesa(admMesas);
            asigna.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePedidos reporte = new frmReportePedidos(dPedidos);
            reporte.ShowDialog();
        }

        private void reportePlatillosPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePlatilloPedido reporte = new frmReportePlatilloPedido(lPlaPe);
            reporte.ShowDialog();
        }

        private void pagarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagarCuenta pagar = new frmPagarCuenta();
            pagar.ShowDialog();
        }

        private void cierreDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCierreDia cierre = new frmCierreDia();
            cierre.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMesaIndividual consulta = new frmConsultaMesaIndividual(admMesas);
            consulta.ShowDialog();
        }

        private void agregaPlatilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregaPlatilloV2 agrega = new frmAgregaPlatilloV2(LPlatillos, dPedidos, lPlaPe, admMesas);
            agrega.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
