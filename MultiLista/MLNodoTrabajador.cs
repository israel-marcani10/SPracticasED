using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLista
{
    class MLNodoTrabajador : MLNodo
    {
        public int ID;
        public string Nombre;
        public string Oficio;

        public MLNodoTrabajador(int iden, string nomb, string oficio)
        {
            ID = iden;
            Nombre = nomb;
            Oficio = oficio;
        }

        public int getID()
        {
            return ID;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getOficio()
        {
            return Oficio;
        }
    }
}
