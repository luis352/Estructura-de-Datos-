
namespace ShellSort_Estudiantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txrmatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDescendente = new System.Windows.Forms.RadioButton();
            this.radAscendente = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radPorPromedio = new System.Windows.Forms.RadioButton();
            this.radPorGrupo = new System.Windows.Forms.RadioButton();
            this.radPorGrado = new System.Windows.Forms.RadioButton();
            this.radPorNombre = new System.Windows.Forms.RadioButton();
            this.radPorMatricula = new System.Windows.Forms.RadioButton();
            this.dgEstudiantes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPromedio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGrupo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGrado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txrmatricula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPromedio.Location = new System.Drawing.Point(88, 192);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 26);
            this.txtPromedio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Promedio";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGrupo.Location = new System.Drawing.Point(88, 152);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(100, 26);
            this.txtGrupo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grupo";
            // 
            // txtGrado
            // 
            this.txtGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGrado.Location = new System.Drawing.Point(88, 114);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(100, 26);
            this.txtGrado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grado";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(88, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txrmatricula
            // 
            this.txrmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txrmatricula.Location = new System.Drawing.Point(88, 37);
            this.txrmatricula.Name = "txrmatricula";
            this.txrmatricula.Size = new System.Drawing.Size(100, 26);
            this.txrmatricula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInsertar.Location = new System.Drawing.Point(417, 12);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(89, 63);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerar.Location = new System.Drawing.Point(417, 81);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(89, 63);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar al azar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDescendente);
            this.groupBox2.Controls.Add(this.radAscendente);
            this.groupBox2.Location = new System.Drawing.Point(669, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criterio de ordenamiento";
            // 
            // radDescendente
            // 
            this.radDescendente.AutoSize = true;
            this.radDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radDescendente.Location = new System.Drawing.Point(12, 72);
            this.radDescendente.Name = "radDescendente";
            this.radDescendente.Size = new System.Drawing.Size(123, 24);
            this.radDescendente.TabIndex = 1;
            this.radDescendente.Text = "Descendente";
            this.radDescendente.UseVisualStyleBackColor = true;
            // 
            // radAscendente
            // 
            this.radAscendente.AutoSize = true;
            this.radAscendente.Checked = true;
            this.radAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radAscendente.Location = new System.Drawing.Point(12, 32);
            this.radAscendente.Name = "radAscendente";
            this.radAscendente.Size = new System.Drawing.Size(113, 24);
            this.radAscendente.TabIndex = 0;
            this.radAscendente.TabStop = true;
            this.radAscendente.Text = "Ascendente";
            this.radAscendente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOrdenar.Location = new System.Drawing.Point(822, 12);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(89, 114);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radPorPromedio);
            this.groupBox3.Controls.Add(this.radPorGrupo);
            this.groupBox3.Controls.Add(this.radPorGrado);
            this.groupBox3.Controls.Add(this.radPorNombre);
            this.groupBox3.Controls.Add(this.radPorMatricula);
            this.groupBox3.Location = new System.Drawing.Point(512, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 218);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenar por";
            // 
            // radPorPromedio
            // 
            this.radPorPromedio.AutoSize = true;
            this.radPorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radPorPromedio.Location = new System.Drawing.Point(6, 176);
            this.radPorPromedio.Name = "radPorPromedio";
            this.radPorPromedio.Size = new System.Drawing.Size(94, 24);
            this.radPorPromedio.TabIndex = 4;
            this.radPorPromedio.Text = "Promedio";
            this.radPorPromedio.UseVisualStyleBackColor = true;
            // 
            // radPorGrupo
            // 
            this.radPorGrupo.AutoSize = true;
            this.radPorGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radPorGrupo.Location = new System.Drawing.Point(6, 139);
            this.radPorGrupo.Name = "radPorGrupo";
            this.radPorGrupo.Size = new System.Drawing.Size(72, 24);
            this.radPorGrupo.TabIndex = 3;
            this.radPorGrupo.Text = "Grupo";
            this.radPorGrupo.UseVisualStyleBackColor = true;
            // 
            // radPorGrado
            // 
            this.radPorGrado.AutoSize = true;
            this.radPorGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radPorGrado.Location = new System.Drawing.Point(6, 103);
            this.radPorGrado.Name = "radPorGrado";
            this.radPorGrado.Size = new System.Drawing.Size(72, 24);
            this.radPorGrado.TabIndex = 2;
            this.radPorGrado.Text = "Grado";
            this.radPorGrado.UseVisualStyleBackColor = true;
            // 
            // radPorNombre
            // 
            this.radPorNombre.AutoSize = true;
            this.radPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radPorNombre.Location = new System.Drawing.Point(6, 69);
            this.radPorNombre.Name = "radPorNombre";
            this.radPorNombre.Size = new System.Drawing.Size(83, 24);
            this.radPorNombre.TabIndex = 1;
            this.radPorNombre.Text = "Nombre";
            this.radPorNombre.UseVisualStyleBackColor = true;
            // 
            // radPorMatricula
            // 
            this.radPorMatricula.AutoSize = true;
            this.radPorMatricula.Checked = true;
            this.radPorMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radPorMatricula.Location = new System.Drawing.Point(6, 29);
            this.radPorMatricula.Name = "radPorMatricula";
            this.radPorMatricula.Size = new System.Drawing.Size(91, 24);
            this.radPorMatricula.TabIndex = 0;
            this.radPorMatricula.TabStop = true;
            this.radPorMatricula.Text = "Matricula";
            this.radPorMatricula.UseVisualStyleBackColor = true;
            // 
            // dgEstudiantes
            // 
            this.dgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgEstudiantes.Location = new System.Drawing.Point(12, 255);
            this.dgEstudiantes.Name = "dgEstudiantes";
            this.dgEstudiantes.Size = new System.Drawing.Size(899, 311);
            this.dgEstudiantes.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Matricula";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Grado";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Grupo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Promedio";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 578);
            this.Controls.Add(this.dgEstudiantes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txrmatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radDescendente;
        private System.Windows.Forms.RadioButton radAscendente;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radPorPromedio;
        private System.Windows.Forms.RadioButton radPorGrupo;
        private System.Windows.Forms.RadioButton radPorGrado;
        private System.Windows.Forms.RadioButton radPorNombre;
        private System.Windows.Forms.RadioButton radPorMatricula;
        private System.Windows.Forms.DataGridView dgEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

