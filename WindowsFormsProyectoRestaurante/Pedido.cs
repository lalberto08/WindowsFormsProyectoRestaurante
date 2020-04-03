using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    class Pedido
    {
       private int numMesa, numBebidas, numPlatillos;

        public Pedido(int numM, int numbe)
        {
            numMesa = numM;
            numBebidas = numbe;
        }

        public int pNumMesa
        {
            get
            {
                return numMesa;
            }
            set
            {
                numMesa = value;
            }
        }
        public int pnumBebidas
        {
            get
            {
                return numBebidas;
            }
            set
            {
                numBebidas = value;
            }
        }

        public int pNumPlatillos
        {
            get
            {
                return numPlatillos;
            }
            set
            {
                numPlatillos = value;
            }
        }
    }
}
