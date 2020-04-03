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
            if (lPlatillosPedidos.Count != 0)
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
            else
            {
                Agrega(numP, claveP, cant);
            }
        }
        public void QuitarPlatillo(int numP, int claveP)
        {
            if (lPlatillosPedidos.Count != 0)
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
        }
        public int CalcularNumPlatillos(int numPe)
        {
            int cont = 0;
            for (int i = 0; i < lPlatillosPedidos.Count; i++)
            {
                if (lPlatillosPedidos.ElementAt(i).pNumP.Equals(numPe))
                {
                      cont+=lPlatillosPedidos.ElementAt(i).pCantidad;
                }
            }
            return cont;
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
        public int[] RetornaNumPedidos()
        {
            int[] ArreglonumP = new int[lPlatillosPedidos.Count];
            int pos= 0;
            foreach(PlatilloPedido item in lPlatillosPedidos)
            {
                if(item!=null)
                {
                    ArreglonumP[pos] = item.pNumP;
                    pos++;
                }
            }
            return ArreglonumP;
        }
        public int[] RetornaClavesP()
        {
            int[] ArregloClavesP = new int[lPlatillosPedidos.Count];
            int pos = 0;
            foreach (PlatilloPedido item in lPlatillosPedidos)
            {
                if (item != null)
                {
                    ArregloClavesP[pos] = item.pClaveP;
                    pos++;
                }
            }
            return ArregloClavesP;
        }
        public int[] RetornaCant()
        {
            int[] ArregloCantidad = new int[lPlatillosPedidos.Count];
            int pos = 0;
            foreach (PlatilloPedido item in lPlatillosPedidos)
            {
                if (item != null)
                {
                    ArregloCantidad[pos] = item.pCantidad;
                    pos++;
                }
            }
            return ArregloCantidad;
        }
        public bool ListVacio()
        {
            bool vacio = false;
            if (lPlatillosPedidos.Count() == 0)
            {
                vacio = true;
            }
            return vacio;
        }
        public bool numPExiste(int numP)
        {
            bool existe = false;
            foreach(PlatilloPedido item in lPlatillosPedidos)
            {
                if (item != null)
                {
                    if (item.pNumP.Equals(numP))
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }
        
        public string[] RegresaPlatilloDescripcion(int numP)
        {
            int numPlatillos = this.CalcularNumPlatillos(numP);
            int[] claves = this.RetornaClavesP();
            string[] cadena = new string[numPlatillos];
            int pos = 0;

            string desc = "";
            int clavePla = 0, cant = 0;

                for (int j = 0; j < lPlatillosPedidos.Count; j++)
                {
                    clavePla = lPlatillosPedidos.ElementAt(j).pClaveP;
                    cant = lPlatillosPedidos.ElementAt(j).pCantidad;
                    for (int k = 0; k < claves.Length; k++)
                    {  
                        if (clavePla == claves[k])
                        {
                            desc = lPlatillos.RegresaDescripcion(claves[k]);
                            for (int l = 0; l < cant; l++)
                            {
                                cadena[pos] = desc;
                                pos++;
                            }
                            break;
                        }
                    }
                }
            return cadena;
        }
        public string[] RegresaPlatilloImporte(int numP)
        {
            int numPlatillos = this.CalcularNumPlatillos(numP);
            int[] claves = this.RetornaClavesP();
            string[] cadena = new string[numPlatillos];
            int pos = 0;

            double importe = 0;
            int clavePla = 0, cant = 0;

            for (int j = 0; j < lPlatillosPedidos.Count; j++)
            {
                clavePla = lPlatillosPedidos.ElementAt(j).pClaveP;
                cant = lPlatillosPedidos.ElementAt(j).pCantidad;
                for (int k = 0; k < claves.Length; k++)
                {
                    if (clavePla == claves[k])
                    {
                        importe = lPlatillos.RegresaImporte(claves[k]);
                        for (int l = 0; l < cant; l++)
                        {
                            cadena[pos] = importe.ToString();
                            pos++;
                        }
                        break;
                    }
                }
            }
            return cadena;
        }
        public string[] RegresaPlatilloTiempo(int numP)
        {
            int numPlatillos = this.CalcularNumPlatillos(numP);
            int[] claves = this.RetornaClavesP();
            string[] cadena = new string[numPlatillos];
            int pos = 0;

            int clavePla = 0, cant = 0, tiempo = 0;

            for (int j = 0; j < lPlatillosPedidos.Count; j++)
            {
                clavePla = lPlatillosPedidos.ElementAt(j).pClaveP;
                cant = lPlatillosPedidos.ElementAt(j).pCantidad;
                for (int k = 0; k < claves.Length; k++)
                {
                    if (clavePla == claves[k])
                    {
                        tiempo = lPlatillos.RegresaTiempo(claves[k]);
                        for (int l = 0; l < cant; l++)
                        {
                            cadena[pos] = tiempo.ToString();
                            pos++;
                        }
                        break;
                    }
                }
            }
            return cadena;
        }
        public string[] RegresaPlatilloClaves(int numP)
        {
            int numPlatillos = this.CalcularNumPlatillos(numP);
            int[] claves = this.RetornaClavesP();
            string[] cadena = new string[numPlatillos];
            int pos = 0;

            int clavePla = 0, cant = 0;

            for (int j = 0; j < lPlatillosPedidos.Count; j++)
            {
                clavePla = lPlatillosPedidos.ElementAt(j).pClaveP;
                cant = lPlatillosPedidos.ElementAt(j).pCantidad;
                for (int k = 0; k < claves.Length; k++)
                {
                    if (clavePla == claves[k])
                    {
                        for (int l = 0; l < cant; l++)
                        {
                            cadena[pos] = clavePla.ToString();
                            pos++;
                        }
                        break;
                    }
                }
            }
            return cadena;
        }
    }
}
