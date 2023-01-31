using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void crearLabel(ref Label unLabel, string Dato,ref int X, ref int Y) 
        {
            unLabel = new Label();
            unLabel.AutoSize = false;
            unLabel.Size = new Size(75, 75);
            unLabel.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            unLabel.Text = Dato;
            unLabel.Location = new Point(X, Y);
        }


        public void ShellSort(ref int[] Arreglo, ref int Comparaciones, ref int Intercambios)
        {
            int posX = 0;
            int posY = unLabel.Location.Y;
            

            int Npasos = Arreglo.Length / 2;
            int aux = 0;
            int x = 0;
            bool Bandera;

            while (Npasos > 0)
            {
                posY += 150;
               
                do
                {
                    
                    //Muestra de datos
                    for (int i = 0; i < Arreglo.Length; i++)
                    {
                        crearLabel(ref unLabel, "["+Arreglo[i].ToString("D2")+"]",ref posX,ref posY);
                        posX += 75;
                        PanelArreglo.Controls.Add(unLabel);


                        x++;
                        if (Npasos <= x)
                        {
                            posY += 75;
                            posX = 0;
                            x = 0;
                        }

                    }
                    
                    Bandera = false;



                    x = 1;
                    //Si T - Comparacion n
                    while (x <= (Arreglo.Length - Npasos))
                    {
                        Comparaciones++;

                        //Si T - Intercambio
                        if (Arreglo[x - 1] > Arreglo[(x - 1) + Npasos])
                        {
                            aux = Arreglo[(x - 1) + Npasos];
                            Arreglo[(x - 1) + Npasos] = Arreglo[x - 1];
                            Arreglo[x - 1] = aux;
                            Bandera = true;
                            Intercambios++;
                        }
                        x++;
                    }
                    
                    x = 0;
                    posY += 75;
                    posX = 0;
                } while (Bandera);

                Npasos = Npasos / 2;


            }
        }



        Label unLabel;

        public void RefrescarForma() 
        {
            int X = 0,Y=0;
            PanelArreglo.Controls.Clear();
           
            foreach (int Dato in Arreglo)
            {

                crearLabel(ref unLabel, "[" + Dato.ToString("D2") + "]",ref X, ref Y);
                
                PanelArreglo.Controls.Add(unLabel);
                X += 75;
                if (X>PanelArreglo.Width)
                {
                    X = 0;
                    Y += 75;
                }
            }

        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch TiempoOperacion = new System.Diagnostics.Stopwatch();
            int Comparaciones=0, Intercambios=0;
            TiempoOperacion.Start();
           ShellSort(ref Arreglo,ref Comparaciones,ref Intercambios);
            TiempoOperacion.Stop();
            lblComp.Text = Comparaciones.ToString();
            lblInt.Text = Intercambios.ToString();
            lblTiempo.Text = $"{TiempoOperacion.Elapsed.TotalMilliseconds} ms";
        }


        Random random = new Random();
        int[] Arreglo = null;

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n = random.Next(10, 30);
            Arreglo = new int[n];
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = random.Next(0, 99);
            }
            lblDatos.Text = Arreglo.Length.ToString();
            RefrescarForma();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarForma();
        }

        private void btnShellAnimado_Click(object sender, EventArgs e)
        {
      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
