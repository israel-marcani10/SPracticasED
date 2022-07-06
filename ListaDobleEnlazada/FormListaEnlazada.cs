using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleEnlazada
{
    public partial class FormListaEnlazada : Form
    {
        TLisAsig MiLista = new TLisAsig();
        public FormListaEnlazada()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtHoras.Text == "") {
                MessageBox.Show("Ingrese valores a las cajas de texto...");
                return;
            }

            MiLista.crearLista(txtNombre.Text, int.Parse(txtHoras.Text));
            MessageBox.Show("Se inserto a la lista...");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") {
                MessageBox.Show("Ingrese un nombre para un nodo de la lista...");
                return;
            }

            MiLista.eliminarLista(txtNombre.Text);
            MessageBox.Show("Se elimino de la lista...");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtHoras.Text = "";
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            TNodoAsig aux = (TNodoAsig)MiLista.getPrimero();

            txtNombre.Text = aux.dameAsig();
            txtHoras.Text = aux.dameHoras().ToString();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            TNodoAsig aux = (TNodoAsig)MiLista.getUltimo();

            txtNombre.Text = aux.dameAsig();
            txtHoras.Text = aux.dameHoras().ToString();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            TNodoAsig aux = (TNodoAsig)MiLista.getCursor();
            if (aux != null)
            {
                aux = (TNodoAsig)MiLista.getAntCursor();
                txtNombre.Text = aux.dameAsig();
                txtHoras.Text = aux.dameHoras().ToString();
            }
            else
            {
                MessageBox.Show("La lista esta vacia...");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            TNodoAsig aux = (TNodoAsig)MiLista.getCursor();
            if (aux != null) {
                aux = (TNodoAsig)MiLista.getProxCursor();
                txtNombre.Text = aux.dameAsig();
                txtHoras.Text = aux.dameHoras().ToString();
            }
            else
            {
                MessageBox.Show("La lista esta vacia...");
            }
        }
    }
}
