using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLista
{
    class LCDNodo
    {
        private string nombre;
        private int edad;
        private LCDNodo siguiente;
        private LCDNodo atras;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public LCDNodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public LCDNodo Atras
        {
            get { return atras; }
            set { atras = value; }
        }
    }
}
