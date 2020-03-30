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
    public partial class frmConsultaPlatillos : Form
    {
        ListPlatillos listPlatillos;
        public frmConsultaPlatillos(ListPlatillos lPlatillos)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
        }

        private void frmConsultaPlatillos_Load(object sender, EventArgs e)
        {
            string[] clave = listPlatillos.arregloClave();
            string[] desc = listPlatillos.arregloDescripcion();
            string[] importe = listPlatillos.arregloImporte();
            string[] tiempo = listPlatillos.arregloTiempo();
            for (int i = 0; i < clave.Length; i++)
            {
                dgvConsultaPlatillos.Rows.Add(clave[i], desc[i], importe[i], tiempo[i]);
            }
        }
    }
}
