namespace WinFormsLista
{
    public partial class PestanaListaA : Form
    {
        LCDLista MiLista = new LCDLista();
        bool creado = true;
        public PestanaListaA()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (validarNombre() == false)
            {
                return;
            }
            if (validarEdad() == false)
            {
                return;
            }

            // insertamos a la lista
            //LCDNodo nuevo = new LCDNodo();
            string NombreP = txtNombrePersona.Text;
            int EdadP = int.Parse(txtEdad.Text);
            MiLista.insertarNodo(NombreP, EdadP);
            limpiarControles();
        }

        // metodo para limpiar los controles del formulario
        private void limpiarControles()
        {
            txtNombrePersona.Text = "";
            txtEdad.Text = "";
            txtBuscar.Text = "";
        }

        // metodo para validar la edad
        private bool validarEdad()
        {
            int Edad;
            if (!int.TryParse(txtEdad.Text, out Edad) || txtEdad.Text == "") {
                erpError.SetError(txtEdad, "Debe ingresar un valor numerico para la edad");
                txtEdad.Clear();
                txtEdad.Focus();
                return false;
            }
            else {
                erpError.SetError(txtEdad, "");
                return true;
            }
        }

        // metodo para validar nombre
        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombrePersona.Text))
            {
                erpError.SetError(txtNombrePersona, "Debe ingresar un nombre");
                return false;
            }
            else {
                erpError.SetError(txtNombrePersona, "");
                return true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarBuscar()==false)
            {
                return;
            }

            if (MiLista.bucarNodo(txtBuscar.Text) == true)
            {
                txtNombrePersona.Text = MiLista.getActualNombre();
                txtEdad.Text = MiLista.getActualEdad().ToString();
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.");
            }
            //MiLista.bucarNodo(txtBuscar.Text);
            
            
        }

        private bool validarBuscar()
        {
            int aux;
            if (string.IsNullOrEmpty(txtBuscar.Text) || int.TryParse(txtBuscar.Text, out aux))
            {
                erpError.SetError(txtBuscar, "Debe ingresar un nombre. Invalido un numero");
                return false;
            }
            else
            {
                erpError.SetError(txtBuscar, "");
                return true;
            }
        }

        private void bntEleminar_Click(object sender, EventArgs e)
        {
            if (validarBuscar()==false)
            {
                return;
            }

            MiLista.eliminarNodo(txtBuscar.Text);
            txtBuscar.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarBuscar()==false)
            {
                return;
            }
            if (MiLista.bucarNodo(txtBuscar.Text) == true)
            {
                MiLista.modificarNodo(txtBuscar.Text, txtNombrePersona.Text, int.Parse(txtEdad.Text));
                limpiarControles();
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.");
            }
            
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (MiLista.PrimerNombre()==true) {
                txtNombrePersona.Text = MiLista.getPrimeroNombre();
                txtEdad.Text = MiLista.getPrimeroEdad().ToString();
            }
            else {
                MessageBox.Show("La lista esta vacia.");
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (MiLista.ultimoNombre() == true)
            {
                txtNombrePersona.Text = MiLista.getUltimoNombre();
                txtEdad.Text = MiLista.getUltimoEdad().ToString();
            }
            else
            {
                MessageBox.Show("La lista esta vacia.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = "";
            txtEdad.Text = "";
            txtBuscar.Text = "";
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
           txtNombrePersona.Text = MiLista.getAnteriorNombre();
           txtEdad.Text = MiLista.getAnteriorEdad().ToString();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = MiLista.getSiguienteNombre();
            txtEdad.Text = MiLista.getSiguienteEdad().ToString();
        }

        private void PestanaListaA_Load(object sender, EventArgs e)
        {

        }
    }
}