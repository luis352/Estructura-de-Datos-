
namespace METODO_FROMAS_1
{
    partial class Form1
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
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDatosAleatorios = new System.Windows.Forms.Button();
            this.dtgListas = new System.Windows.Forms.DataGridView();
            this.dtgListasOrdenada = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.gpbOrdenarPor = new System.Windows.Forms.GroupBox();
            this.radMateria = new System.Windows.Forms.RadioButton();
            this.radSueldo = new System.Windows.Forms.RadioButton();
            this.radMatricula = new System.Windows.Forms.RadioButton();
            this.gpbCriterioOrden = new System.Windows.Forms.GroupBox();
            this.radDescendente = new System.Windows.Forms.RadioButton();
            this.radAcendente = new System.Windows.Forms.RadioButton();
            this.gpbTipoOrdenamiento = new System.Windows.Forms.GroupBox();
            this.btnShakerSort = new System.Windows.Forms.Button();
            this.btnBurbujaIzq = new System.Windows.Forms.Button();
            this.btnBurbujaDer = new System.Windows.Forms.Button();
            this.btnBurbujaSeñal = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.btnSeleccionDirecta = new System.Windows.Forms.Button();
            this.btnInsercionDirecta = new System.Windows.Forms.Button();
            this.btnInsertBinaria = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListasOrdenada)).BeginInit();
            this.gpbOrdenarPor.SuspendLayout();
            this.gpbCriterioOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txtSueldo);
            this.gpbDatos.Controls.Add(this.lblSueldo);
            this.gpbDatos.Controls.Add(this.cboMaterias);
            this.gpbDatos.Controls.Add(this.lblMateria);
            this.gpbDatos.Controls.Add(this.txtMatricula);
            this.gpbDatos.Controls.Add(this.lblMatricula);
            this.gpbDatos.Location = new System.Drawing.Point(27, 17);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDatos.Size = new System.Drawing.Size(191, 148);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos del Maestro";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(69, 58);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(112, 23);
            this.txtSueldo.TabIndex = 11;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(7, 61);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 15);
            this.lblSueldo.TabIndex = 10;
            this.lblSueldo.Text = "Sueldo";
            // 
            // cboMaterias
            // 
            this.cboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Items.AddRange(new object[] {
            "Programacion",
            "Ingles",
            "Etica",
            "Matematicas",
            "Español",
            "Historia"});
            this.cboMaterias.Location = new System.Drawing.Point(69, 88);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(112, 23);
            this.cboMaterias.TabIndex = 9;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(6, 91);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(47, 15);
            this.lblMateria.TabIndex = 8;
            this.lblMateria.Text = "Materia";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(70, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(112, 23);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(7, 33);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(57, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(224, 142);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDatosAleatorios
            // 
            this.btnDatosAleatorios.Location = new System.Drawing.Point(224, 26);
            this.btnDatosAleatorios.Name = "btnDatosAleatorios";
            this.btnDatosAleatorios.Size = new System.Drawing.Size(94, 52);
            this.btnDatosAleatorios.TabIndex = 3;
            this.btnDatosAleatorios.Text = "Generar Datos Aleatorios";
            this.btnDatosAleatorios.UseVisualStyleBackColor = true;
            this.btnDatosAleatorios.Click += new System.EventHandler(this.btnDatosAleatorios_Click);
            // 
            // dtgListas
            // 
            this.dtgListas.AllowUserToAddRows = false;
            this.dtgListas.AllowUserToDeleteRows = false;
            this.dtgListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListas.Location = new System.Drawing.Point(12, 192);
            this.dtgListas.Name = "dtgListas";
            this.dtgListas.ReadOnly = true;
            this.dtgListas.RowHeadersWidth = 51;
            this.dtgListas.RowTemplate.Height = 25;
            this.dtgListas.Size = new System.Drawing.Size(424, 251);
            this.dtgListas.TabIndex = 5;
            // 
            // dtgListasOrdenada
            // 
            this.dtgListasOrdenada.AllowUserToAddRows = false;
            this.dtgListasOrdenada.AllowUserToDeleteRows = false;
            this.dtgListasOrdenada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListasOrdenada.Location = new System.Drawing.Point(442, 192);
            this.dtgListasOrdenada.Name = "dtgListasOrdenada";
            this.dtgListasOrdenada.ReadOnly = true;
            this.dtgListasOrdenada.RowHeadersWidth = 51;
            this.dtgListasOrdenada.RowTemplate.Height = 25;
            this.dtgListasOrdenada.Size = new System.Drawing.Size(424, 251);
            this.dtgListasOrdenada.TabIndex = 6;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(224, 96);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(94, 27);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // gpbOrdenarPor
            // 
            this.gpbOrdenarPor.Controls.Add(this.radMateria);
            this.gpbOrdenarPor.Controls.Add(this.radSueldo);
            this.gpbOrdenarPor.Controls.Add(this.radMatricula);
            this.gpbOrdenarPor.Location = new System.Drawing.Point(340, 10);
            this.gpbOrdenarPor.Name = "gpbOrdenarPor";
            this.gpbOrdenarPor.Size = new System.Drawing.Size(103, 101);
            this.gpbOrdenarPor.TabIndex = 8;
            this.gpbOrdenarPor.TabStop = false;
            this.gpbOrdenarPor.Text = "Ordenar Por:";
            // 
            // radMateria
            // 
            this.radMateria.AutoSize = true;
            this.radMateria.Location = new System.Drawing.Point(7, 75);
            this.radMateria.Name = "radMateria";
            this.radMateria.Size = new System.Drawing.Size(65, 19);
            this.radMateria.TabIndex = 2;
            this.radMateria.TabStop = true;
            this.radMateria.Text = "Materia";
            this.radMateria.UseVisualStyleBackColor = true;
            // 
            // radSueldo
            // 
            this.radSueldo.AutoSize = true;
            this.radSueldo.Location = new System.Drawing.Point(7, 49);
            this.radSueldo.Name = "radSueldo";
            this.radSueldo.Size = new System.Drawing.Size(61, 19);
            this.radSueldo.TabIndex = 1;
            this.radSueldo.TabStop = true;
            this.radSueldo.Text = "Sueldo";
            this.radSueldo.UseVisualStyleBackColor = true;
            // 
            // radMatricula
            // 
            this.radMatricula.AutoSize = true;
            this.radMatricula.Location = new System.Drawing.Point(7, 23);
            this.radMatricula.Name = "radMatricula";
            this.radMatricula.Size = new System.Drawing.Size(75, 19);
            this.radMatricula.TabIndex = 0;
            this.radMatricula.TabStop = true;
            this.radMatricula.Text = "Matricula";
            this.radMatricula.UseVisualStyleBackColor = true;
            // 
            // gpbCriterioOrden
            // 
            this.gpbCriterioOrden.Controls.Add(this.radDescendente);
            this.gpbCriterioOrden.Controls.Add(this.radAcendente);
            this.gpbCriterioOrden.Location = new System.Drawing.Point(340, 110);
            this.gpbCriterioOrden.Name = "gpbCriterioOrden";
            this.gpbCriterioOrden.Size = new System.Drawing.Size(162, 76);
            this.gpbCriterioOrden.TabIndex = 9;
            this.gpbCriterioOrden.TabStop = false;
            this.gpbCriterioOrden.Text = "Criterio de Ordenamiento";
            // 
            // radDescendente
            // 
            this.radDescendente.AutoSize = true;
            this.radDescendente.Location = new System.Drawing.Point(7, 49);
            this.radDescendente.Name = "radDescendente";
            this.radDescendente.Size = new System.Drawing.Size(93, 19);
            this.radDescendente.TabIndex = 1;
            this.radDescendente.TabStop = true;
            this.radDescendente.Text = "Descendente";
            this.radDescendente.UseVisualStyleBackColor = true;
            // 
            // radAcendente
            // 
            this.radAcendente.AutoSize = true;
            this.radAcendente.Location = new System.Drawing.Point(7, 23);
            this.radAcendente.Name = "radAcendente";
            this.radAcendente.Size = new System.Drawing.Size(87, 19);
            this.radAcendente.TabIndex = 0;
            this.radAcendente.TabStop = true;
            this.radAcendente.Text = "Ascendente";
            this.radAcendente.UseVisualStyleBackColor = true;
            // 
            // gpbTipoOrdenamiento
            // 
            this.gpbTipoOrdenamiento.Location = new System.Drawing.Point(872, 17);
            this.gpbTipoOrdenamiento.Name = "gpbTipoOrdenamiento";
            this.gpbTipoOrdenamiento.Size = new System.Drawing.Size(244, 426);
            this.gpbTipoOrdenamiento.TabIndex = 10;
            this.gpbTipoOrdenamiento.TabStop = false;
            this.gpbTipoOrdenamiento.Text = "Tipo de Ordenamiento";
            // 
            // btnShakerSort
            // 
            this.btnShakerSort.Location = new System.Drawing.Point(549, 17);
            this.btnShakerSort.Name = "btnShakerSort";
            this.btnShakerSort.Size = new System.Drawing.Size(94, 27);
            this.btnShakerSort.TabIndex = 11;
            this.btnShakerSort.Text = "ShakerSort";
            this.btnShakerSort.UseVisualStyleBackColor = true;
            this.btnShakerSort.Click += new System.EventHandler(this.btnShakerSort_Click);
            // 
            // btnBurbujaIzq
            // 
            this.btnBurbujaIzq.Location = new System.Drawing.Point(449, 17);
            this.btnBurbujaIzq.Name = "btnBurbujaIzq";
            this.btnBurbujaIzq.Size = new System.Drawing.Size(94, 27);
            this.btnBurbujaIzq.TabIndex = 12;
            this.btnBurbujaIzq.Text = "Burbuja Izq";
            this.btnBurbujaIzq.UseVisualStyleBackColor = true;
            this.btnBurbujaIzq.Click += new System.EventHandler(this.btnBurbujaIzq_Click);
            // 
            // btnBurbujaDer
            // 
            this.btnBurbujaDer.Location = new System.Drawing.Point(449, 47);
            this.btnBurbujaDer.Name = "btnBurbujaDer";
            this.btnBurbujaDer.Size = new System.Drawing.Size(94, 27);
            this.btnBurbujaDer.TabIndex = 13;
            this.btnBurbujaDer.Text = "Burbuja Der";
            this.btnBurbujaDer.UseVisualStyleBackColor = true;
            this.btnBurbujaDer.Click += new System.EventHandler(this.btnBurbujaDer_Click);
            // 
            // btnBurbujaSeñal
            // 
            this.btnBurbujaSeñal.Location = new System.Drawing.Point(449, 77);
            this.btnBurbujaSeñal.Name = "btnBurbujaSeñal";
            this.btnBurbujaSeñal.Size = new System.Drawing.Size(94, 27);
            this.btnBurbujaSeñal.TabIndex = 14;
            this.btnBurbujaSeñal.Text = "Burbuja Señal";
            this.btnBurbujaSeñal.UseVisualStyleBackColor = true;
            this.btnBurbujaSeñal.Click += new System.EventHandler(this.btnBurbujaSeñal_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(549, 47);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(94, 27);
            this.btnQuickSort.TabIndex = 15;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(549, 77);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(94, 27);
            this.btnShellSort.TabIndex = 16;
            this.btnShellSort.Text = "ShellSort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(649, 17);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(94, 27);
            this.btnRadix.TabIndex = 17;
            this.btnRadix.Text = "Radix";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // btnSeleccionDirecta
            // 
            this.btnSeleccionDirecta.Location = new System.Drawing.Point(649, 47);
            this.btnSeleccionDirecta.Name = "btnSeleccionDirecta";
            this.btnSeleccionDirecta.Size = new System.Drawing.Size(94, 27);
            this.btnSeleccionDirecta.TabIndex = 18;
            this.btnSeleccionDirecta.Text = "Selec Directa";
            this.btnSeleccionDirecta.UseVisualStyleBackColor = true;
            this.btnSeleccionDirecta.Click += new System.EventHandler(this.btnSeleccionDirecta_Click);
            // 
            // btnInsercionDirecta
            // 
            this.btnInsercionDirecta.Location = new System.Drawing.Point(649, 78);
            this.btnInsercionDirecta.Name = "btnInsercionDirecta";
            this.btnInsercionDirecta.Size = new System.Drawing.Size(94, 27);
            this.btnInsercionDirecta.TabIndex = 19;
            this.btnInsercionDirecta.Text = "Incert Directa";
            this.btnInsercionDirecta.UseVisualStyleBackColor = true;
            this.btnInsercionDirecta.Click += new System.EventHandler(this.btnInsercionDirecta_Click);
            // 
            // btnInsertBinaria
            // 
            this.btnInsertBinaria.Location = new System.Drawing.Point(749, 17);
            this.btnInsertBinaria.Name = "btnInsertBinaria";
            this.btnInsertBinaria.Size = new System.Drawing.Size(94, 27);
            this.btnInsertBinaria.TabIndex = 20;
            this.btnInsertBinaria.Text = "Incert Binaria";
            this.btnInsertBinaria.UseVisualStyleBackColor = true;
            this.btnInsertBinaria.Click += new System.EventHandler(this.btnInsertBinaria_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(749, 50);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(94, 27);
            this.btnHeapSort.TabIndex = 21;
            this.btnHeapSort.Text = "HeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1120, 455);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnInsertBinaria);
            this.Controls.Add(this.btnInsercionDirecta);
            this.Controls.Add(this.btnSeleccionDirecta);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnBurbujaSeñal);
            this.Controls.Add(this.btnBurbujaDer);
            this.Controls.Add(this.btnBurbujaIzq);
            this.Controls.Add(this.btnShakerSort);
            this.Controls.Add(this.gpbTipoOrdenamiento);
            this.Controls.Add(this.gpbCriterioOrden);
            this.Controls.Add(this.gpbOrdenarPor);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dtgListasOrdenada);
            this.Controls.Add(this.dtgListas);
            this.Controls.Add(this.btnDatosAleatorios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListasOrdenada)).EndInit();
            this.gpbOrdenarPor.ResumeLayout(false);
            this.gpbOrdenarPor.PerformLayout();
            this.gpbCriterioOrden.ResumeLayout(false);
            this.gpbCriterioOrden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDatosAleatorios;
        private System.Windows.Forms.DataGridView dtgListas;
        private System.Windows.Forms.DataGridView dtgListasOrdenada;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox gpbOrdenarPor;
        private System.Windows.Forms.RadioButton radMateria;
        private System.Windows.Forms.RadioButton radSueldo;
        private System.Windows.Forms.RadioButton radMatricula;
        private System.Windows.Forms.GroupBox gpbCriterioOrden;
        private System.Windows.Forms.RadioButton radDescendente;
        private System.Windows.Forms.RadioButton radAcendente;
        private System.Windows.Forms.GroupBox gpbTipoOrdenamiento;
        private System.Windows.Forms.Button btnShakerSort;
        private System.Windows.Forms.Button btnBurbujaIzq;
        private System.Windows.Forms.Button btnBurbujaDer;
        private System.Windows.Forms.Button btnBurbujaSeñal;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.Button btnSeleccionDirecta;
        private System.Windows.Forms.Button btnInsercionDirecta;
        private System.Windows.Forms.Button btnInsertBinaria;
        private System.Windows.Forms.Button btnHeapSort;
    }
}

