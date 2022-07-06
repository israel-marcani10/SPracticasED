namespace MultiLista
{
    public partial class FormMultiLista : Form
    {
        MListaJefe MiListaJefe = new MListaJefe();
        public FormMultiLista()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNBrigada.Text = "";
            txtIdentificador.Text = "";
            txtNombre.Text = "";

            // para el datagridview
            dgvListaTrabajadores.Rows.Clear();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // validando los textBoxs 
            if (ValidarBrigada() == false) {  // Numero brigada
                return;
            }
            if (ValidarID()==false) {   // Identificador
                return;
            }
            if (ValidarNombre()==false) {   //Nombre
                return;
            }

            // Insertando a la MultiLista
            MiListaJefe.crearLista(int.Parse(txtNBrigada.Text), int.Parse(txtIdentificador.Text), txtNombre.Text);
            MessageBox.Show("Se inserto a la lista correctamente...");

            // Insertando al DataGribView
            //dgvListaTrabajadores.Rows.Add(txtIdentificador.Text, txtNombre.Text, txtNBrigada.Text);
        }
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }

        private bool ValidarID()
        {
            int ID;
            if (!int.TryParse(txtIdentificador.Text, out ID) || txtIdentificador.Text == "")
            {
                erpError.SetError(txtIdentificador, "Debe ingresar un valor numerico para el Identificador");
                txtIdentificador.Clear();
                txtIdentificador.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtIdentificador, "");
                return true;
            }
        }

        private bool ValidarBrigada()
        {
            int NumBrig;
            if (!int.TryParse(txtNBrigada.Text, out NumBrig) || txtNBrigada.Text == "")
            {
                erpError.SetError(txtNBrigada, "Debe ingresar un valor numerico para el Numero de Brigada");
                txtNBrigada.Clear();
                txtNBrigada.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtNBrigada, "");
                return true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // validando que el textbox de N° brigada este con un valor...
            if (ValidarBrigada() == false) {
                return;
            }

            MiListaJefe.BuscarBrigada(int.Parse(txtNBrigada.Text));
            MiListaJefe.EliminarLista();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // creamos una variable aux de tipo nodo jefe
            MLNodoJefe aux = (MLNodoJefe)MiListaJefe.getPrimero();
            if (aux != null) {
                txtNBrigada.Text = aux.getNBrigada().ToString();
                txtIdentificador.Text = aux.getID().ToString();
                txtNombre.Text = aux.getNombre();

                // para el datagridview
                dgvListaTrabajadores.Rows.Clear();
                MiListaJefe.MostrarTrab(int.Parse(txtNBrigada.Text), dgvListaTrabajadores);
            }
            else
                MessageBox.Show("La multilista esta vacia...\n¡Ingrese valores..!");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MLNodoJefe aux = (MLNodoJefe)MiListaJefe.getCursor();
            if (aux != null) {
                aux = MiListaJefe.getPosterior(aux.getNBrigada());
                txtNBrigada.Text = aux.getNBrigada().ToString();
                txtIdentificador.Text = aux.getID().ToString();
                txtNombre.Text = aux.getNombre();

                // para el datagridview
                dgvListaTrabajadores.Rows.Clear();
                MiListaJefe.MostrarTrab(int.Parse(txtNBrigada.Text), dgvListaTrabajadores);
            }
            else
                MessageBox.Show("La multilista esta vacia...\n¡Ingrese valores..!");
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            // creamos una variable aux de tipo nodo jefe
            MLNodoJefe aux = (MLNodoJefe)MiListaJefe.getUltimo();
            if (aux != null) {
                txtNBrigada.Text = aux.getNBrigada().ToString();
                txtIdentificador.Text = aux.getID().ToString();
                txtNombre.Text = aux.getNombre();

                // para el datagridview
                dgvListaTrabajadores.Rows.Clear();
                MiListaJefe.MostrarTrab(int.Parse(txtNBrigada.Text), dgvListaTrabajadores);
            }
            else
                MessageBox.Show("La multilista esta vacia...\n¡Ingrese valores..!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarBrigada() == false)
                return;

            MLNodoJefe aux = (MLNodoJefe)MiListaJefe.BuscarJefe(int.Parse(txtNBrigada.Text));
            if (aux != null) {
                txtNBrigada.Text = aux.getNBrigada().ToString();
                txtIdentificador.Text = aux.getID().ToString();
                txtNombre.Text = aux.getNombre();

                // para el datagridview
                dgvListaTrabajadores.Rows.Clear();
                MiListaJefe.MostrarTrab(int.Parse(txtNBrigada.Text), dgvListaTrabajadores);
            }
            else
                MessageBox.Show("Este jefe que esta buscando no fue registrado....");
        }

        private void btnInsertarTrabajador_Click(object sender, EventArgs e)
        {
            if (ValidarBrigada() == false)
                return;

            int index  = dgvListaTrabajadores.CurrentRow.Index;
            MiListaJefe.InsertarTrab(
                int.Parse(txtNBrigada.Text),
                int.Parse(dgvListaTrabajadores.Rows[index].Cells[0].Value.ToString()),
                dgvListaTrabajadores.Rows[index].Cells[1].Value.ToString(),
                dgvListaTrabajadores.Rows[index].Cells[2].Value.ToString());
        }

        private void btnEliminarTrabjador_Click(object sender, EventArgs e)
        {
            if (ValidarBrigada() == false)
                return;

            int index = dgvListaTrabajadores.CurrentRow.Index;
            MLNodoJefe p = (MLNodoJefe)MiListaJefe.getCursor();
            MiListaJefe.EliminarTrab(int.Parse(txtNBrigada.Text), int.Parse(dgvListaTrabajadores.Rows[index].Cells[0].Value.ToString()));
        }
    }
}