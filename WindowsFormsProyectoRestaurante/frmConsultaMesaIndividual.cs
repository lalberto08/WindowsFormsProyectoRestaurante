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
    public partial class frmConsultaMesaIndividual : Form
    {
        AdministraMesa admMesa;
        public frmConsultaMesaIndividual(AdministraMesa admM)
        {
            InitializeComponent();
            admMesa = admM;
        }

        private void frmConsultaMesaIndividual_Load(object sender, EventArgs e)
        {
            string[] arreglo = admMesa.NumeroDeMesas();
            for (int i = 0; i < arreglo.Length; i++)
            {
                cmbNumMesa.Items.Add(arreglo[i]);
            }
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
    }
}
