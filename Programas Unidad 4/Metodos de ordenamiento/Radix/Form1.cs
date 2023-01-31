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
                //if (txtNumeroDeDatosAleatorios.Text == "")
                //{
                //    throw new Exception("!No deje el campo para ingresar el numero de datos aleatorios en blanco¡");
                //}
                //int intNumeroDeTamañoDelArreglo = 0;
                //intNumeroDeTamañoDelArreglo = int.Parse(txtNumeroDeDatosAleatorios.Text);


                
                Random aleatorio = new Random();
                miEmpleadoArreglo = new Empleado[100]; //intNumeroDeTamaño
                string[] Nombre = new string[] {"Hugo Marquez","Martin Lopez", "Lucas", "Mateo Romero", "Leo", "Daniel Valdez", "Alejandro Montemayor", "Pablo Alejandro",
                "Jose Julian", "Maya Lopez", "Pedro Garcia", "Israel Garcia", "Melanie Lopez", "Arturo Hernandez", "Santiago Ferreira", "Princesa Michelle" };

                for (int i = 0; i < miEmpleadoArreglo.Length; i++)
                {
                    miEmpleadoArreglo[i] = new Empleado();
                    miEmpleadoArreglo[i].Nombre = Nombre[aleatorio.Next(0, (Nombre.Length - 1))];

                    miEmpleadoArreglo[i].Edad = aleatorio.Next(1, 100);
                    
                    miEmpleadoArreglo[i].Sueldo = Math.Round(aleatorio.NextDouble() * 6000, 2);

                }
                MostrarDatos();
                MessageBox.Show("Se han generado: " + miEmpleadoArreglo.Length + " datos");
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
                datadatos.Rows.Add(x.Nombre,  x.Edad, x.Sueldo);
            }
        }

        private void btnmetodoordenamiento_Click(object sender, EventArgs e)
        {
            Ordenarlos(); 


        }
        private void Ordenarlos()
        {

            
            // Determina la cantidad de estudiantes almacenados en el dataGridView1
            int CantidadElementos = datadatos .Rows.Count;

            // Crea un arreglo local
            Empleado[] ArregloOriginal = new Empleado[CantidadElementos];

            // Declaración local de un estudiante
            Empleado miEmpleado;

            // Ciclo para almacenar en el arreglo los datos del dataGridView1
            for (int i = 0; i < CantidadElementos; i++)
            {
                // Crea un objeto para un estudiante
                miEmpleado = new Empleado();

                // Inserta los datos en el objeto Estudiante
               

                miEmpleado.Edad = int.Parse(datadatos [1, i].Value.ToString());
                miEmpleado.Nombre = (datadatos[0, i].Value.ToString());
                miEmpleado.Sueldo = double.Parse(datadatos[2, i].Value.ToString());

                // Crea el objeto de la celda i del arreglo
                ArregloOriginal[i] = new Empleado();

                // Inserta el objeto del Estudiante en la celda i
                ArregloOriginal[i] = miEmpleado;
            }
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                if (rbtAcendente.Checked)
                {


                    Ordenar.RadixSort(ArregloOriginal, true);
                    // True = Ascendente
                    // False = Descendente
                }
                if(rbtadecendente.Checked)
                {
                    Ordenar.RadixSort(ArregloOriginal, false);
                    MessageBox.Show("ES DECENDENTE"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Reloj.Stop();
            datadatos.Rows.Clear();
            foreach (Empleado x in ArregloOriginal)
            {
                datadatos.Rows.Add(x.Nombre, x.Edad , x.Sueldo);
            }

            MessageBox.Show("\nDuracion del ordenado: " + Reloj.Elapsed.TotalMilliseconds + " ms", "METODO Radix  (ASCENDENTE)");
        }


    }
}


