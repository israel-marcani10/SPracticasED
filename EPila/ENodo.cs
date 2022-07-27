using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPila
{
    class PNodo
    {
        public PNodo Enlace;
        public PNodo()
        {
            Enlace = null;
        }
    }

    class NodoPila : PNodo
    {
        private int ID;
        private string Nombre;

        public NodoPila()
        {
            ID = 0;
            Nombre = null;
            Enlace = null;
        }

        public int getID()
        {
            return ID;
        }

        public string getNombre()
        {
            return Nombre;
        }

        class PLista
        {
            public PNodo Primero;
            public PNodo Ultimo;
            public PNodo Cursor;

            public PLista()
            {
                Primero = null;
                Ultimo = null;
                Cursor = null;
            }
            public bool vacia()
            {
                if (Primero == null)
                    return true;
                else
                    return false;
            }
            public void Insertar(PNodo _nodo)
            {
                if (vacia())
                {
                    Primero = _nodo;
                    Ultimo = _nodo;
                    Cursor = _nodo;
                }
                else
                {
                    Ultimo.Enlace = _nodo;
                    Ultimo = _nodo;
                    Cursor = Ultimo;
                }
                _nodo.Enlace = null;
            }
            public PNodo Eliminar()
            {
                PNodo aux;
                if (Cursor == null)
                    return null;
                else
                {
                    if (Cursor == Primero)
                        return null;
                    else {
                        aux = getAntCursor();
                        aux.Enlace = Cursor.Enlace;
                        if (Cursor == Ultimo)
                            Ultimo = aux;
                        Cursor = aux.Enlace;
                        return Cursor;
                    }
                }
            }
            public PNodo getProxCursor()
            {
                if (Cursor != null)
                    return Cursor.Enlace;
                else
                {
                    System.Windows.Forms.MessageBox.Show("No existe sucesor");
                    return null;
                }
            }
            public PNodo getAntCursor()
            {
                PNodo aux;
                if ((Cursor != null) && (Cursor != Primero))
                {
                    aux = Primero;
                    while (aux.Enlace != Cursor)
                        aux = aux.Enlace;
                    return aux;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No existe Antecesor");
                    return null;
                }

            }
        }
    }
}
