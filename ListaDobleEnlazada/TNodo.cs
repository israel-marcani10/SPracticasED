using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    struct nodoAsig {
        public string nomb;
        public int cantHrs;
    }

    class TNodoAsig : TNodo {
        public nodoAsig info;
        public TNodoAsig(string nom, int ch) : base() {
            info.nomb = nom;
            info.cantHrs = ch;
        }

        public string dameAsig() {
            return info.nomb;
        }

        public int dameHoras() {
            return info.cantHrs;
        }
    }

    class TLisAsig : TLista {
        public TLisAsig() : base() { }

        public void crearLista(string a, int hr) {
            insertar(new TNodoAsig(a, hr));
        }

        public TNodo sucessor(string a) {
            return getProxCursor();
        }

        public TNodo antecessor(string a) {
            return getAntCursor();
        }

        public bool eliminarLista(String a) {
            eliminar();
            return true;
        }
        public bool BuscarAsig(String nom) {
            bool bus = false;
            TNodo p;
            p = primero;
            while (p != null && bus == false) {
                if (((TNodoAsig)p).dameAsig().Equals(nom))
                    bus = true;
                else
                    p = p.pEnlace;
            }
            if (bus)
                cursor = p;
            return bus;
        }
    }
}
