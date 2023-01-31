
namespace Shell_Sort
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
            this.btnShell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.PanelArreglo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShell
            // 
            this.btnShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnShell.Location = new System.Drawing.Point(3, 441);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(219, 51);
            this.btnShell.TabIndex = 0;
            this.btnShell.Text = "ShellSort";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° Comparaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Intercambios";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Playbill", 25F);
            this.lblInt.Location = new System.Drawing.Point(77, 225);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(27, 34);
            this.lblInt.TabIndex = 5;
            this.lblInt.Text = "0";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Playbill", 25F);
            this.lblComp.Location = new System.Drawing.Point(77, 168);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(27, 34);
            this.lblComp.TabIndex = 4;
            this.lblComp.Text = "0";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerar.Location = new System.Drawing.Point(3, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(101, 51);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar datos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTiempo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnRefrescar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.btnShell);
            this.panel1.Controls.Add(this.lblInt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblComp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(884, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 502);
            this.panel1.TabIndex = 7;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Playbill", 25F);
            this.lblTiempo.Location = new System.Drawing.Point(77, 303);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(27, 34);
            this.lblTiempo.TabIndex = 11;
            this.lblTiempo.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiempo de ejecucion";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefrescar.Location = new System.Drawing.Point(3, 384);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(219, 51);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar Forma";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "N° Datos";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Playbill", 25F);
            this.lblDatos.Location = new System.Drawing.Point(120, 42);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(27, 34);
            this.lblDatos.TabIndex = 8;
            this.lblDatos.Text = "0";
            // 
            // PanelArreglo
            // 
            this.PanelArreglo.AutoScroll = true;
            this.PanelArreglo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelArreglo.Location = new System.Drawing.Point(0, 0);
            this.PanelArreglo.Name = "PanelArreglo";
            this.PanelArreglo.Size = new System.Drawing.Size(884, 502);
            this.PanelArreglo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 502);
            this.Controls.Add(this.PanelArreglo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Panel PanelArreglo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label5;
    }
}

