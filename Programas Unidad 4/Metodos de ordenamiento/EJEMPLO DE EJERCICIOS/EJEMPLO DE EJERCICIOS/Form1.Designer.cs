
namespace EJEMPLO_DE_EJERCICIOS
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
            this.grpNumeroDeDatosAleatorios = new System.Windows.Forms.GroupBox();
            this.txtNumeroDeDatosAleatorios = new System.Windows.Forms.TextBox();
            this.btnGenerarDatosAleatorios = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnOrdenarPorClaveBurbujaDerechaAscendente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrdenarPorClaveQuickSortAscendente = new System.Windows.Forms.Button();
            this.btnOrdenarPorClaveShakerSortAscendente = new System.Windows.Forms.Button();
            this.btnOrdenarPorClaveShellSortAscendente = new System.Windows.Forms.Button();
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente = new System.Windows.Forms.Button();
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente = new System.Windows.Forms.Button();
            this.btnOrdenarPorClaveRadixSortAscendente = new System.Windows.Forms.Button();
            this.grpNumeroDeDatosAleatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNumeroDeDatosAleatorios
            // 
            this.grpNumeroDeDatosAleatorios.Controls.Add(this.txtNumeroDeDatosAleatorios);
            this.grpNumeroDeDatosAleatorios.Controls.Add(this.btnGenerarDatosAleatorios);
            this.grpNumeroDeDatosAleatorios.Location = new System.Drawing.Point(17, 12);
            this.grpNumeroDeDatosAleatorios.Name = "grpNumeroDeDatosAleatorios";
            this.grpNumeroDeDatosAleatorios.Size = new System.Drawing.Size(173, 158);
            this.grpNumeroDeDatosAleatorios.TabIndex = 22;
            this.grpNumeroDeDatosAleatorios.TabStop = false;
            this.grpNumeroDeDatosAleatorios.Text = "Ingresar numero de datos aleatorios";
            // 
            // txtNumeroDeDatosAleatorios
            // 
            this.txtNumeroDeDatosAleatorios.Location = new System.Drawing.Point(16, 58);
            this.txtNumeroDeDatosAleatorios.Name = "txtNumeroDeDatosAleatorios";
            this.txtNumeroDeDatosAleatorios.Size = new System.Drawing.Size(139, 20);
            this.txtNumeroDeDatosAleatorios.TabIndex = 17;
            // 
            // btnGenerarDatosAleatorios
            // 
            this.btnGenerarDatosAleatorios.Location = new System.Drawing.Point(26, 104);
            this.btnGenerarDatosAleatorios.Name = "btnGenerarDatosAleatorios";
            this.btnGenerarDatosAleatorios.Size = new System.Drawing.Size(120, 40);
            this.btnGenerarDatosAleatorios.TabIndex = 16;
            this.btnGenerarDatosAleatorios.Text = "Generar datos aleatorios";
            this.btnGenerarDatosAleatorios.UseVisualStyleBackColor = true;
            this.btnGenerarDatosAleatorios.Click += new System.EventHandler(this.btnGenerarDatosAleatorios_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(213, 12);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(487, 158);
            this.dtgDatos.TabIndex = 23;
            // 
            // btnOrdenarPorClaveBurbujaDerechaAscendente
            // 
            this.btnOrdenarPorClaveBurbujaDerechaAscendente.Location = new System.Drawing.Point(6, 33);
            this.btnOrdenarPorClaveBurbujaDerechaAscendente.Name = "btnOrdenarPorClaveBurbujaDerechaAscendente";
            this.btnOrdenarPorClaveBurbujaDerechaAscendente.Size = new System.Drawing.Size(129, 40);
            this.btnOrdenarPorClaveBurbujaDerechaAscendente.TabIndex = 24;
            this.btnOrdenarPorClaveBurbujaDerechaAscendente.Text = "Ordenar por Clave (Burbuja Derecha)";
            this.btnOrdenarPorClaveBurbujaDerechaAscendente.UseVisualStyleBackColor = true;
            this.btnOrdenarPorClaveBurbujaDerechaAscendente.Click += new System.EventHandler(this.btnOrdenarPorClaveBurbujaDerechaAscendente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrdenarPorClaveRadixSortAscendente);
            this.groupBox1.Controls.Add(this.btnOrdenarPorClaveQuickSortAscendente);
            this.groupBox1.Controls.Add(this.btnOrdenarPorClaveShakerSortAscendente);
            this.groupBox1.Controls.Add(this.btnOrdenarPorClaveShellSortAscendente);
            this.groupBox1.Controls.Add(this.btnOrdenarPorClaveBurbujaConSeñalAscendente);
            this.groupBox1.Controls.Add(this.btnOrdenarPorClaveBurbujaIzquierdaAscendente);
            this.groupBox1.Controls.Add(this.btnOrdenarPorClaveBurbujaDerechaAscendente);
            this.groupBox1.Location = new System.Drawing.Point(17, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 247);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma Ascendente:";
            // 
            // btnOrdenarPorClaveQuickSortAscendente
            // 
            this.btnOrdenarPorClaveQuickSortAscendente.Location = new System.Drawing.Point(153, 125);
            this.btnOrdenarPorClaveQuickSortAscendente.Name = "btnOrdenarPorClaveQuickSortAscendente";
            this.btnOrdenarPorClaveQuickSortAscendente.Size = new System.Drawing.Size(129, 40);
            this.btnOrdenarPorClaveQuickSortAscendente.TabIndex = 30;
            this.btnOrdenarPorClaveQuickSortAscendente.Text = "Ordenar por Clave (Quick Sort)";
            this.btnOrdenarPorClaveQuickSortAscendente.UseVisualStyleBackColor = true;
            this.btnOrdenarPorClaveQuickSortAscendente.Click += new System.EventHandler(this.btnOrdenarPorClaveQuickSortAscendente_Click);
            // 
            // btnOrdenarPorClaveShakerSortAscendente
            // 
            this.btnOrdenarPorClaveShakerSortAscendente.Location = new System.Drawing.Point(6, 125);
            this.btnOrdenarPorClaveShakerSortAscendente.Name = "btnOrdenarPorClaveShakerSortAscendente";
            this.btnOrdenarPorClaveShakerSortAscendente.Size = new System.Drawing.Size(129, 40);
            this.btnOrdenarPorClaveShakerSortAscendente.TabIndex = 29;
            this.btnOrdenarPorClaveShakerSortAscendente.Text = "Ordenar por Clave (Shaker Sort)";
            this.btnOrdenarPorClaveShakerSortAscendente.UseVisualStyleBackColor = true;
            this.btnOrdenarPorClaveShakerSortAscendente.Click += new System.EventHandler(this.btnOrdenarPorClaveShakerSortAscendente_Click);
            // 
            // btnOrdenarPorClaveShellSortAscendente
            // 
            this.btnOrdenarPorClaveShellSortAscendente.Location = new System.Drawing.Point(153, 79);
            this.btnOrdenarPorClaveShellSortAscendente.Name = "btnOrdenarPorClaveShellSortAscendente";
            this.btnOrdenarPorClaveShellSortAscendente.Size = new System.Drawing.Size(129, 40);
            this.btnOrdenarPorClaveShellSortAscendente.TabIndex = 27;
            this.btnOrdenarPorClaveShellSortAscendente.Text = "Ordenar por Clave (Shell Sort)";
            this.btnOrdenarPorClaveShellSortAscendente.UseVisualStyleBackColor = true;
            this.btnOrdenarPorClaveShellSortAscendente.Click += new System.EventHandler(this.btnOrdenarPorClaveShellSortAscendente_Click);
            // 
            // btnOrdenarPorClaveBurbujaConSeñalAscendente
            // 
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente.Location = new System.Drawing.Point(6, 79);
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente.Name = "btnOrdenarPorClaveBurbujaConSeñalAscendente";
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente.Size = new System.Drawing.Size(129, 40);
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente.TabIndex = 26;
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente.Text = "Ordenar por Clave (Burbuja con Señal)";
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente.UseVisualStyleBackColor = true;
            this.btnOrdenarPorClaveBurbujaConSeñalAscendente.Click += new System.EventHandler(this.btnOrdenarPorClaveBurbujaConSeñalAscendente_Click);
            // 
            // btnOrdenarPorClaveBurbujaIzquierdaAscendente
            // 
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente.Location = new System.Drawing.Point(153, 33);
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente.Name = "btnOrdenarPorClaveBurbujaIzquierdaAscendente";
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente.Size = new System.Drawing.Size(129, 40);
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente.TabIndex = 25;
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente.Text = "Ordenar por Clave (Burbuja Izquierda)";
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente.UseVisualStyleBackColor = true;
            this.btnOrdenarPorClaveBurbujaIzquierdaAscendente.Click += new System.EventHandler(this.btnOrdenarPorClaveBurbujaIzquierdaAscendente_Click);
            // 
            // btnOrdenarPorClaveRadixSortAscendente
            // 
            this.btnOrdenarPorClaveRadixSortAscendente.Location = new System.Drawing.Point(85, 181);
            this.btnOrdenarPorClaveRadixSortAscendente.Name = "btnOrdenarPorClaveRadixSortAscendente";
            this.btnOrdenarPorClaveRadixSortAscendente.Size = new System.Drawing.Size(129, 40);
            this.btnOrdenarPorClaveRadixSortAscendente.TabIndex = 31;
            this.btnOrdenarPorClaveRadixSortAscendente.Text = "Ordenar por Clave (Radix Sort)";
            this.btnOrdenarPorClaveRadixSortAscendente.UseVisualStyleBackColor = true;
            this.btnOrdenarPorClaveRadixSortAscendente.Click += new System.EventHandler(this.btnOrdenarPorClaveRadixSortAscendente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.grpNumeroDeDatosAleatorios);
            this.Name = "Form1";
            this.Text = "POSIBLES EJERCICIOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNumeroDeDatosAleatorios.ResumeLayout(false);
            this.grpNumeroDeDatosAleatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNumeroDeDatosAleatorios;
        private System.Windows.Forms.TextBox txtNumeroDeDatosAleatorios;
        private System.Windows.Forms.Button btnGenerarDatosAleatorios;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnOrdenarPorClaveBurbujaDerechaAscendente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenarPorClaveBurbujaIzquierdaAscendente;
        private System.Windows.Forms.Button btnOrdenarPorClaveBurbujaConSeñalAscendente;
        private System.Windows.Forms.Button btnOrdenarPorClaveShellSortAscendente;
        private System.Windows.Forms.Button btnOrdenarPorClaveShakerSortAscendente;
        private System.Windows.Forms.Button btnOrdenarPorClaveQuickSortAscendente;
        private System.Windows.Forms.Button btnOrdenarPorClaveRadixSortAscendente;
    }
}

