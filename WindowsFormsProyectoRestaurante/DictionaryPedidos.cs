﻿using System;
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
        public void AgregaPedido(int numPe, int numM, int numbe)
        {
            Pedido p = new Pedido(numM, numbe);
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
        public int RegresaNumMesa(int numPed)
        {
            int numPedido = 0;
            Pedido p;
            int numM = 0;

            for (int i = 0; i < DicPedidos.Count; i++)
            {
                KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                numPedido = dato.Key;
                p = dato.Value;
                if (numPedido == numPed)
                {
                    numM = p.pNumMesa;
                }
            }
            return numM;
        }
        public int RegresaNumBebibas(int numPed)
        {
            int numPedido = 0;
            Pedido p;
            int numB = 0;

            for (int i = 0; i < DicPedidos.Count; i++)
            {
                KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                numPedido = dato.Key;
                p = dato.Value;
                if (numPedido == numPed)
                {
                    numB = p.pnumBebidas;
                }
            }
            return numB;
        }
        public int RegresaNumPla(int numPed)
        {
            int numPedido = 0;
            Pedido p;
            int numPla = 0;
            
            for (int i = 0; i < DicPedidos.Count; i++)
            {
                KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                numPedido = dato.Key;
                p = dato.Value;
                if (numPedido == numPed)
                {
                    numPla = p.pNumPlatillos;
                }
            }
            return numPla;
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
        public bool BuscaPedidoDeMESA(int numM)
        {
            bool existe = false;
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numMesa = item.Value.pNumMesa;
                if (numM.Equals(numMesa))
                {
                    existe = true;
                }
            }
            return existe;
        }
        public void ActualizaPedido (int numPed)
        {
            int numP = 0;
            Pedido p;
            int cantidad = 0;
            for (int i = 0; i < DicPedidos.Count; i++)
            {
                KeyValuePair<int, Pedido> dato = DicPedidos.ElementAt(i);
                numP = dato.Key;
                p = dato.Value;
                if (numP == numPed)
                {
                    cantidad = lp.CalcularNumPlatillos(numP);
                    p.pNumPlatillos = cantidad;
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
        public double ImportePlatillos(int numPe)
        {
            double importe = 0;
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                if (numP == numPe)
                {
                    importe = lp.ImportePlatillos(numP);
                }
            }
            return importe;
        }
        public double ImporteTotal(int numPe, bool descuento)
        {
            double importeT = 0;
            double desc = 0;
            foreach (KeyValuePair<int, Pedido> item in DicPedidos)
            {
                int numP = item.Key;
                Pedido p = item.Value;
                if (numP == numPe)
                {
                    importeT = this.ImporteBebidas(numPe) + this.ImportePlatillos(numPe);
                    if (descuento)
                    {
                        desc = importeT * .10;
                        importeT -= desc;
                    }
                }
            }
            return importeT;
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
