using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProyectoRestaurante
{
    class Mesa
    {
        private int numMesa, numPersonas;
        private string descripcion;
        private bool estatus;
        private string nombreCliente;
        private static int numM=1;

        public Mesa(string desc, int numPersonas)
        {
            numMesa = numM;
            numM++;
            descripcion = desc;
            this.numPersonas = numPersonas;
            estatus = true;
        }
        public int pNumMesa
        {
            get
            {
                return numMesa;
            }
        }
        public int pNumPersonas
        {
            get
            {
                return numPersonas;
            }
            set
            {
                numPersonas = value;
            }
        }
        public string pDescripcion
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
        public bool pEstatus
        {
            get
            {
                return estatus;
            }
            set
            {
                estatus = value;
            }
        }
        public string pNombreCliente
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente = value;
            }
        }
        public static int RetornaNumMesa()
        {
           return numM;
        }
    }
}
