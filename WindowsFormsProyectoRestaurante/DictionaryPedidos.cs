using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    public class DictionaryPedidos
    {
        private Dictionary<int, Pedido> DicPedidos;
        private ListPlatillosPedidos lp;

        public DictionaryPedidos(ListPlatillosPedidos lPlaPe)
        {
            DicPedidos = new Dictionary<int, Pedido>();
            lp = lPlaPe;
        }
        public void AgregaPedido(int numPe, int numM, int numbe, int numpla)
        {
            Pedido p = new Pedido(numM, numbe, numpla);
            DicPedidos.Add(numPe, p);
        }
        public string[] ReportePedidos()
        {
            int pos = 0;
            string[] cadena = new string[DicPedidos.Count];
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                string arr = String.Format("NUMERO PEDIDO: {0}, NUMERO DE MESA: {1}, BEBIDAS: {2}, PLATILLOS: {3}",
                    numP, p.pNumMesa, p.pnumBebidas, p.pNumPlatillos);
                cadena[pos] = arr;
                pos++;
            }
            return cadena;
        }
        public string[] arregloNumPedidos()
        {
            int pos = 0;
            string[] cadena = new string[DicPedidos.Count];
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                string arr = numP.ToString();
                cadena[pos] = arr;
                pos++;
            }
            return cadena;
        }
        public string[] arregloNumMesa()
        {
            int pos = 0;
            string[] cadena = new string[DicPedidos.Count];
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                string arr = p.pNumMesa.ToString();
                cadena[pos] = arr;
                pos++;
            }
            return cadena;
        }
        public string[] arregloNumBebidas()
        {
            int pos = 0;
            string[] cadena = new string[DicPedidos.Count];
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                string arr = p.pnumBebidas.ToString();
                cadena[pos] = arr;
                pos++;
            }
            return cadena;
        }
        public string[] arregloNumPlatillos()
        {
            int pos = 0;
            string[] cadena = new string[DicPedidos.Count];
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                string arr = p.pNumPlatillos.ToString();
                cadena[pos] = arr;
                pos++;
            }
            return cadena;
        }
        public bool BuscaPedido(int num)
        {
            bool existe = false;
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                if (numP == num)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public void AgregaPlatillo(int numPed, int cantidad)
        {
            int numP = 0;
            Pedido p;
            for (int i = 0; i < DicPedidos.Count; i++)
            {
                KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                numP = dato.Key;
                p = dato.Value;
                if (numP == numPed)
                {
                    p.pNumPlatillos += cantidad;
                    break;
                }
            }
        }
        public void QuitaPlatillo(int numPed)
        {
            int numP = 0;
            Pedido p;
            for (int i = 0; i < DicPedidos.Count; i++)
            {
                KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                numP = dato.Key;
                p = dato.Value;
                if (numP == numPed)
                {
                    p.pNumPlatillos -= 1;
                    break;
                }
            }
        }
        public double ImporteBebidas(int numPe)
        {
            double importeBe = 0;
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                if (numP == numPe)
                {
                    importeBe = p.pnumBebidas * 23;
                    break;
                }
            }
            return importeBe;
        }
        public string Importe(int numPe)
        {
            string arr = "";
            for (int i = 0; i < DicPedidos.Count; i++)
            {
                KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                int numP = dato.Key;
                Pedido p = dato.Value;
                if (numPe == numP)
                {
                    arr = String.Format("NUMERO PEDIDO: {0}, NUMERO DE MESA: {1}, BEBIDAS: {2}, IMPORTE: {3}, NUM PLATILLOS: {4}, IMPORTE {5}",
                    numP, p.pNumMesa, p.pnumBebidas, ImporteBebidas(numP), p.pNumPlatillos, lp.Importe(numP));
                }
            }
            return arr;
        }
        public bool DicVacio()
        {
            bool vacio = false;
            if (DicPedidos.Count() == 0)
            {
                vacio = true;
            }
            return vacio;
        }
        public void BorrarPedido(int numP)
        {
            for (int i = 0; i < DicPedidos.Count; i++)
            {
                if (DicPedidos.ElementAt(i).Key.Equals(numP))
                {
                    KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                    DicPedidos.Remove(dato.Key);
                }
            }
        }
        public int PedidoMesa(int numP)
        {
            int numM = 0;
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numPe = item.Key;
                Pedido p = item.Value;
                if (numPe == numP)
                {
                    numM = p.pNumMesa;
                    break;
                }
            }
            return numM;
        }
    }
}
