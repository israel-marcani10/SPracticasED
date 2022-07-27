namespace Arbol_Binario
{
    partial class FormArbolBinario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInsertRaiz = new System.Windows.Forms.TextBox();
            this.btnInsertRaiz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHijo = new System.Windows.Forms.TextBox();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarDer = new System.Windows.Forms.Button();
            this.btnInsertDer = new System.Windows.Forms.Button();
            this.btnEliminarIzq = new System.Windows.Forms.Button();
            this.btnInsertIzq = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPosOrden = new System.Windows.Forms.Button();
            this.btnEntreOrden = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.txtMostrarArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInsertRaiz);
            this.groupBox1.Controls.Add(this.btnInsertRaiz);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar Raiz";
            // 
            // txtInsertRaiz
            // 
            this.txtInsertRaiz.Location = new System.Drawing.Point(144, 34);
            this.txtInsertRaiz.Name = "txtInsertRaiz";
            this.txtInsertRaiz.Size = new System.Drawing.Size(157, 25);
            this.txtInsertRaiz.TabIndex = 1;
            // 
            // btnInsertRaiz
            // 
            this.btnInsertRaiz.Location = new System.Drawing.Point(19, 34);
            this.btnInsertRaiz.Name = "btnInsertRaiz";
            this.btnInsertRaiz.Size = new System.Drawing.Size(110, 30);
            this.btnInsertRaiz.TabIndex = 0;
            this.btnInsertRaiz.Text = "Insertar Raiz";
            this.btnInsertRaiz.UseVisualStyleBackColor = true;
            this.btnInsertRaiz.Click += new System.EventHandler(this.btnInsertRaiz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHijo);
            this.groupBox2.Controls.Add(this.txtPadre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEliminarDer);
            this.groupBox2.Controls.Add(this.btnInsertDer);
            this.groupBox2.Controls.Add(this.btnEliminarIzq);
            this.groupBox2.Controls.Add(this.btnInsertIzq);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(239, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar Nodo";
            // 
            // txtHijo
            // 
            this.txtHijo.Location = new System.Drawing.Point(192, 43);
            this.txtHijo.Name = "txtHijo";
            this.txtHijo.Size = new System.Drawing.Size(128, 25);
            this.txtHijo.TabIndex = 7;
            // 
            // txtPadre
            // 
            this.txtPadre.Location = new System.Drawing.Point(19, 43);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.Size = new System.Drawing.Size(122, 25);
            this.txtPadre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hijo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Padre";
            // 
            // btnEliminarDer
            // 
            this.btnEliminarDer.Location = new System.Drawing.Point(192, 109);
            this.btnEliminarDer.Name = "btnEliminarDer";
            this.btnEliminarDer.Size = new System.Drawing.Size(128, 29);
            this.btnEliminarDer.TabIndex = 3;
            this.btnEliminarDer.Text = "Eliminar Derecha";
            this.btnEliminarDer.UseVisualStyleBackColor = true;
            this.btnEliminarDer.Click += new System.EventHandler(this.btnEliminarDer_Click);
            // 
            // btnInsertDer
            // 
            this.btnInsertDer.Location = new System.Drawing.Point(192, 74);
            this.btnInsertDer.Name = "btnInsertDer";
            this.btnInsertDer.Size = new System.Drawing.Size(128, 29);
            this.btnInsertDer.TabIndex = 2;
            this.btnInsertDer.Text = "Insertar Derecha";
            this.btnInsertDer.UseVisualStyleBackColor = true;
            this.btnInsertDer.Click += new System.EventHandler(this.btnInsertDer_Click);
            // 
            // btnEliminarIzq
            // 
            this.btnEliminarIzq.Location = new System.Drawing.Point(19, 109);
            this.btnEliminarIzq.Name = "btnEliminarIzq";
            this.btnEliminarIzq.Size = new System.Drawing.Size(122, 29);
            this.btnEliminarIzq.TabIndex = 1;
            this.btnEliminarIzq.Text = "Eliminar Izquierda";
            this.btnEliminarIzq.UseVisualStyleBackColor = true;
            this.btnEliminarIzq.Click += new System.EventHandler(this.btnEliminarIzq_Click);
            // 
            // btnInsertIzq
            // 
            this.btnInsertIzq.Location = new System.Drawing.Point(19, 74);
            this.btnInsertIzq.Name = "btnInsertIzq";
            this.btnInsertIzq.Size = new System.Drawing.Size(122, 29);
            this.btnInsertIzq.TabIndex = 0;
            this.btnInsertIzq.Text = "Insertar Izquierda";
            this.btnInsertIzq.UseVisualStyleBackColor = true;
            this.btnInsertIzq.Click += new System.EventHandler(this.btnInsertIzq_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnPosOrden);
            this.groupBox3.Controls.Add(this.btnEntreOrden);
            this.groupBox3.Controls.Add(this.btnPreOrden);
            this.groupBox3.Controls.Add(this.txtMostrarArbol);
            this.groupBox3.Location = new System.Drawing.Point(177, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar Arbol";
            // 
            // btnPosOrden
            // 
            this.btnPosOrden.Location = new System.Drawing.Point(17, 107);
            this.btnPosOrden.Name = "btnPosOrden";
            this.btnPosOrden.Size = new System.Drawing.Size(128, 28);
            this.btnPosOrden.TabIndex = 3;
            this.btnPosOrden.Text = "Pos-Orden";
            this.btnPosOrden.UseVisualStyleBackColor = true;
            this.btnPosOrden.Click += new System.EventHandler(this.btnPosOrden_Click);
            // 
            // btnEntreOrden
            // 
            this.btnEntreOrden.Location = new System.Drawing.Point(17, 70);
            this.btnEntreOrden.Name = "btnEntreOrden";
            this.btnEntreOrden.Size = new System.Drawing.Size(128, 31);
            this.btnEntreOrden.TabIndex = 2;
            this.btnEntreOrden.Text = "Entre-Orden";
            this.btnEntreOrden.UseVisualStyleBackColor = true;
            this.btnEntreOrden.Click += new System.EventHandler(this.btnEntreOrden_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(17, 33);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(128, 31);
            this.btnPreOrden.TabIndex = 1;
            this.btnPreOrden.Text = "Pre-Orden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // txtMostrarArbol
            // 
            this.txtMostrarArbol.Location = new System.Drawing.Point(182, 60);
            this.txtMostrarArbol.Name = "txtMostrarArbol";
            this.txtMostrarArbol.Size = new System.Drawing.Size(308, 23);
            this.txtMostrarArbol.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(272, 89);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 31);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormArbolBinario";
            this.Text = "Arbol Binario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtInsertRaiz;
        private Button btnInsertRaiz;
        private GroupBox groupBox2;
        private TextBox txtHijo;
        private TextBox txtPadre;
        private Label label2;
        private Label label1;
        private Button btnEliminarDer;
        private Button btnInsertDer;
        private Button btnEliminarIzq;
        private Button btnInsertIzq;
        private GroupBox groupBox3;
        private Button btnPosOrden;
        private Button btnEntreOrden;
        private Button btnPreOrden;
        private TextBox txtMostrarArbol;
        private Button btnLimpiar;
    }
}