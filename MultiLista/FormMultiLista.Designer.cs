namespace MultiLista
{
    partial class FormMultiLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNBrigada = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNBrigada = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.gbListaTrabajadores = new System.Windows.Forms.GroupBox();
            this.dgvListaTrabajadores = new System.Windows.Forms.DataGridView();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminarTrabjador = new System.Windows.Forms.Button();
            this.btnInsertarTrabajador = new System.Windows.Forms.Button();
            this.CIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbListaTrabajadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(307, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "JEFES DE BRIGADA";
            // 
            // lblNBrigada
            // 
            this.lblNBrigada.AutoSize = true;
            this.lblNBrigada.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNBrigada.Location = new System.Drawing.Point(12, 43);
            this.lblNBrigada.Name = "lblNBrigada";
            this.lblNBrigada.Size = new System.Drawing.Size(133, 17);
            this.lblNBrigada.TabIndex = 1;
            this.lblNBrigada.Text = "Número de Brigada:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIdentificador.Location = new System.Drawing.Point(12, 81);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(91, 17);
            this.lblIdentificador.TabIndex = 2;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNBrigada
            // 
            this.txtNBrigada.Location = new System.Drawing.Point(151, 42);
            this.txtNBrigada.Name = "txtNBrigada";
            this.txtNBrigada.Size = new System.Drawing.Size(129, 23);
            this.txtNBrigada.TabIndex = 4;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(151, 80);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(129, 23);
            this.txtIdentificador.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnUltimo);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnPrimero);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(329, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUltimo.Location = new System.Drawing.Point(337, 71);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 28);
            this.btnUltimo.TabIndex = 6;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.Location = new System.Drawing.Point(232, 71);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 28);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(306, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(121, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(59, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrimero.Location = new System.Drawing.Point(15, 71);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 28);
            this.btnPrimero.TabIndex = 1;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertar.Location = new System.Drawing.Point(183, 28);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 30);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // gbListaTrabajadores
            // 
            this.gbListaTrabajadores.Controls.Add(this.dgvListaTrabajadores);
            this.gbListaTrabajadores.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbListaTrabajadores.Location = new System.Drawing.Point(14, 214);
            this.gbListaTrabajadores.Name = "gbListaTrabajadores";
            this.gbListaTrabajadores.Size = new System.Drawing.Size(727, 224);
            this.gbListaTrabajadores.TabIndex = 8;
            this.gbListaTrabajadores.TabStop = false;
            this.gbListaTrabajadores.Text = "Lista de Trabajadores";
            // 
            // dgvListaTrabajadores
            // 
            this.dgvListaTrabajadores.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListaTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdentificador,
            this.CNombre,
            this.COficio});
            this.dgvListaTrabajadores.Location = new System.Drawing.Point(3, 24);
            this.dgvListaTrabajadores.Name = "dgvListaTrabajadores";
            this.dgvListaTrabajadores.RowTemplate.Height = 25;
            this.dgvListaTrabajadores.Size = new System.Drawing.Size(718, 191);
            this.dgvListaTrabajadores.TabIndex = 0;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // btnEliminarTrabjador
            // 
            this.btnEliminarTrabjador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarTrabjador.Location = new System.Drawing.Point(422, 444);
            this.btnEliminarTrabjador.Name = "btnEliminarTrabjador";
            this.btnEliminarTrabjador.Size = new System.Drawing.Size(134, 30);
            this.btnEliminarTrabjador.TabIndex = 9;
            this.btnEliminarTrabjador.Text = "Eliminar Trabajador";
            this.btnEliminarTrabjador.UseVisualStyleBackColor = true;
            this.btnEliminarTrabjador.Click += new System.EventHandler(this.btnEliminarTrabjador_Click);
            // 
            // btnInsertarTrabajador
            // 
            this.btnInsertarTrabajador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertarTrabajador.Location = new System.Drawing.Point(211, 444);
            this.btnInsertarTrabajador.Name = "btnInsertarTrabajador";
            this.btnInsertarTrabajador.Size = new System.Drawing.Size(142, 30);
            this.btnInsertarTrabajador.TabIndex = 10;
            this.btnInsertarTrabajador.Text = "Insertar Trabajador";
            this.btnInsertarTrabajador.UseVisualStyleBackColor = true;
            this.btnInsertarTrabajador.Click += new System.EventHandler(this.btnInsertarTrabajador_Click);
            // 
            // CIdentificador
            // 
            this.CIdentificador.HeaderText = "Identificador";
            this.CIdentificador.Name = "CIdentificador";
            this.CIdentificador.Width = 225;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.Width = 225;
            // 
            // COficio
            // 
            this.COficio.HeaderText = "Oficio";
            this.COficio.Name = "COficio";
            this.COficio.Width = 225;
            // 
            // FormMultiLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 498);
            this.Controls.Add(this.btnInsertarTrabajador);
            this.Controls.Add(this.btnEliminarTrabjador);
            this.Controls.Add(this.gbListaTrabajadores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.txtNBrigada);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblNBrigada);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormMultiLista";
            this.Text = "Ejercicio de MultiLista ";
            this.groupBox1.ResumeLayout(false);
            this.gbListaTrabajadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Label lblNBrigada;
        private Label lblIdentificador;
        private Label lblNombre;
        private TextBox txtNBrigada;
        private TextBox txtIdentificador;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnPrimero;
        private Button btnInsertar;
        private GroupBox gbListaTrabajadores;
        private DataGridView dgvListaTrabajadores;
        private ErrorProvider erpError;
        private Button btnInsertarTrabajador;
        private Button btnEliminarTrabjador;
        private DataGridViewTextBoxColumn CIdentificador;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn COficio;
    }
}