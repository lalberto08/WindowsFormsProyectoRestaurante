using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    public class Platillo
    {
        private string descripcion;
        private double importe;
        private int clavePla, tiempo;
        static int cont = 1000;
        public Platillo(string desc, double imp, int tiemp)
        {
            descripcion = desc;
            importe = imp;
            tiempo = tiemp;
            clavePla = cont;
            cont += 5;
        }

        public int pClave
        {
            get
            {
                return clavePla;
            }
        }
        public string pDesc
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
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
        public int pTiempo
        {
            get
            {
                return tiempo;
            }
            set
            {
                tiempo = value;
            }
        }
        public static int ObtieneClave()
        {
            return cont;
        }
    }
}
