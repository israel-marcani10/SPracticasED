using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLista
{
    class MListaJefe : MLista
    {
        public MListaJefe() { }

        public void crearLista(int Brigada, int ID, string Nombre)
        {
            Insertar(new MLNodoJefe(Brigada, ID, Nombre));
        }


        public bool BuscarBrigada(int nB)
        {
            MLNodoJefe p;
            bool aux = false;
            p = (MLNodoJefe)getPrimero();
            if (p != null)
            {
                do
                {
                    if (p.getNBrigada() == nB)
                    {
                        aux = true;
                        Cursor = p;
                        break;
                    }
                    p = (MLNodoJefe)p.PENodo;
                } while (p != Primero);
            }
            return aux;
        }

        public MLNodoJefe BuscarJefe(int nB)
        {
            if (BuscarBrigada(nB))
                return (MLNodoJefe)getCursor();
            else
                return null;
        }
        public MLNodoJefe getAnterior(int nB)
        {
            if (BuscarBrigada(nB))
                return (MLNodoJefe)getAntCursor();
            else
                return null;
        }

        public MLNodoJefe getPosterior(int nB)
        {
            if (BuscarBrigada(nB))
                return (MLNodoJefe)getProxCursor();
            else
                return null;
        }


        public void InsertarTrab(int nB, int i, string n, string o)
        {
            MLNodoJefe p = new MLNodoJefe();

            if (BuscarBrigada(nB)) {
                p = (MLNodoJefe)getCursor();
                p.TListaTrabajador.Insertar(new MLNodoTrabajador(i, n, o));
            }
        }

        public void EliminarTrab(int nB, int NId)
        {
            MLNodoJefe p;
            MLNodoTrabajador q;
            BuscarBrigada(nB);
            p = (MLNodoJefe)getCursor();
            q = (MLNodoTrabajador)p.TListaTrabajador.getPrimero();
            while (true)
            {
                if (q.ID == NId)
                {
                    p.TListaTrabajador.Cursor = q;
                    break;
                }
                else
                    q = (MLNodoTrabajador)q.PENodo;
            }
            p.TListaTrabajador.Eliminar();
        }


        public void MostrarTrab(int nB, DataGridView dgv)
        {
            MLNodoJefe p;
            MLNodoTrabajador q;
            int i, n;

            n = contarTrabajadores(nB);
            //n = dgv.RowCount - 1;
            BuscarBrigada(nB);
            p = (MLNodoJefe)getCursor();
            q = (MLNodoTrabajador)p.TListaTrabajador.getPrimero();

            dgv.Rows.Clear();
            for (i = 0; i <= n; i++)
            {
                if (q == null)
                    break;
                else
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[0].Value = q.getID();
                    dgv.Rows[i].Cells[1].Value = q.getNombre();
                    dgv.Rows[i].Cells[2].Value = q.getOficio();
                    q = (MLNodoTrabajador)q.PENodo;
                }
            }
        }

        public int contarTrabajadores(int nB)
        {
            MLNodoJefe p;
            MLNodoTrabajador q;
            int aux = 0;

            BuscarBrigada(nB);
            p = (MLNodoJefe)getCursor();
            q = (MLNodoTrabajador)p.TListaTrabajador.getPrimero();
            
            while (true) {
                if (q == p.TListaTrabajador.Ultimo)
                    return aux;
                else {
                    q = (MLNodoTrabajador)q.PENodo;
                    aux++;
                }
            }
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
