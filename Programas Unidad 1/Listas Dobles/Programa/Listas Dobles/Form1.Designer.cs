namespace Listas_Dobles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cboincialpedido = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artificial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpoTamaño = new System.Windows.Forms.GroupBox();
            this.rbtmediano = new System.Windows.Forms.RadioButton();
            this.rbtchico = new System.Windows.Forms.RadioButton();
            this.rbtgrande = new System.Windows.Forms.RadioButton();
            this.btnGenerarDatos = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chbArtificial = new System.Windows.Forms.CheckBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnumeroventa = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblInicialPedido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.gpbRecorrido = new System.Windows.Forms.GroupBox();
            this.rbtatras = new System.Windows.Forms.RadioButton();
            this.rbtadelante = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpoTamaño.SuspendLayout();
            this.gpbRecorrido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(731, 188);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(89, 23);
            this.btnVaciar.TabIndex = 46;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(731, 230);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 23);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(731, 148);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(731, 261);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 23);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(526, 83);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(184, 154);
            this.picFoto.TabIndex = 42;
            this.picFoto.TabStop = false;
            // 
            // cboincialpedido
            // 
            this.cboincialpedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboincialpedido.FormattingEnabled = true;
            this.cboincialpedido.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboincialpedido.Location = new System.Drawing.Point(177, 165);
            this.cboincialpedido.Name = "cboincialpedido";
            this.cboincialpedido.Size = new System.Drawing.Size(55, 21);
            this.cboincialpedido.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nventa,
            this.precio,
            this.nombre,
            this.pedido,
            this.fecha,
            this.Artificial,
            this.domicilio});
            this.dataGridView1.Location = new System.Drawing.Point(57, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Nventa
            // 
            this.Nventa.HeaderText = "Numero de Venta";
            this.Nventa.Name = "Nventa";
            this.Nventa.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // pedido
            // 
            this.pedido.HeaderText = "Inicial de pedido";
            this.pedido.Name = "pedido";
            this.pedido.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Artificial
            // 
            this.Artificial.HeaderText = "¿Es Artificial? ";
            this.Artificial.Name = "Artificial";
            this.Artificial.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Tamaño ";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // gpoTamaño
            // 
            this.gpoTamaño.Controls.Add(this.rbtmediano);
            this.gpoTamaño.Controls.Add(this.rbtchico);
            this.gpoTamaño.Controls.Add(this.rbtgrande);
            this.gpoTamaño.Location = new System.Drawing.Point(381, 76);
            this.gpoTamaño.Name = "gpoTamaño";
            this.gpoTamaño.Size = new System.Drawing.Size(116, 85);
            this.gpoTamaño.TabIndex = 39;
            this.gpoTamaño.TabStop = false;
            this.gpoTamaño.Text = "Tamaño del arreglo ";
            // 
            // rbtmediano
            // 
            this.rbtmediano.AutoSize = true;
            this.rbtmediano.Location = new System.Drawing.Point(17, 42);
            this.rbtmediano.Name = "rbtmediano";
            this.rbtmediano.Size = new System.Drawing.Size(66, 17);
            this.rbtmediano.TabIndex = 18;
            this.rbtmediano.Text = "Mediano";
            this.rbtmediano.UseVisualStyleBackColor = true;
            // 
            // rbtchico
            // 
            this.rbtchico.AutoSize = true;
            this.rbtchico.Checked = true;
            this.rbtchico.Location = new System.Drawing.Point(17, 19);
            this.rbtchico.Name = "rbtchico";
            this.rbtchico.Size = new System.Drawing.Size(52, 17);
            this.rbtchico.TabIndex = 16;
            this.rbtchico.TabStop = true;
            this.rbtchico.Text = "Chico";
            this.rbtchico.UseVisualStyleBackColor = true;
            // 
            // rbtgrande
            // 
            this.rbtgrande.AutoSize = true;
            this.rbtgrande.Location = new System.Drawing.Point(17, 65);
            this.rbtgrande.Name = "rbtgrande";
            this.rbtgrande.Size = new System.Drawing.Size(60, 17);
            this.rbtgrande.TabIndex = 17;
            this.rbtgrande.Text = "Grande";
            this.rbtgrande.UseVisualStyleBackColor = true;
            // 
            // btnGenerarDatos
            // 
            this.btnGenerarDatos.Location = new System.Drawing.Point(731, 98);
            this.btnGenerarDatos.Name = "btnGenerarDatos";
            this.btnGenerarDatos.Size = new System.Drawing.Size(89, 36);
            this.btnGenerarDatos.TabIndex = 38;
            this.btnGenerarDatos.Text = "Generar datos aleatorios ";
            this.btnGenerarDatos.UseVisualStyleBackColor = true;
            this.btnGenerarDatos.Click += new System.EventHandler(this.btnGenerarDatos_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(504, 261);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(216, 23);
            this.btnCargarImagen.TabIndex = 37;
            this.btnCargarImagen.Text = "Cargar Imagen ";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(731, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 32);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chbArtificial
            // 
            this.chbArtificial.AutoSize = true;
            this.chbArtificial.Location = new System.Drawing.Point(288, 271);
            this.chbArtificial.Name = "chbArtificial";
            this.chbArtificial.Size = new System.Drawing.Size(89, 17);
            this.chbArtificial.TabIndex = 35;
            this.chbArtificial.Text = "¿Es Artificial?";
            this.chbArtificial.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(152, 117);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 34;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(152, 76);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 33;
            // 
            // txtnumeroventa
            // 
            this.txtnumeroventa.Location = new System.Drawing.Point(166, 268);
            this.txtnumeroventa.Name = "txtnumeroventa";
            this.txtnumeroventa.Size = new System.Drawing.Size(100, 20);
            this.txtnumeroventa.TabIndex = 32;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(68, 219);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // lblInicialPedido
            // 
            this.lblInicialPedido.AutoSize = true;
            this.lblInicialPedido.Location = new System.Drawing.Point(68, 168);
            this.lblInicialPedido.Name = "lblInicialPedido";
            this.lblInicialPedido.Size = new System.Drawing.Size(84, 13);
            this.lblInicialPedido.TabIndex = 29;
            this.lblInicialPedido.Text = "Inicial de pedido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(68, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(75, 76);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Location = new System.Drawing.Point(68, 271);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(92, 13);
            this.lblNumeroVenta.TabIndex = 26;
            this.lblNumeroVenta.Text = "Numero De Venta";
            // 
            // gpbRecorrido
            // 
            this.gpbRecorrido.Controls.Add(this.rbtatras);
            this.gpbRecorrido.Controls.Add(this.rbtadelante);
            this.gpbRecorrido.Location = new System.Drawing.Point(383, 183);
            this.gpbRecorrido.Name = "gpbRecorrido";
            this.gpbRecorrido.Size = new System.Drawing.Size(114, 118);
            this.gpbRecorrido.TabIndex = 47;
            this.gpbRecorrido.TabStop = false;
            this.gpbRecorrido.Text = "Tipo de recorrido";
            // 
            // rbtatras
            // 
            this.rbtatras.AutoSize = true;
            this.rbtatras.Location = new System.Drawing.Point(15, 60);
            this.rbtatras.Name = "rbtatras";
            this.rbtatras.Size = new System.Drawing.Size(79, 17);
            this.rbtatras.TabIndex = 1;
            this.rbtatras.TabStop = true;
            this.rbtatras.Text = "Hacia atras";
            this.rbtatras.UseVisualStyleBackColor = true;
            this.rbtatras.CheckedChanged += new System.EventHandler(this.rbtatras_CheckedChanged);
            // 
            // rbtadelante
            // 
            this.rbtadelante.AutoSize = true;
            this.rbtadelante.Checked = true;
            this.rbtadelante.Location = new System.Drawing.Point(15, 36);
            this.rbtadelante.Name = "rbtadelante";
            this.rbtadelante.Size = new System.Drawing.Size(98, 17);
            this.rbtadelante.TabIndex = 0;
            this.rbtadelante.TabStop = true;
            this.rbtadelante.Text = "Hacia Adelante";
            this.rbtadelante.UseVisualStyleBackColor = true;
            this.rbtadelante.CheckedChanged += new System.EventHandler(this.rbtadelante_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 504);
            this.Controls.Add(this.gpbRecorrido);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.cboincialpedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpoTamaño);
            this.Controls.Add(this.btnGenerarDatos);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chbArtificial);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnumeroventa);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblInicialPedido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNumeroVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpoTamaño.ResumeLayout(false);
            this.gpoTamaño.PerformLayout();
            this.gpbRecorrido.ResumeLayout(false);
            this.gpbRecorrido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cboincialpedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artificial;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.GroupBox gpoTamaño;
        private System.Windows.Forms.RadioButton rbtmediano;
        private System.Windows.Forms.RadioButton rbtchico;
        private System.Windows.Forms.RadioButton rbtgrande;
        private System.Windows.Forms.Button btnGenerarDatos;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chbArtificial;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnumeroventa;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblInicialPedido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.GroupBox gpbRecorrido;
        private System.Windows.Forms.RadioButton rbtatras;
        private System.Windows.Forms.RadioButton rbtadelante;
    }
}

