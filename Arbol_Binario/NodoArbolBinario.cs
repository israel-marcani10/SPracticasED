using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class NodoArbol
    {
        public string info;
        public NodoArbol EnlaceIzquierdo;
        public NodoArbol EnlaceDerecho;

        public NodoArbol(string info) {
            this.info = info;
            EnlaceDerecho = null;
            EnlaceIzquierdo = null;
        }
    }
}
