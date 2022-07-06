using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLista
{
    class MLNodo
    {
        public MLNodo PENodo; //Enlace
        public MLNodo()
        {
            PENodo = null;
        }
    }

    //Nodo jefe de brigada hereda de Nodo
    class MLNodoJefe: MLNodo
    {
        private int ID;                  //Identificador
        private int NBrigada;            //Numero del jefe de brigada
        private string Nombre;           //Nombre del jefe de brigada
        public MLista TListaTrabajador;  //TListaTrabajador es de tipo TLista

        public MLNodoJefe() { }              //Constructor

        public MLNodoJefe(int nbrig, int id, string nombrigada) //Constructor que recibe tres parametros
        {
            NBrigada = nbrig;
            ID = id;
            Nombre = nombrigada;
            TListaTrabajador = new MLista();   //Crea una lista 
        }

        //Devuelve el identificador de la brigada
        public int getID()
        {
            return ID;
        }

        //Devuelve el Nombre del jefe de brigada
        public string getNombre()
        {
            return Nombre;
        }

        //Devuelve el numero del jefe de brigada
        public int getNBrigada()
        {
            return NBrigada;
        }
    } //Fin de la clase MLNodoJefe

    class MLista
    {
        public MLNodo Primero;
        public MLNodo Ultimo;
        public MLNodo Cursor;

        public MLista()     //Constructor
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

        public void Insertar(MLNodo nodo)
        {
            if (Vacia())
            {
                Primero = nodo;
                Ultimo = nodo;
                Cursor = nodo;
            }
            else
            {
                Ultimo.PENodo = nodo;
                Ultimo = nodo;
                Cursor = nodo;
            }
            nodo.PENodo = Primero;  //el ultimo nodo apunta al primero

        }

        public MLNodo Eliminarprimero()
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
                        Primero = Primero.PENodo;

                    }
                }
                return Primero;
            }
        }

        public MLNodo Eliminar()
        {
            MLNodo VTemp;
            if (Cursor == null)
                return null;
            else
            {
                if (Cursor == Primero)
                    return Eliminarprimero();
                else
                {
                    VTemp = getAntCursor();
                    VTemp.PENodo = Cursor.PENodo;
                    if (Cursor == Ultimo)
                        Ultimo = VTemp;
                    Cursor = VTemp.PENodo;
                    return Cursor;
                }
            }
        }


        public MLNodo getPrimero()
        {
            return Primero;
        }


        public MLNodo getUltimo()
        {
            return Ultimo;
        }


        public MLNodo getCursor()
        {
            return Cursor;
        }


        public MLNodo getProxCursor()
        {
            if (Cursor != null)
                return Cursor.PENodo;
            else
            {
                MessageBox.Show("No existe sucesor");
                return null;
            }

        }

        public MLNodo getAntCursor()
        {
            MLNodo VTemp;
            if ((Cursor != null) && (Cursor != Primero))
            {
                VTemp = Primero;
                while (VTemp.PENodo != Cursor)
                    VTemp = VTemp.PENodo;
                return VTemp;
            }
            else
            {
                MessageBox.Show("No existe Antecesor");
                return null;
            }

        }

        public void setCursor(MLNodo p)
        {
            Cursor = p;
        }
    }
}
