using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    class TNodo {
        public TNodo pEnlace;

        public TNodo() {
            pEnlace = null;
        }
    }

    class TNodoPersona : TNodo
    {
        private string Nombre;
        private int Horas;

        public TNodoPersona() { }

        public TNodoPersona(string _nombre, int _horas)
        {
            Nombre = _nombre;
            Horas = _horas;
        }

        public string getNombre()
        {
            return Nombre; ;
        }
        public int getHoras()
        {
            return Horas;
        }
    }

    class TListaBase
    {
        public TNodo Primero;
        public TNodo Ultimo;
        public TNodo Cursor;

        public TListaBase()     //Constructor
        {
            Primero = null;
            Ultimo = null;
            Cursor = null;
        }

        public void inicializar()  //Inicializa los valores
        {
            Primero = null;
            Ultimo = null;
            Cursor = null;
        }

        public bool Vacia()
        {
            if (Primero == null)
                return true;
            else
                return false;
        }

        public void Insertar(TNodo nodo)
        {
            if (Vacia())
            {
                Primero = nodo;
                Ultimo = nodo;
                Cursor = nodo;
            }
            else
            {
                Ultimo.pEnlace = nodo;
                Ultimo = nodo;
                Cursor = Ultimo;
            }
            nodo.pEnlace = Primero;  //el ultimo nodo apunta al primero
        }

        public TNodo Eliminarprimero()
        {
            if (Vacia())
                return null;
            else
            {
                if (Primero == Ultimo)  //si cumple es que un solo elemento
                    inicializar();
                else
                {
                    if (Cursor == Primero)
                    {
                        Cursor = getProxCursor();
                        Primero = Primero.pEnlace;

                    }
                }
                return Primero;
            }
        }

        public TNodo Eliminar()
        {
            TNodo VTemp;
            if (Cursor == null)
                return null;
            else
            {
                if (Cursor == Primero)
                    return Eliminarprimero();
                else
                {
                    VTemp = getAntCursor();
                    VTemp.pEnlace = Cursor.pEnlace;
                    if (Cursor == Ultimo)
                        Ultimo = VTemp;
                    Cursor = VTemp.pEnlace;
                    return Cursor;
                }
            }
        }

        public TNodo getPrimero()
        {
            return Primero;
        }

        public TNodo getUltimo()
        {
            return Ultimo;
        }

        public TNodo getCursor()
        {
            return Cursor;
        }

        public TNodo getProxCursor()
        {
            if (Cursor != null)
                return Cursor.pEnlace;
            else {
                //MessageBox.Show("No existe sucesor");
                return null;
            }
            
        }

        public TNodo getAntCursor()
        {
            TNodo VTemp;
            if ((Cursor != null) && (Cursor != Primero))
            {
                VTemp = Primero;
                while (VTemp.pEnlace != Cursor)
                    VTemp = VTemp.pEnlace;
                return VTemp;
            }
            else
            {
                //MessageBox.Show("No existe Antecesor");
                return null;
            }

        }
    }
}
