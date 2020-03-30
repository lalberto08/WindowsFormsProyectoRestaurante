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
    public partial class frmConsultaMesas : Form
    {
        AdministraMesa admMesa;
        public frmConsultaMesas(AdministraMesa aMesa)
        {
            InitializeComponent();
            admMesa = aMesa;
        }

        private void frmConsultaMesas_Load(object sender, EventArgs e)
        {
            string[] numM = admMesa.NumeroDeMesas();
            string[] desc = admMesa.arregloDescripcion();
            string[] estatus = admMesa.arregloEstatus();
            string[] nombreC = admMesa.arregloNombreCliente();
            string[] numP = admMesa.arregloNumPersonas();
            for (int i = 0; i < numM.Length; i++)
            {
                dgvConsultaMesas.Rows.Add(numM[i], nombreC[i], desc[i], numP[i], estatus[i]);
            }
        }
    }
}
