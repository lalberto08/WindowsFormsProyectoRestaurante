using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    //Ejemplo de edicion
    public class AdministraMesa
    {
        private Mesa[] aMesas;
        private int contMesas = 0;

        public AdministraMesa()
        {
            aMesas = new Mesa[10];
        }

        public bool AgregaMesas(string desc, int numPersonas)
        {
            bool agrega = false;
            Mesa mesa = new Mesa(desc, numPersonas);
            if (contMesas <= 9)
            {
                aMesas[contMesas] = mesa;
                contMesas++;
                agrega = true;
            }
            return agrega;
        }
        public int RegresaTamaño()
        {
            int tamaño = 0;
            foreach(Mesa item in aMesas)
            {
                if(item!=null)
                {
                    tamaño++;
                }
            }
            return tamaño;
        }

        public void AsignaMesa(int posMesa, string nombreCliente)
        {
            aMesas[posMesa].pNombreCliente = nombreCliente;
            aMesas[posMesa].pEstatus = false;
        }
        //nuevo
        public string RegresaDescripcion(int numM)
        {
            string desc="";
            for (int i = 0; i < contMesas; i++)
            {
                if (aMesas[i].pNumMesa.Equals(numM))
                {
                    desc=aMesas[i].pDescripcion;
                }
            }
            return desc;
        }
        public int RegresaNumPersonas(int numM)
        {
            int num = 0;
            for (int i = 0; i < contMesas; i++)
            {
                if (aMesas[i].pNumMesa.Equals(numM))
                {
                    num = aMesas[i].pNumPersonas;
                }
            }
            return num;
        }
        public string RegresaEstatus(int numM)
        {
            string estatus = "DESOCUPADA";
            for (int i = 0; i < contMesas; i++)
            {
                if (aMesas[i].pNumMesa.Equals(numM))
                {
                    bool estado = aMesas[i].pEstatus;
                    if (estado==false) 
                    {
                        estatus = "OCUPADA";
                    }
                }
            }
            return estatus;
        }
        public string RegresaNombreCliente(int numM)
        {
            string nombre = "NO ASIGNADA";
            for (int i = 0; i < contMesas; i++)
            {
                if (aMesas[i].pNumMesa.Equals(numM))
                {
                    string nom = aMesas[i].pNombreCliente;
                    if (nom!=null)
                    {
                        nombre = nom;
                    }
                }
            }
            return nombre;
        }
        public string[] NumeroDeMesas()
        {
            string[] arreglo = new string[contMesas];
            for (int i = 0; i < contMesas; i++)
            {
                arreglo[i] = aMesas[i].pNumMesa.ToString();
            }
            return arreglo;
        }
        public string[] arregloDescripcion()
        {
            string[] arreglo = new string[contMesas];
            for (int i = 0; i < contMesas; i++)
            {
                arreglo[i] = aMesas[i].pDescripcion;
            }
            return arreglo;
        }
        public string[] arregloNumPersonas()
        {
            string[] arreglo = new string[contMesas];
            for (int i = 0; i < contMesas; i++)
            {
                arreglo[i] = aMesas[i].pNumPersonas.ToString();
            }
            return arreglo;
        }
        public string[] arregloEstatus()
        {
            string estatus;
            bool estado;
            string[] arreglo = new string[contMesas];
            for (int i = 0; i < contMesas; i++)
            {
                estatus = "DESOCUPADA";
                estado = aMesas[i].pEstatus;
                if (estado == false)
                {
                    estatus = "OCUPADA";
                }
                arreglo[i] = estatus;
            }
            return arreglo;
        }
        public string[] arregloNombreCliente()
        {
            string nombre;
            string[] arreglo = new string[contMesas];
            for (int i = 0; i < contMesas; i++)
            {
                nombre = "NO ASIGNADA";
                string nom = aMesas[i].pNombreCliente;
                if (nom != null)
                {
                    nombre = nom;
                }
                arreglo[i] = nombre;
            }
            return arreglo;
        }
        //
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
