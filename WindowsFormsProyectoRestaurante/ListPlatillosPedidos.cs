using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    public class ListPlatillosPedidos
    {
        private List<PlatilloPedido> lPlatillosPedidos;
        private ListPlatillos lPlatillos;

        public ListPlatillosPedidos(ListPlatillos lpla)
        {
            lPlatillosPedidos = new List<PlatilloPedido>();
            lPlatillos = lpla;
        }

        public void Agrega(int numP, int claveP, int cant)
        {
            PlatilloPedido pp = new PlatilloPedido(numP, claveP, cant);
            lPlatillosPedidos.Add(pp);
        }
        public void AgregarPlatillo(int numP, int claveP, int cant)
        {
            if (lPlatillosPedidos.Count != 0)
            {
                for (int i = 0; i < lPlatillosPedidos.Count; i++)
                {
                    if (lPlatillosPedidos.ElementAt(i).pNumP.Equals(numP) & lPlatillosPedidos.ElementAt(i).pClaveP.Equals(claveP))
                    {
                        lPlatillosPedidos.ElementAt(i).pCantidad += cant;
                        break;
                    }
                    if (lPlatillosPedidos.ElementAt(i).pNumP.Equals(numP) & !lPlatillosPedidos.ElementAt(i).pClaveP.Equals(claveP))
                    {
                        Agrega(numP, claveP, cant);
                        break;
                    }
                }
            }
            else
            {
                Agrega(numP, claveP, cant);
            }
        }
        public void QuitarPlatillo(int numP, int claveP)
        {
            if (lPlatillosPedidos.Count != 0)
            {
                for (int i = 0; i < lPlatillosPedidos.Count; i++)
                {
                    if (lPlatillosPedidos.ElementAt(i).pNumP.Equals(numP) & lPlatillosPedidos.ElementAt(i).pClaveP.Equals(claveP))
                        if (lPlatillosPedidos.ElementAt(i).pCantidad == 1)
                        {
                            lPlatillosPedidos.RemoveAt(i);
                        }
                        else
                        {
                            lPlatillosPedidos.ElementAt(i).pCantidad -= 1;
                        }
                }
            }
        }
        public int CalcularNumPlatillos(int numPe)
        {
            int clave = 0;
            int cont = 0;
            for (int i = 0; i < lPlatillosPedidos.Count; i++)
            {
                if (lPlatillosPedidos.ElementAt(i).pNumP.Equals(numPe))
                {
                      cont+=lPlatillosPedidos.ElementAt(i).pCantidad;
                }
            }
            return cont;
        }
        public double Importe(int numP)
        {
            double total = 0;
            for (int i = 0; i < lPlatillosPedidos.Count; i++)
            {
                if (lPlatillosPedidos.ElementAt(i).pNumP == numP)
                {
                    int clave = lPlatillosPedidos.ElementAt(i).pClaveP;
                    double importe = lPlatillos.Importe(clave);
                    total += lPlatillosPedidos.ElementAt(i).pCantidad * importe;
                }
            }
            return total;
        }

        public string[] ReportePlatillos()
        {
            string[] cadena = new string[lPlatillosPedidos.Count];
            for (int i = 0; i < lPlatillosPedidos.Count; i++)
            {
                cadena[i] = "NUMERO DE PEDIDO: " + lPlatillosPedidos[i].pNumP + ", CLAVE PLATILLO: " + lPlatillosPedidos[i].pClaveP + ", CANTIDAD: " + lPlatillosPedidos[i].pCantidad;
            }
            return cadena;
        }
        public void BorrarPlatillos(int numP)
        {
            for (int i = 0; i < lPlatillosPedidos.Count; i++)
            {
                if (lPlatillosPedidos.ElementAt(i).pNumP.Equals(numP))
                {
                    lPlatillosPedidos.RemoveAt(i);
                }
            }
        }
        public int[] RetornaNumPedidos()
        {
            int[] ArreglonumP = new int[lPlatillosPedidos.Count];
            int pos= 0;
            foreach(PlatilloPedido item in lPlatillosPedidos)
            {
                if(item!=null)
                {
                    ArreglonumP[pos] = item.pNumP;
                    pos++;
                }
            }
            return ArreglonumP;
        }
        public int[] RetornaClvsP()
        {
            int[] ArregloClavesP = new int[lPlatillosPedidos.Count];
            int pos = 0;
            foreach (PlatilloPedido item in lPlatillosPedidos)
            {
                if (item != null)
                {
                    ArregloClavesP[pos] = item.pClaveP;
                    pos++;
                }
            }
            return ArregloClavesP;
        }
        public int[] RetornaCant()
        {
            int[] ArregloCantidad = new int[lPlatillosPedidos.Count];
            int pos = 0;
            foreach (PlatilloPedido item in lPlatillosPedidos)
            {
                if (item != null)
                {
                    ArregloCantidad[pos] = item.pCantidad;
                    pos++;
                }
            }
            return ArregloCantidad;
        }
        public bool ListVacio()
        {
            bool vacio = false;
            if (lPlatillosPedidos.Count() == 0)
            {
                vacio = true;
            }
            return vacio;
        }
        public bool numPExiste(int numP)
        {
            bool existe = false;
            foreach(PlatilloPedido item in lPlatillosPedidos)
            {
                if (item != null)
                {
                    if (item.pNumP.Equals(numP))
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }
        /*
        public string[] ImprimePlatilloClave(int numP)
        {
            int cant = this.CalcularNumPlatillos(numP);
            string[] arreglo = new string[cant];
            string[] clave = lPlatillos.arregloClave();
            int pos = 0;
            for (int i = 0; i < lPlatillosPedidos.Count; i++)
            {
                for (int j = 0; j < lPlatillos.Tamaño(); j++)
                {
                    if (lPlatillosPedidos.ElementAt(i).pClaveP.Equals(clave[j]))
                    {
                        double importe = lPlatillos.RegresaImporte(clave[j]);
                        string cadena = clave[j];
                        arreglo []
                    }
                }
                
            }
        }
        */
    }
}
