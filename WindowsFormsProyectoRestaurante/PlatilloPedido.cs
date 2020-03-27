using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    class PlatilloPedido
    {
        private int numPedido, cantidad;
        private int clavePlatillo;

        public PlatilloPedido(int numP, int claveP, int cant)
        {
            numPedido = numP;
            clavePlatillo = claveP;
            cantidad = cant;
        }

        public int pNumP
        {
            get
            {
                return numPedido;
            }
        }
        public int pClaveP
        {
            get
            {
                return clavePlatillo;
            }
        }
        public int pCantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
    }
}
