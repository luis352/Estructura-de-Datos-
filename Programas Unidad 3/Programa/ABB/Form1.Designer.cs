namespace ABB
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
            this.BtnAgregarNodo = new System.Windows.Forms.Button();
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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbtiporecorido = new System.Windows.Forms.GroupBox();
            this.rbtrecorrerposorden = new System.Windows.Forms.RadioButton();
            this.rbtrecorrerIorden = new System.Windows.Forms.RadioButton();
            this.rbtpreorden = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpoTamaño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbtiporecorido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(693, 156);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(89, 23);
            this.btnVaciar.TabIndex = 88;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(693, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 23);
            this.btnBuscar.TabIndex = 87;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(693, 87);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 23);
            this.btnEliminar.TabIndex = 86;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(488, 56);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(184, 154);
            this.picFoto.TabIndex = 85;
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
            this.cboincialpedido.Location = new System.Drawing.Point(139, 156);
            this.cboincialpedido.Name = "cboincialpedido";
            this.cboincialpedido.Size = new System.Drawing.Size(55, 21);
            this.cboincialpedido.TabIndex = 84;
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 353);
            this.dataGridView1.TabIndex = 83;
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
            this.gpoTamaño.Location = new System.Drawing.Point(343, 74);
            this.gpoTamaño.Name = "gpoTamaño";
            this.gpoTamaño.Size = new System.Drawing.Size(117, 95);
            this.gpoTamaño.TabIndex = 82;
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
            this.rbtmediano.TabStop = true;
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
            this.rbtgrande.TabStop = true;
            this.rbtgrande.Text = "Grande";
            this.rbtgrande.UseVisualStyleBackColor = true;
            // 
            // btnGenerarDatos
            // 
            this.btnGenerarDatos.Location = new System.Drawing.Point(693, 40);
            this.btnGenerarDatos.Name = "btnGenerarDatos";
            this.btnGenerarDatos.Size = new System.Drawing.Size(89, 36);
            this.btnGenerarDatos.TabIndex = 81;
            this.btnGenerarDatos.Text = "Generar datos aleatorios ";
            this.btnGenerarDatos.UseVisualStyleBackColor = true;
            this.btnGenerarDatos.Click += new System.EventHandler(this.btnGenerarDatos_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(488, 234);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(184, 23);
            this.btnCargarImagen.TabIndex = 80;
            this.btnCargarImagen.Text = "Cargar Imagen ";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // BtnAgregarNodo
            // 
            this.BtnAgregarNodo.Location = new System.Drawing.Point(693, 2);
            this.BtnAgregarNodo.Name = "BtnAgregarNodo";
            this.BtnAgregarNodo.Size = new System.Drawing.Size(89, 32);
            this.BtnAgregarNodo.TabIndex = 79;
            this.BtnAgregarNodo.Text = "Agregar";
            this.BtnAgregarNodo.UseVisualStyleBackColor = true;
            this.BtnAgregarNodo.Click += new System.EventHandler(this.BtnAgregarNodo_Click);
            // 
            // chbArtificial
            // 
            this.chbArtificial.AutoSize = true;
            this.chbArtificial.Location = new System.Drawing.Point(355, 48);
            this.chbArtificial.Name = "chbArtificial";
            this.chbArtificial.Size = new System.Drawing.Size(89, 17);
            this.chbArtificial.TabIndex = 78;
            this.chbArtificial.Text = "¿Es Artificial?";
            this.chbArtificial.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(139, 114);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 77;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(139, 52);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 76;
            // 
            // txtnumeroventa
            // 
            this.txtnumeroventa.Location = new System.Drawing.Point(152, 241);
            this.txtnumeroventa.Name = "txtnumeroventa";
            this.txtnumeroventa.Size = new System.Drawing.Size(100, 20);
            this.txtnumeroventa.TabIndex = 75;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(44, 213);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 74;
            this.lblFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // lblInicialPedido
            // 
            this.lblInicialPedido.AutoSize = true;
            this.lblInicialPedido.Location = new System.Drawing.Point(37, 171);
            this.lblInicialPedido.Name = "lblInicialPedido";
            this.lblInicialPedido.Size = new System.Drawing.Size(84, 13);
            this.lblInicialPedido.TabIndex = 72;
            this.lblInicialPedido.Text = "Inicial de pedido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 71;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(37, 59);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 70;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Location = new System.Drawing.Point(44, 244);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(92, 13);
            this.lblNumeroVenta.TabIndex = 69;
            this.lblNumeroVenta.Text = "Numero De Venta";
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(693, 187);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(89, 32);
            this.btnDibujar.TabIndex = 89;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(693, 227);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(89, 34);
            this.btnRecorrer.TabIndex = 90;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(797, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 616);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // gpbtiporecorido
            // 
            this.gpbtiporecorido.Controls.Add(this.rbtrecorrerposorden);
            this.gpbtiporecorido.Controls.Add(this.rbtrecorrerIorden);
            this.gpbtiporecorido.Controls.Add(this.rbtpreorden);
            this.gpbtiporecorido.Location = new System.Drawing.Point(343, 175);
            this.gpbtiporecorido.Name = "gpbtiporecorido";
            this.gpbtiporecorido.Size = new System.Drawing.Size(126, 94);
            this.gpbtiporecorido.TabIndex = 92;
            this.gpbtiporecorido.TabStop = false;
            this.gpbtiporecorido.Text = "Tipo de recorido ";
            // 
            // rbtrecorrerposorden
            // 
            this.rbtrecorrerposorden.AutoSize = true;
            this.rbtrecorrerposorden.Location = new System.Drawing.Point(7, 70);
            this.rbtrecorrerposorden.Name = "rbtrecorrerposorden";
            this.rbtrecorrerposorden.Size = new System.Drawing.Size(116, 17);
            this.rbtrecorrerposorden.TabIndex = 2;
            this.rbtrecorrerposorden.TabStop = true;
            this.rbtrecorrerposorden.Text = "Recorrer PosOrden";
            this.rbtrecorrerposorden.UseVisualStyleBackColor = true;
            this.rbtrecorrerposorden.CheckedChanged += new System.EventHandler(this.rbtrecorrerposorden_CheckedChanged);
            // 
            // rbtrecorrerIorden
            // 
            this.rbtrecorrerIorden.AutoSize = true;
            this.rbtrecorrerIorden.Location = new System.Drawing.Point(7, 47);
            this.rbtrecorrerIorden.Name = "rbtrecorrerIorden";
            this.rbtrecorrerIorden.Size = new System.Drawing.Size(106, 17);
            this.rbtrecorrerIorden.TabIndex = 1;
            this.rbtrecorrerIorden.TabStop = true;
            this.rbtrecorrerIorden.Text = "Recorrer  iOrden ";
            this.rbtrecorrerIorden.UseVisualStyleBackColor = true;
            this.rbtrecorrerIorden.CheckedChanged += new System.EventHandler(this.rbtrecorrerIorden_CheckedChanged);
            // 
            // rbtpreorden
            // 
            this.rbtpreorden.AutoSize = true;
            this.rbtpreorden.Location = new System.Drawing.Point(7, 20);
            this.rbtpreorden.Name = "rbtpreorden";
            this.rbtpreorden.Size = new System.Drawing.Size(114, 17);
            this.rbtpreorden.TabIndex = 0;
            this.rbtpreorden.TabStop = true;
            this.rbtpreorden.Text = "Recorrer PreOrden";
            this.rbtpreorden.UseVisualStyleBackColor = true;
            this.rbtpreorden.CheckedChanged += new System.EventHandler(this.rbtpreorden_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 640);
            this.Controls.Add(this.gpbtiporecorido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.cboincialpedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpoTamaño);
            this.Controls.Add(this.btnGenerarDatos);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.BtnAgregarNodo);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbtiporecorido.ResumeLayout(false);
            this.gpbtiporecorido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
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
        private System.Windows.Forms.Button BtnAgregarNodo;
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
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbtiporecorido;
        private System.Windows.Forms.RadioButton rbtrecorrerposorden;
        private System.Windows.Forms.RadioButton rbtrecorrerIorden;
        private System.Windows.Forms.RadioButton rbtpreorden;
    }
}

