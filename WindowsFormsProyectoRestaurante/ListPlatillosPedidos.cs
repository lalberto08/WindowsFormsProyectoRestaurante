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
        public void QuitarPlatillo(int numP, int claveP)
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
    }
}
