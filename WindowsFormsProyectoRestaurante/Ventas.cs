using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    class Ventas
    {
        private double importe;
        private int numP;
        private static double total=0;

        public Ventas (int numP,double importe)
        {
            this.numP = numP;
            this.importe = importe;
            total += importe;
        }
        public double pImporte
        {
            get
            {
                return importe;
            }
            set
            {
                importe = value;
            }
        }
        public int pNumP
        {
            get
            {
                return numP;
            }
            set
            {
                numP = value;
            }
        }
        public static double retornaTotal()
        {
            return total;
        }
    }
}
