using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    public class ListPlatillos
    {
        private List<Platillo> ListPlatillo;


        public ListPlatillos()
        {
            ListPlatillo = new List<Platillo>();
        }

        public void AgregaPlatillo(string desc, double importe, int tiempo)
        {
            Platillo platillo = new Platillo(desc, importe, tiempo);
            ListPlatillo.Add(platillo);
        }
        public string[] ReportePlatillos()
        {
            string[] cadena = new string[ListPlatillo.Count];
            for (int i = 0; i < ListPlatillo.Count; i++)
            {
                cadena[i] = "CLAVE: " + ListPlatillo[i].pClave + ", DESCRIPCION: " + ListPlatillo[i].pDesc + ", IMPORTE: " + ListPlatillo[i].pImporte + ", TIEMPO DE PREPARACION: " + ListPlatillo[i].pTiempo;
            }
            return cadena;
        }
        //nuevo
        public string[] arregloClave()
        {
            string[] cadena = new string[ListPlatillo.Count];
            int pos = 0;
            foreach (Platillo item in ListPlatillo)
            {
                cadena[pos] = item.pClave.ToString();
                pos++;
            }
            return cadena;
        }
        public string[] arregloDescripcion()
        {
            string[] cadena = new string[ListPlatillo.Count];
            int pos = 0;
            foreach (Platillo item in ListPlatillo)
            {
                cadena[pos] = item.pDesc;
                pos++;
            }
            return cadena;
        }
        public string[] arregloImporte()
        {
            string[] cadena = new string[ListPlatillo.Count];
            int pos = 0;
            foreach (Platillo item in ListPlatillo)
            {
                cadena[pos] = item.pImporte.ToString();
                pos++;
            }
            return cadena;
        }
        public string[] arregloTiempo()
        {
            string[] cadena = new string[ListPlatillo.Count];
            int pos = 0;
            foreach (Platillo item in ListPlatillo)
            {
                cadena[pos] = item.pTiempo.ToString();
                pos++;
            }
            return cadena;
        }
        //
        public bool ListVacio()
        {
            bool vacio = false;
            if (ListPlatillo.Count() == 0)
            {
                vacio = true;
            }
            return vacio;
        }
        public int NombreAClave(string cadena)
        {
            int clave = -1;
            for (int i = 0; i < ListPlatillo.Count; i++)
            {
                if (ListPlatillo[i].pDesc == cadena)
                {
                    clave = ListPlatillo[i].pClave;
                }
            }
            return clave;
        }
        public bool BuscaPlatillo(int clave)
        {
            bool existe = false;
            foreach (Platillo item in ListPlatillo)
            {
                if (item.pClave == clave)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public double Importe(int clave)
        {
            double importe = 0;
            for (int i = 0; i < ListPlatillo.Count; i++)
            {
                if (ListPlatillo[i].pClave == clave)
                {
                    importe = ListPlatillo[i].pImporte;
                    break;
                }
            }
            return importe;
        }
    }
}
