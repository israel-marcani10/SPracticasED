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
                btnInsertRaiz.Enabled = false;
                MessageBox.Show("Se introducio la raiz");
            }
        }

        private void btnInsertIzq_Click(object sender, EventArgs e)
        {
            if (txtPadre.Text == "" || txtHijo.Text == "") {
                MessageBox.Show("Introduzca un Padre o hijo");
                return;
            }
            if (MiArbol.buscar(txtPadre.Text) == null)
            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }
            else
            {
                NodoArbol aux = MiArbol.buscar(txtPadre.Text);
                MiArbol.InsertarIzq(new NodoArbol(txtHijo.Text), aux);
                MessageBox.Show("Se introducio el nodo a la izquierda");
            }
        }

        private void btnInsertDer_Click(object sender, EventArgs e)
        {
            if (txtPadre.Text == "" || txtHijo.Text == "") {
                MessageBox.Show("Introduzca un Padre o hijo");
                return;
            }
            if (MiArbol.buscar(txtPadre.Text) == null)
            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }
            else
            {
                NodoArbol aux = MiArbol.buscar(txtPadre.Text);
                MiArbol.InsertarDer(new NodoArbol(txtHijo.Text), aux);
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
            if (MiArbol.buscar(txtPadre.Text) == null)
            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }
            else
            {
                NodoArbol aux = MiArbol.buscar(txtPadre.Text);
                MiArbol.EliminarIzquierdo(aux);
            }
        }

        private void btnEliminarDer_Click(object sender, EventArgs e)
        {
            if (txtPadre.Text == "")
            {
                MessageBox.Show("Introduzca un Padre");
                return;
            }
            if (MiArbol.buscar(txtPadre.Text) == null)
            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }
            else
            {
                NodoArbol aux = MiArbol.buscar(txtPadre.Text);
                MiArbol.EliminarDerecho(aux);
            }
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtMostrarArbol.Text =  MiArbol.PreOrden1();
        }

        private void btnEntreOrden_Click(object sender, EventArgs e)
        {
            txtMostrarArbol.Text = MiArbol.EntreOrden(MiArbol.raiz);
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            txtMostrarArbol.Text = MiArbol.PosOrden(MiArbol.raiz);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMostrarArbol.Text = "";
        }
    }
}