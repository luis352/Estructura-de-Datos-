namespace Examen_4
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
            this.btnaleatorios = new System.Windows.Forms.Button();
            this.gpbcriterioordenamiento = new System.Windows.Forms.GroupBox();
            this.rbtadecendente = new System.Windows.Forms.RadioButton();
            this.rbtAcendente = new System.Windows.Forms.RadioButton();
            this.btnmetodoordenamiento = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadatos = new System.Windows.Forms.DataGridView();
            this.gpbcriterioordenamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaleatorios
            // 
            this.btnaleatorios.Location = new System.Drawing.Point(54, 12);
            this.btnaleatorios.Name = "btnaleatorios";
            this.btnaleatorios.Size = new System.Drawing.Size(144, 41);
            this.btnaleatorios.TabIndex = 0;
            this.btnaleatorios.Text = "Generar Aletorios ";
            this.btnaleatorios.UseVisualStyleBackColor = true;
            this.btnaleatorios.Click += new System.EventHandler(this.btnaleatorios_Click);
            // 
            // gpbcriterioordenamiento
            // 
            this.gpbcriterioordenamiento.Controls.Add(this.rbtadecendente);
            this.gpbcriterioordenamiento.Controls.Add(this.rbtAcendente);
            this.gpbcriterioordenamiento.Location = new System.Drawing.Point(54, 59);
            this.gpbcriterioordenamiento.Name = "gpbcriterioordenamiento";
            this.gpbcriterioordenamiento.Size = new System.Drawing.Size(289, 100);
            this.gpbcriterioordenamiento.TabIndex = 1;
            this.gpbcriterioordenamiento.TabStop = false;
            this.gpbcriterioordenamiento.Text = "Criterio de Ordenamiento";
            // 
            // rbtadecendente
            // 
            this.rbtadecendente.AutoSize = true;
            this.rbtadecendente.Location = new System.Drawing.Point(7, 61);
            this.rbtadecendente.Name = "rbtadecendente";
            this.rbtadecendente.Size = new System.Drawing.Size(88, 19);
            this.rbtadecendente.TabIndex = 1;
            this.rbtadecendente.TabStop = true;
            this.rbtadecendente.Text = "Decendente";
            this.rbtadecendente.UseVisualStyleBackColor = true;
            // 
            // rbtAcendente
            // 
            this.rbtAcendente.AutoSize = true;
            this.rbtAcendente.Location = new System.Drawing.Point(7, 23);
            this.rbtAcendente.Name = "rbtAcendente";
            this.rbtAcendente.Size = new System.Drawing.Size(82, 19);
            this.rbtAcendente.TabIndex = 0;
            this.rbtAcendente.TabStop = true;
            this.rbtAcendente.Text = "Acendente";
            this.rbtAcendente.UseVisualStyleBackColor = true;
            // 
            // btnmetodoordenamiento
            // 
            this.btnmetodoordenamiento.Location = new System.Drawing.Point(215, 12);
            this.btnmetodoordenamiento.Name = "btnmetodoordenamiento";
            this.btnmetodoordenamiento.Size = new System.Drawing.Size(138, 42);
            this.btnmetodoordenamiento.TabIndex = 3;
            this.btnmetodoordenamiento.Text = "quick sort";
            this.btnmetodoordenamiento.UseVisualStyleBackColor = true;
            this.btnmetodoordenamiento.Click += new System.EventHandler(this.btnmetodoordenamiento_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // datadatos
            // 
            this.datadatos.AllowUserToAddRows = false;
            this.datadatos.AllowUserToDeleteRows = false;
            this.datadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Edad,
            this.Sueldo});
            this.datadatos.Location = new System.Drawing.Point(54, 183);
            this.datadatos.Name = "datadatos";
            this.datadatos.ReadOnly = true;
            this.datadatos.Size = new System.Drawing.Size(397, 245);
            this.datadatos.TabIndex = 2;
            this.datadatos.Text = "dataGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmetodoordenamiento);
            this.Controls.Add(this.datadatos);
            this.Controls.Add(this.gpbcriterioordenamiento);
            this.Controls.Add(this.btnaleatorios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbcriterioordenamiento.ResumeLayout(false);
            this.gpbcriterioordenamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaleatorios;
        private System.Windows.Forms.GroupBox gpbcriterioordenamiento;
        private System.Windows.Forms.RadioButton rbtadecendente;
        private System.Windows.Forms.RadioButton rbtAcendente;
        private System.Windows.Forms.DataGridView datadatos;
        private System.Windows.Forms.Button btnmetodoordenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
    }
}

