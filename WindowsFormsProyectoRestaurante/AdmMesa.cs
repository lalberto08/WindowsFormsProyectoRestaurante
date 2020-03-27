using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    public class AdministraMesa
    {
        private Mesa[] aMesas;
        private int contMesas = 0;

        public AdministraMesa()
        {
            aMesas = new Mesa[10];
        }

        public bool AgregaMesas(int numMesa, string desc, int numPersonas)
        {
            bool agrega = false;
            Mesa mesa = new Mesa(numMesa, desc, numPersonas);
            if (contMesas <= 9)
            {
                aMesas[contMesas] = mesa;
                contMesas++;
                agrega = true;
            }
            return agrega;
        }

        public void AsignaMesa(int posMesa, string nombreCliente)
        {
            aMesas[posMesa].pNombreCliente = nombreCliente;
            aMesas[posMesa].pEstatus = false;
        }
        public void LiberarMesa(int posMesa)
        {
            aMesas[posMesa].pNombreCliente = null;
            aMesas[posMesa].pEstatus = true;
        }

        public string[] ReporteMesas()
        {
            string[] cadena = new string[aMesas.Length];
            int pos = 0;
            string estatus = "OCUPADA";
            string cliente = "NO HAY CLIENTE ASIGNADO";
            foreach (Mesa item in aMesas)
            {
                if (item != null)
                {
                    if (item.pEstatus == true)
                    {
                        estatus = "DESOCUPADA";
                    }
                    if (item.pNombreCliente != null)
                    {
                        cliente = item.pNombreCliente;
                    }
                    cadena[pos] = "NUMERO DE MESA: " + item.pNumMesa + ", DESCRIPCION: " + item.pDescripcion + ", NUMERO DE PERSONAS: " + item.pNumPersonas + ", ESTATUS: " + estatus + ", CLIENTE: " + cliente;
                    pos++;
                }
            }
            return cadena;
        }
        public string[] ReporteMesaOcupadas()
        {
            string[] cadena = new string[aMesas.Length];
            int pos = 0;
            string estatus = "OCUPADA";
            foreach (Mesa item in aMesas)
            {
                if (item != null)
                {
                    if (item.pEstatus == false)
                    {
                        cadena[pos] = "MESA:" + item.pNumMesa + " " + "ESTATUS: " + estatus;
                        pos++;
                    }

                }
            }
            return cadena;
        }
        public string[] ReporteMesaDesocupadas()
        {
            string[] cadena = new string[aMesas.Length];
            int pos = 0;
            string estatus = "DESOCUPADA";
            foreach (Mesa item in aMesas)
            {
                if (item != null)
                {
                    if (item.pEstatus == true)
                    {
                        cadena[pos] = "MESA:" + item.pNumMesa + " " + "ESTATUS: " + estatus;
                        pos++;
                    }

                }
            }
            return cadena;
        }
        public int BuscaMesa(int numMesa)
        {
            int pos = -1;
            for (int i = 0; i < contMesas; i++)
            {
                if (aMesas[i].pNumMesa == numMesa)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public bool ArregloVacio()
        {
            bool vacio = false;
            if (aMesas[0] == null)
            {
                vacio = true;
            }
            return vacio;
        }
        public bool MesaDisponible(int posMesa)
        {
            bool disponibilidad = true;
            if (aMesas[posMesa].pEstatus == false)
            {
                disponibilidad = false;
            }
            return disponibilidad;
        }
    }
}
