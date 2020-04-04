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
        ListPlatillos listPlatillos;
        DictionaryPedidos dPedidos;
        ListPlatillosPedidos lPLaPedidos;
        AdministraMesa admMesa;
        public frmPedidos(ListPlatillos lPlatillos, DictionaryPedidos dP, ListPlatillosPedidos lPlaPe,AdministraMesa aM)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
            dPedidos = dP;
            lPLaPedidos = lPlaPe;
            admMesa = aM;
        }

        private void btnAgregaPlatillo_Click(object sender, EventArgs e)
        {
            bool agregar = true;
            if (ValidarVacio())
            {
                if (ValidarMESA())
                {

                    if (ValidarVacioPedido())
                    {
                        int numPe = Convert.ToInt32(txtNumPe.Text.ToString());
                        if (lPLaPedidos.numPExiste(numPe))
                        {
                            ErrorPPedido.SetError(txtNumPe, "Numero De Pedido Invalido");
                            txtNumPe.Focus();
                            agregar = false;
                        }
                        int numM = Convert.ToInt32(cmbNumMesa.SelectedItem);
                        if (admMesa.RegresaNombreCliente(numM).Equals("NO ASIGNADA"))
                        {
                            MessageBox.Show("MESA SIN ASIGNAR!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //limpiar errorprovider
                            ErrorPPedido.SetError(cmbNumMesa, "");
                            ErrorPPedido.SetError(txtNumPe, "");
                            agregar = false;
                        }
                        if (listPlatillos.ListVacio())
                        {
                            MessageBox.Show("NO HAY PLATILLOS AGREGADOS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            agregar = false;
                        }
                        if (agregar != false)
                        {
                            int numBe = Convert.ToInt32(numUpBebidas.Value);
                            dPedidos.AgregaPedido(numPe, numM, numBe);
                            frmAgregaPlatilloV2 agrega = new frmAgregaPlatilloV2(listPlatillos, dPedidos, lPLaPedidos, admMesa, numPe, numM, 2);
                            agrega.ShowDialog();
                            txtNumPe.Enabled = false;
                            cmbNumMesa.Enabled = false;
                            //limpiar errorprovider
                            ErrorPPedido.SetError(cmbNumMesa, "");
                            ErrorPPedido.SetError(txtNumPe, "");
                        }
                    }
                }
            }
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            bool guardar = true;
            if (ValidarVacio())
            {
              
                if (ValidarVacioPedido())
                 {

                        int numM = Convert.ToInt32(cmbNumMesa.SelectedItem);
                        if (admMesa.RegresaNombreCliente(numM).Equals("NO ASIGNADA"))
                        {
                            MessageBox.Show("MESA SIN ASIGNAR!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //limpiar errorprovider
                            ErrorPPedido.SetError(cmbNumMesa, "");
                            ErrorPPedido.SetError(txtNumPe, "");
                            guardar = false;
                        }
                        //Falta validar que no deje guardar sin antes haber pedido un platillo, hay un error al quitar el platillo
                        int numPe = Convert.ToInt32(txtNumPe.Text);
                        if (lPLaPedidos.numPExiste(numPe) != true)
                        {
                            MessageBox.Show("NO HAY PLATILLOS AGREGADOS!,FAVOR DE AGREGAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            guardar = false;
                        }
                        if (guardar != false)
                        {
                            MessageBox.Show("Pedido Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //limpiar errorprovider
                            ErrorPPedido.SetError(cmbNumMesa, "");
                            ErrorPPedido.SetError(txtNumPe, "");
                            //limpiar al guardar
                            cmbNumMesa.Text = "";
                            txtNombrecliente.Text = "";
                            txtNumPe.Text = "";
                            dgvMesas.Rows.Clear();
                            txtNumPe.Enabled = true;
                            cmbNumMesa.Enabled = true;
                            cmbNumMesa.Focus();
                        }
                 }
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
            txtNombrecliente.Text = nombreC;
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

        private void txtNumPe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public bool ValidarVacio()
        {
            bool retorno = true;
            string Clave = cmbNumMesa.Text;
            if (Clave.Equals(""))
            {
                ErrorPPedido.SetError(cmbNumMesa, "No Se Ha Seleccionado Ningun Numero De Mesa");
                cmbNumMesa.Focus();
                retorno = false;
            }
            return retorno;
        }
        public bool ValidarMESA()
        {
            bool retorno = true;
            int NumM = Convert.ToInt32(cmbNumMesa.SelectedItem.ToString());
            if (dPedidos.BuscaPedidoDeMESA(NumM))
            {
                ErrorPPedido.SetError(cmbNumMesa, "YA SE HA DADO DE ALTA EL PEDIDO DE ESA MESA, SELECCIONE OTRA");
                cmbNumMesa.Focus();
                retorno = false;
            }
            return retorno;
        }
        public bool ValidarVacioPedido()
        {
            bool retorno = true;
            string NumPedido = txtNumPe.Text;
            if (NumPedido.Equals(""))
            {
                ErrorPPedido.SetError(txtNumPe, "No Se Ha Proporcionado El Numero De Pedido");
                txtNumPe.Focus();
                retorno = false;
            }
            return retorno;
        }

        private void cmbNumMesa_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarVacio() == false)
            {
                e.Cancel = true;
            }
        }

        private void txtNumPe_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarVacioPedido() == false)
            {
                e.Cancel = true;
            }
        }

        private void cmbNumMesa_Validated(object sender, EventArgs e)
        {
            ErrorPPedido.SetError(cmbNumMesa, "");
        }
    }
}
