using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class ArbolBinario
    {
        public NodoArbol raiz;

        public ArbolBinario() {
            raiz = null;
        }

        public Boolean vacio()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void InsertarRaiz(NodoArbol a)
        {
            if (vacio())
                raiz = a;
        }

        public void InsertarIzq(NodoArbol a, NodoArbol padre)
        {
            NodoArbol aux = buscar(padre, padre.info);
            if (aux.EnlaceIzquierdo == null)
                aux.EnlaceIzquierdo = a;
            else
                System.Windows.Forms.MessageBox.Show("Error: enlace lleno");
        }

        public void InsertarDer(NodoArbol a, NodoArbol padre)
        {
            NodoArbol aux = buscar(padre, padre.info);
            if (aux.EnlaceDerecho == null)
                aux.EnlaceDerecho = a;
            else
                System.Windows.Forms.MessageBox.Show("Error: enlace lleno");
        }

        public void EliminarDerecho(NodoArbol padre)
        {
            NodoArbol aux;
            aux = padre.EnlaceDerecho;
            padre.EnlaceDerecho = null;
            System.Windows.Forms.MessageBox.Show("El elemento eliminado es =" + aux.info);
        }

        public void EliminarIzquierdo(NodoArbol padre)
        {
            NodoArbol aux;
            aux = padre.EnlaceIzquierdo;
            padre.EnlaceIzquierdo = null;
            System.Windows.Forms.MessageBox.Show("El elemento eliminado es =" + aux.info);
        }

        private string PreOrden(NodoArbol r)
        {
            string result = "";
            if (r != null)
            {
                result += r.info + "  ";
                result += PreOrden(r.EnlaceIzquierdo);
                result += PreOrden(r.EnlaceDerecho);
            }
            return result;
        }

        public string PreOrden1()
        {
            return PreOrden(raiz);
        }

        public string EntreOrden(NodoArbol r)
        {
            string result = "";
            if (r != null)
            {
                result += EntreOrden(r.EnlaceIzquierdo);
                result += r.info + "  ";
                result += EntreOrden(r.EnlaceDerecho);
            }
            return result;
        }

        public string PosOrden(NodoArbol r)
        {
            string result = "";
            if (r != null)
            {
                result += PosOrden(r.EnlaceIzquierdo);
                result += PosOrden(r.EnlaceDerecho);
                result += r.info + "  ";
            }
            return result;
        }

        private NodoArbol buscar(NodoArbol r, string nombre)
        {
            if (r != null) {
                if (r.info == nombre) {
                    return r;
                }
                NodoArbol aux = buscar(r.EnlaceIzquierdo, nombre);
                if (aux != null) {
                    return aux;
                }
                else {
                    return buscar(r.EnlaceDerecho, nombre);
                }
            }
            return null;
        }

        public NodoArbol buscar(string nombre) {
            return buscar(raiz, nombre);
        }
    }
}
