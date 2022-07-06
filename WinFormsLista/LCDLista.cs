using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLista
{
    class LCDLista
    {
        LCDNodo primero = new LCDNodo();
        LCDNodo ultimo  = new LCDNodo();
        LCDNodo aux = new LCDNodo();

        public LCDLista()
        {
            primero = null;
            ultimo = null;
            aux = null;
        }

/*
ejemplo:
	dato: 5
primero = 5		ultimo = 5
5 <- 5 -> 5

	dato: 7
primero = 5		ultimo = 7
7 <- 5 -> <- 7 -> 5

	dato: 9
primero = 5		ultimo = 9
9 <- 5 -> <- 7 -> <- 9 -> 5
*/

        public void insertarNodo(string _nombre, int _edad)
        {
            LCDNodo nuevo = new LCDNodo();
            //Console.Write("Ingrese el dato del nuevo nodo: ");
            nuevo.Nombre = _nombre;
            nuevo.Edad = _edad;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Siguiente = primero;
                primero.Atras = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Atras = ultimo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
                primero.Atras = ultimo;
            }
            //Console.WriteLine("\n Nuevo nodo ingresado con exito.\n\n");
        }

        public bool bucarNodo(string _buscarNombre)
        {
            //LCDNodo aux = new LCDNodo();
            aux = primero;
            bool encontrado = false;
            //Console.WriteLine("Ingrese el dato nodo a buscar: ");
            string nodoBuscado = _buscarNombre;
            if (aux != null)
            {
                do {
                    if (aux.Nombre == nodoBuscado) {
                        encontrado = true;
                        return encontrado;
                    }
                    aux = aux.Siguiente;
                } while (aux != primero);
            }
            return encontrado;
            /*
            else {
                Console.WriteLine("\n La lista se encuentra vacia.\n\n");
            }*/
        }

        public void modificarNodo(string _modificarNombre, string _nuevoNombre, int _nuevaEdad)
        {
            //LCDNodo aux = new LCDNodo();
            aux = primero;
            bool encontrado = false;
            //Console.WriteLine("Ingrese el dato nodo a modificar: ");
            string nodoBuscado = _modificarNombre;
            if (aux != null)
            {
                do
                {
                    if (aux.Nombre == nodoBuscado)
                    {
                        //Console.WriteLine("\n  Nodo con el dato ({}) encontrado\n", aux.Dato);
                       //Console.WriteLine("Ingrese el nuevo dato para este nodo: ");
                        aux.Nombre = _nuevoNombre;
                        aux.Edad = _nuevaEdad;
                        //Console.WriteLine("\nNodo modificado");
                        encontrado = true;
                    }
                    aux = aux.Siguiente;
                } while (aux != primero && encontrado != true);
                
                if (!encontrado)
                {
                    ;
                }
            }
            /*
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia.\n\n");
            }*/
        }

        public void eliminarNodo(string _elimanarNodo)
        {
            LCDNodo auxActual = new LCDNodo();
            auxActual = primero;
            LCDNodo auxAnterior = new LCDNodo();
            auxAnterior = null;
            bool encontrado = false;
            //Console.WriteLine("Ingrese el dato nodo a eleminar: ");
            string nodoBuscado = _elimanarNodo;
            if (auxActual != null)
            {
                do {
                    if (auxActual.Nombre == nodoBuscado) {
                        // aqui eliminamos
                        if (auxActual == primero) {
                            primero = primero.Siguiente;
                            primero.Atras = ultimo;
                            ultimo.Siguiente = primero;
                        }
                        else if (auxActual == ultimo) {
                            ultimo = auxAnterior;
                            ultimo.Siguiente = primero;
                            primero.Atras = ultimo;
                        }
                        else {
                            auxAnterior.Siguiente = auxActual.Siguiente;
                            auxActual.Siguiente.Atras = auxAnterior;
                        }
                        //Console.WriteLine("\nNodo eliminado.\n");
                        encontrado = true;
                    }
                    auxAnterior = auxActual;
                    auxActual = auxActual.Siguiente;
                } while (auxActual != primero && encontrado != true);
                /*
                if (!encontrado) {
                    Console.WriteLine("\n  Nodo NO encontrado.");
                }*/
            }
            /*
            else {
                Console.WriteLine("\n La lista se encuentra vacia.\n\n");
            }*/
        }

        // primero
        public bool PrimerNombre() {
            aux = primero;
            bool encontrado = false;
            if (aux != null) {
                do {
                    if (aux.Nombre == primero.Nombre) {
                        encontrado = true;
                        return encontrado;
                    }
                    aux = aux.Siguiente;
                } while (aux != primero);
            }
            return encontrado;
        }
        public string getPrimeroNombre()
        {
            return aux.Nombre;
        }
        public int getPrimeroEdad() {
            return aux.Edad;
        }
        // ultimo
        public bool ultimoNombre()
        {
            aux = primero;
            bool encontrado = false;
            if (aux != null)
            {
                do
                {
                    if (aux.Nombre == ultimo.Nombre)
                    {
                        encontrado = true;
                        return encontrado;
                    }
                    aux = aux.Siguiente;
                } while (aux != primero);
            }
            return encontrado;
        }
        public string getUltimoNombre()
        {
            return aux.Nombre;
        }
        public int getUltimoEdad()
        {
            return aux.Edad;
        }
        // actual
        public string getActualNombre()
        {
            return aux.Nombre;
        }
        public int getActualEdad()
        {
            return aux.Edad;
        }
        // siguiente
        public string getSiguienteNombre()
        {
            aux = aux.Siguiente;
            return aux.Nombre;
        }
        public int getSiguienteEdad()
        {
           return aux.Edad;
        }
        // anterior
        public string getAnteriorNombre()
        {
            aux = aux.Atras;
            return aux.Nombre;
        }
        public int getAnteriorEdad()
        {
            
            return aux.Edad;
        }

        public void mostrarListaPU()
        {
            LCDNodo aux = new LCDNodo();
            aux = primero;
            if (aux != null)
            {
                do {
                    Console.WriteLine(" " + aux.Nombre);
                    aux = aux.Siguiente;
                } while (aux != primero);
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia.\n\n");
            }
        }

        public void mostrarListaUP()
        {
            LCDNodo aux = new LCDNodo();
            aux = ultimo;
            if (aux != null)
            {
                do {
                    Console.WriteLine(" " + aux.Nombre);
                    aux = aux.Atras;
                } while (aux != ultimo);
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia.\n\n");
            }
        }
    }
}
