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
    public partial class frmPlatillos : Form
    {
        ListPlatillos LPlatillos;
        public frmPlatillos(ListPlatillos Lpla)
        {
            InitializeComponent();
            LPlatillos = Lpla;
            txtClavePlatillo.Text = Platillo.ObtieneClave().ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClavePlatillo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string desc = txtDescripcion.Text;
            double importe = Convert.ToDouble(txtImportePlatillo.Text);
            int tiempo =Convert.ToInt32(numUpTiempo.Value);
            LPlatillos.AgregaPlatillo(desc, importe, tiempo);
            MessageBox.Show("Platillo agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
