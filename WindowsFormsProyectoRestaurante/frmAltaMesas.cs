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
    public partial class frmAltaMesas : Form
    {
        AdministraMesa admMesas;
        public frmAltaMesas(AdministraMesa aMesas)
        {
            InitializeComponent();
            admMesas = aMesas;
            txtNumMesa.Text = Mesa.RetornaNumMesa().ToString();
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (admMesas.RegresaTamaño() >= 10)
            {
                MessageBox.Show("NUMERO MAXIMO DE MESAS", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ValidarDescripcion())
                {
                    string desc = cmbDescripcion.SelectedItem.ToString();
                    int numPersonas = Convert.ToInt32(numUpNumPer.Value.ToString());

                    admMesas.AgregaMesas(desc, numPersonas);
                    MessageBox.Show("Mesa Agregada Con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (admMesas.RegresaTamaño()<=9)
                    {
                        txtNumMesa.Text = Mesa.RetornaNumMesa().ToString();
                    }
                    //limpia
                    cmbDescripcion.SelectedIndex = -1;
                    numUpNumPer.Value = 1;
                    cmbDescripcion.Focus();
                }
            
             }
            
        }
        public bool ValidarDescripcion()
        {
            bool retorno = false;
            if (cmbDescripcion.SelectedIndex != -1)
            {
                retorno = true;
            }
            return retorno;
        }

        private void cmbDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDescripcion.SelectedIndex == -1)
            {
                ErrorPMesas.SetError(cmbDescripcion, "Descripcion Vacia");
                cmbDescripcion.Focus();
            }
            else
            {
                ErrorPMesas.SetError(cmbDescripcion, "");
            }
        }
    }
}
