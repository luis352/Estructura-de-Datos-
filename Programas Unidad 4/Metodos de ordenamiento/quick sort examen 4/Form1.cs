using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbtAcendente.Checked = true;
        }
        Empleado[] miEmpleadoArreglo;

        private void btnaleatorios_Click(object sender, EventArgs e)
        {
            try
            {
                
                Random aleatorio = new Random();
                miEmpleadoArreglo = new Empleado[100]; 
                string[] Nombre = new string[] {"Cristiano ronaldo","Lionel messi cuchitini ", "Lucas moura ", "kylian mbappe ", "Luis angel rendon ", "Carlos Carpio   ", "Isaak Neetwon ", "Paco garcia caridad ",
                "Tomas roncero ", "Edu Aguirre ", "Hector moreno ", "Israel ", "Melanie Lopez", "Paco juan ", "Lionel mensi  ", "Szioanolo " };

                for (int i = 0; i < miEmpleadoArreglo.Length; i++)
                {
                    miEmpleadoArreglo[i] = new Empleado();
                    miEmpleadoArreglo[i].Nombre = Nombre[aleatorio.Next(0, (Nombre.Length - 1))];

                    miEmpleadoArreglo[i].Edad = aleatorio.Next(1, 100);
                    
                    miEmpleadoArreglo[i].Sueldo = Math.Round(aleatorio.NextDouble() * 6000, 2);

                }
                MostrarDatos();
                MessageBox.Show("Se han generado: " + miEmpleadoArreglo.Length + " Datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarDatos()
        {
            datadatos.Rows.Clear();

            foreach (Empleado x in miEmpleadoArreglo)
            {
                datadatos.Rows.Add(x.Edad,  x.Nombre, x.Sueldo);
            }
        }

        private void btnmetodoordenamiento_Click(object sender, EventArgs e)
        {
            if (rbtAcendente.Checked)
            {
                int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
                DateTime tiempoInicio = DateTime.Now;
                Ordenamiento<Empleado>.QuickSort(miEmpleadoArreglo, Ordenamiento<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
                MostrarDatos();
                MessageBox.Show("N° Comparaciones: " + Comparaciones +
                    "\nN° Intercambios: " + Movimientos +
                    "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO QUICKSORT (ASCENDENTE)");
            }

            if(rbtadecendente.Checked)
            {
                int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
                DateTime tiempoInicio = DateTime.Now;
                Ordenamiento<Empleado>.QuickSort(miEmpleadoArreglo, Ordenamiento<Empleado>.Descendente, out Comparaciones, out Movimientos, out MiliSegundos);
                MostrarDatos();
                MessageBox.Show("N° Comparaciones: " + Comparaciones +
                    "\nN° Intercambios: " + Movimientos +
                    "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO QUICKSORT (DECENDENTE)");
            }


        }
    }
}


