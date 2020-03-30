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
    public partial class frmAsignaMesa : Form
    {
        AdministraMesa admMesa;
        public frmAsignaMesa(AdministraMesa admM)
        {
            InitializeComponent();
            admMesa = admM;
        }
        private void frmAsignaMesa_Load(object sender, EventArgs e)
        {
            string[] arreglo = admMesa.NumeroDeMesas();
            for (int i = 0; i < arreglo.Length; i++)
            {
                 cmbNumMesa.Items.Add(arreglo[i]);
            }
        }
        private void cmbNumMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMesas.Rows.Clear();
            int numM = Convert.ToInt32(cmbNumMesa.SelectedItem.ToString());
            string desc = admMesa.RegresaDescripcion(numM);
            string estatus = admMesa.RegresaEstatus(numM);
            string nombreC = admMesa.RegresaNombreCliente(numM);
            int numP = admMesa.RegresaNumPersonas(numM);
            dgvMesas.Rows.Add(numM, nombreC, desc, numP, estatus);
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre())
            {
                int numM = Convert.ToInt32(cmbNumMesa.SelectedItem.ToString());
                string nombreC = txtNombreCliente.Text.ToString();
                int pos = admMesa.BuscaMesa(numM);
                admMesa.AsignaMesa(pos, nombreC);

                MessageBox.Show("Mesa Asignada a "+nombreC,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

                cmbNumMesa.SelectedIndex = -1;
                txtNombreCliente.Text = "";
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsWhiteSpace(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public bool ValidarNombre()
        {
            bool retorno = false;
            if (txtNombreCliente.Text != "")
            {
                retorno = true;
            }
            return retorno;
        }

        private void txtNombreCliente_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                errorpAsignaMesa.SetError(txtNombreCliente, "No puede dejar este espacio en blanco");
            }
            else
            {
                errorpAsignaMesa.SetError(txtNombreCliente, "");
            }
        }

        
    }
}
