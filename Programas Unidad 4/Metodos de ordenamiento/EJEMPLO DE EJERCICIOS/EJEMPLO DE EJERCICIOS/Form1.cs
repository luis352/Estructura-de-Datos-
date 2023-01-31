using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJEMPLO_DE_EJERCICIOS
{
    public partial class Form1 : Form
    {
        Empleado[] miEmpleadoArreglo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarDatosAleatorios_Click(object sender, EventArgs e)
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
                    miEmpleadoArreglo[i].Clave = aleatorio.Next(0001, 1000);
                    miEmpleadoArreglo[i].Nivel = aleatorio.Next(1, 6);
                    //miEmpleadoArreglo[i].Nivel = (char)(aleatorio.Next(65, 90));
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
            dtgDatos.Rows.Clear();

            foreach (Empleado x in miEmpleadoArreglo)
            {
                dtgDatos.Rows.Add(x.Nombre, x.Clave, x.Nivel, x.Sueldo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDatos.Columns.Add("Nombre del empleado", "Nombre del empleado");
            dtgDatos.Columns.Add("Clave del empleado", "Clave del empleado");
            dtgDatos.Columns.Add("Nivel del empleado", "Nivel del empleado");
            dtgDatos.Columns.Add("Sueldo del empleado", "Sueldo del empleado");
            // No permitir agregar ni eliminar renglones
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            // Autoajustar el ancho de las columnas
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Seleccionar un renglón completo al hacer click
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // No se permite seleccionar varios renglones
            dtgDatos.MultiSelect = false;
            // Modo de solo lectura
            dtgDatos.ReadOnly = true;
        }

        private void btnOrdenarPorClaveBurbujaDerechaAscendente_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            DateTime tiempoInicio = DateTime.Now;
            Ordenamiento<Empleado>.BurbujaDerecha(miEmpleadoArreglo, Ordenamiento<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
            MostrarDatos();
            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO BURBUJA DERECHA (ASCENDENTE)");
        }

        private void btnOrdenarPorClaveBurbujaIzquierdaAscendente_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            DateTime tiempoInicio = DateTime.Now;
            Ordenamiento<Empleado>.BurbujaIzquierda(miEmpleadoArreglo, Ordenamiento<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
            MostrarDatos();
            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO BURBUJA IZQUIERDA (ASCENDENTE)");
        }

        private void btnOrdenarPorClaveBurbujaConSeñalAscendente_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            DateTime tiempoInicio = DateTime.Now;
            Ordenamiento<Empleado>.BurbujaConSeñal(miEmpleadoArreglo, Ordenamiento<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
            MostrarDatos();
            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO BURBUJA CON SEÑAL (ASCENDENTE)");
        }

        private void btnOrdenarPorClaveShellSortAscendente_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            DateTime tiempoInicio = DateTime.Now;
            Ordenamiento<Empleado>.Shell(miEmpleadoArreglo, Ordenamiento<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
            MostrarDatos();
            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO SHELL SORT (ASCENDENTE)");
        }

        private void btnOrdenarPorClaveShakerSortAscendente_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            DateTime tiempoInicio = DateTime.Now;
            Ordenamiento<Empleado>.ShakerSort(miEmpleadoArreglo, Ordenamiento<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
            MostrarDatos();
            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO SHAKER SORT (ASCENDENTE)");
        }

        private void btnOrdenarPorClaveQuickSortAscendente_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            DateTime tiempoInicio = DateTime.Now;
            Ordenamiento<Empleado>.QuickSort(miEmpleadoArreglo, Ordenamiento<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
            MostrarDatos();
            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms", "METODO QUICK SORT (ASCENDENTE)");
        }


        //ESTO ES DE RADIX EN ESPECIAL!

        private void btnOrdenarPorClaveRadixSortAscendente_Click(object sender, EventArgs e)
        {
            Ordenarlos();
        }

        private void Ordenarlos()
        {
            // Determina la cantidad de estudiantes almacenados en el dataGridView1
            int CantidadElementos = dtgDatos.Rows.Count;

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
                miEmpleado.Nombre  = dtgDatos[0, i].Value.ToString();
                
                miEmpleado.Clave  = int.Parse(dtgDatos[1, i].Value.ToString());
                miEmpleado.Nivel = int.Parse(dtgDatos[2, i].Value.ToString());
                miEmpleado.Sueldo = double.Parse(dtgDatos[3, i].Value.ToString());

                // Crea el objeto de la celda i del arreglo
                ArregloOriginal[i] = new Empleado();

                // Inserta el objeto del Estudiante en la celda i
                ArregloOriginal[i] = miEmpleado;
            }
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                Ordenar.RadixSort(ArregloOriginal, true);
                // True = Ascendente
                // False = Descendente
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Reloj.Stop();
            dtgDatos.Rows.Clear();
            foreach (Empleado x in ArregloOriginal)
            {
                dtgDatos.Rows.Add(x.Nombre, x.Clave, x.Nivel, x.Sueldo);
            }

            MessageBox.Show("\nDuracion del ordenado: " + Reloj.Elapsed.TotalMilliseconds + " ms", "METODO BURBUJA IZQUIERDA (ASCENDENTE)");
        }






    }
}
