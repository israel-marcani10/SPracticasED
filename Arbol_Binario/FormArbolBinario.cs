namespace Arbol_Binario
{
    public partial class FormArbolBinario : Form
    {
        ArbolBinario MiArbol = new ArbolBinario();
        public FormArbolBinario()
        {
            InitializeComponent();
        }

        private void btnInsertRaiz_Click(object sender, EventArgs e)
        {
            if (txtInsertRaiz.Text == "")
                MessageBox.Show("Introduzca un valor");
            else {
                // introduciendo la raiz del arbol
                MiArbol.InsertarRaiz(new NodoArbol(txtInsertRaiz.Text));
                MessageBox.Show("Se introducio la raiz");
            }
        }

        private void btnInsertIzq_Click(object sender, EventArgs e)
        {
            if (txtPadre.Text == "" || txtHijo.Text == "") {
                MessageBox.Show("Introduzca un Padre o hijo");
                return;
            }
            else
            {
                MiArbol.InsertarIzq(new NodoArbol(txtHijo.Text), new NodoArbol(txtPadre.Text));
                MessageBox.Show("Se introducio el nodo a la izquierda");
            }
        }

        private void btnInsertDer_Click(object sender, EventArgs e)
        {
            if (txtPadre.Text == "" || txtHijo.Text == "") {
                MessageBox.Show("Introduzca un Padre o hijo");
                return;
            }
            else
            {
                MiArbol.InsertarDer(new NodoArbol(txtHijo.Text), new NodoArbol(txtPadre.Text));
                MessageBox.Show("Se introducio el nodo a la derecha");
            }
        }

        private void btnEliminarIzq_Click(object sender, EventArgs e)
        {
            if (txtPadre.Text == "")
            {
                MessageBox.Show("Introduzca un Padre");
                return;
            }
            else
            {
                MiArbol.EliminarIzquierdo(new NodoArbol(txtPadre.Text));
            }
        }

        private void btnEliminarDer_Click(object sender, EventArgs e)
        {
            if (txtPadre.Text == "")
            {
                MessageBox.Show("Introduzca un Padre");
                return;
            }
            else
            {
                MiArbol.EliminarDerecho(new NodoArbol(txtPadre.Text));
            }
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtMostrarArbol.Text =  MiArbol.PreOrden1();
        }

        private void btnEntreOrden_Click(object sender, EventArgs e)
        {
            //txtMostrarArbol.Text = MiArbol.EntreOrden();
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            //txtMostrarArbol.Text = MiArbol.PosOrden();
        }
    }
}