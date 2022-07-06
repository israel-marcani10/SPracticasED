using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLista
{
    class TNodo
    {
        public TNodo pEnlace;

        public TNodo()
        {
            pEnlace = null;
        }
    }

    class TLista
    {
        public TNodo primero;
        public TNodo ultimo;
        public TNodo cursor;

        public TLista()
        {
            primero = null;
            ultimo = null;
            cursor = null;
        }

        public void inicializar()
        {
            primero = null;
            ultimo = null;
            cursor = null;
        }

        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar(TNodo nodo)
        {
            if (vacia())
            {
                primero = nodo;
                ultimo = nodo;
                cursor = nodo;
            }
            else
            {
                ultimo.pEnlace = nodo;
                ultimo = nodo;
                cursor = nodo;
            }
            nodo.pEnlace = null;
        }

        public TNodo eleminarprimero()
        {
            if (vacia())
                return null;
            else
            {
                if (primero == ultimo)
                    inicializar();
                else
                {
                    if (cursor == primero)
                    {
                        cursor = getProxCursor();
                        primero = primero.pEnlace;
                    }
                }
                return primero;
            }
        }

        public TNodo eliminar()
        {
            TNodo pTemp;
            if (cursor == null)
                return null;
            else
            {
                if (cursor == primero)
                    return eleminarprimero();
                else
                {
                    pTemp = getAntCursor();
                    pTemp.pEnlace = cursor.pEnlace;
                    if (cursor == ultimo)
                        ultimo = pTemp;
                    cursor = pTemp.pEnlace;
                    return cursor;
                }
            }
        }

        public TNodo getPrimero()
        {
            return primero;
        }

        public TNodo getUltimo()
        {
            return ultimo;
        }

        public TNodo getCursor()
        {
            return cursor;
        }

        public TNodo getProxCursor()
        {
            if (cursor != null)
                return cursor.pEnlace;
            else
                return null;
        }

        public TNodo getAntCursor()
        {
            TNodo pTemp;
            if ((cursor != null) && (cursor != primero))
            {
                pTemp = primero;
                while (pTemp.pEnlace != cursor)
                    pTemp = pTemp.pEnlace;
                return pTemp;
            }
            else
                return null;
        }

        public void setCursor(TNodo p)
        {
            cursor = p;
        }

    }
}
