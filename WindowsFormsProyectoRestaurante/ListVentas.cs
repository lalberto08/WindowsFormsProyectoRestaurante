using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    class ListVentas
    {
        private List<Ventas> lVentas;

        public ListVentas()
        {
            lVentas = new List<Ventas>();
        }
        public void AgregaVenta (int numP, double importe)
        {
            Ventas ven = new Ventas(numP, importe);
            lVentas.Add(ven);
        }
        public double TotalVentas()
        {
            return Ventas.retornaTotal();
        }
    }
}
