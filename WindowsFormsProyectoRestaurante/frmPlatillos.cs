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
        ListPlatillos listPlatillos;
        public frmPlatillos(ListPlatillos Lpla)
        {
            InitializeComponent();
            listPlatillos = Lpla;
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
            if (ValidarDescripcion())
            {
                if (ValidarImporte())
                {
                    if (ValidarDuplicado())
                    {
                        string ClavePlatillo = txtClavePlatillo.Text;
                        string desc = txtDescripcion.Text;
                        double importe = Convert.ToDouble(txtImportePlatillo.Text);
                        int tiempo = Convert.ToInt32(numUpTiempo.Value);
                        listPlatillos.AgregaPlatillo(desc, importe, tiempo);
                        MessageBox.Show("Platillo Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpiar ErrorProvider
                        ErrorPPlatillos.SetError(txtDescripcion, "");
                        ErrorPPlatillos.SetError(txtImportePlatillo, "");
                        DataGPlatillos.Rows.Clear();
                        string[] Aclave = listPlatillos.arregloClave();
                        string[] Adesc = listPlatillos.arregloDescripcion();
                        string[] Aimporte = listPlatillos.arregloImporte();
                        string[] Atiempo = listPlatillos.arregloTiempo();
                        for (int i = 0; i < Aclave.Length; i++)
                        {
                            DataGPlatillos.Rows.Add(Aclave[i], Adesc[i], Aimporte[i], Atiempo[i]);
                        }
                        //Limpiar Al Registrar
                        txtDescripcion.Text = "";
                        txtImportePlatillo.Text = "0";
                        numUpTiempo.Value = 10;
                        txtClavePlatillo.Text = Platillo.ObtieneClave().ToString();
                        txtDescripcion.Focus();
                    }
                }
                
            }

        }
        public bool ValidarDescripcion()
        {
            bool retorno = true;
            string descripcion = txtDescripcion.Text;
            if (descripcion.Equals(""))
            {
                ErrorPPlatillos.SetError(txtDescripcion, "Descripcion en blanco");
                txtDescripcion.Focus();
                retorno = false;
            }
            return retorno;
        }
        public bool ValidarDuplicado()
        {
            bool duplicado = true;
            string desc = txtDescripcion.Text;
            if (listPlatillos.ValidarPlatilloDesc(desc) != false)
            {
                ErrorPPlatillos.SetError(txtDescripcion, "Nombre De Platillo Repetido");
                txtDescripcion.Focus();
                duplicado = false;
            }
            return duplicado;
        }
        public bool ValidarImporte()
        {
            bool retorno = true;
            int importe = Convert.ToInt32(txtImportePlatillo.Text.ToString());
            if (importe.Equals(0))
            {
                ErrorPPlatillos.SetError(txtImportePlatillo, "IMPORTE INVALIDO");
                txtImportePlatillo.Focus();
                retorno = false;
            }
            return retorno;
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsWhiteSpace(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtImportePlatillo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarDescripcion() == false)
            {
                e.Cancel = true;
            }
        }

        private void txtImportePlatillo_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarImporte() == false)
            {
                e.Cancel = true;
            }
        }

        private void frmPlatillos_Load(object sender, EventArgs e)
        {
            string[] Aclave = listPlatillos.arregloClave();
            string[] Adesc = listPlatillos.arregloDescripcion();
            string[] Aimporte = listPlatillos.arregloImporte();
            string[] Atiempo = listPlatillos.arregloTiempo();
            for (int i = 0; i < Aclave.Length; i++)
            {
                DataGPlatillos.Rows.Add(Aclave[i], Adesc[i], Aimporte[i], Atiempo[i]);
            }
        }
    }
}
