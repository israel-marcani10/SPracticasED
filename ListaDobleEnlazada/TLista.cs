using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    class TLista : TListaBase
    {
        public TLista() { }

        public void crearLista(string _nombre, int _horas)
        {
            Insertar(new TNodoPersona(_nombre, _horas));
        }

        private bool Buscar(string _nombre)
        {
            TNodoPersona p;
            bool aux = false;
            p = (TNodoPersona)getPrimero();
            if (p != null) {
                do {
                    if (p.getNombre() == _nombre) {
                        aux = true;
                        Cursor = p;
                        break;
                    }
                    p = (TNodoPersona)p.pEnlace;
                } while (p != Primero);
            }
            return aux;
        }

        public TNodoPersona BuscarPersona(string _nombre)
        {
            if (Buscar(_nombre))
                return (TNodoPersona)getCursor();
            else
                return null;
        }

        public TNodoPersona getAnterior(string _nombre)
        {
            if (Buscar(_nombre))
                return (TNodoPersona)getAntCursor();
            else
                return null;
        }

        public TNodoPersona getPosterior(string _nombre)
        {
            if (Buscar(_nombre))
                return (TNodoPersona)getProxCursor();
            else
                return null;
        }

        public bool EliminarLista()
        {
            if (getCursor() != null)
            {
                Eliminar();
                return true;
            }
            else return false;
        }
    }    
}
