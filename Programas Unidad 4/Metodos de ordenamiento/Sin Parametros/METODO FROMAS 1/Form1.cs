using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METODO_FROMAS_1
{
    public partial class Form1 : Form
    {
        Maestro[] miArreglo;

        Maestros[] misArreglos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgListas.ReadOnly = true;
            dtgListas.AllowUserToAddRows = false;
            dtgListas.AllowUserToDeleteRows = false;
            dtgListas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListas.AllowUserToOrderColumns = false;
            dtgListas.MultiSelect = false;
            dtgListas.AllowUserToOrderColumns = false;
            dtgListas.AllowUserToResizeColumns = false;
            dtgListas.AllowUserToResizeRows = false;
            dtgListas.Columns.Add("matriculaa", "Matricula");
            dtgListas.Columns.Add("sueldoo", "Sueldo");
            dtgListas.Columns.Add("Materiaa", "Materia");

            dtgListasOrdenada.ReadOnly = true;
            dtgListasOrdenada.AllowUserToAddRows = false;
            dtgListasOrdenada.AllowUserToDeleteRows = false;
            dtgListasOrdenada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListasOrdenada.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListasOrdenada.AllowUserToOrderColumns = false;
            dtgListasOrdenada.MultiSelect = false;
            dtgListasOrdenada.AllowUserToOrderColumns = false;
            dtgListasOrdenada.AllowUserToResizeColumns = false;
            dtgListasOrdenada.AllowUserToResizeRows = false;
            dtgListasOrdenada.Columns.Add("matricula", "Matricula");
            dtgListasOrdenada.Columns.Add("sueldo", "Sueldo");
            dtgListasOrdenada.Columns.Add("Materia", "Materia");


            radMatricula.Checked = true;
            radAcendente.Checked = true;
        }

        private void btnDatosAleatorios_Click(object sender, EventArgs e)
        {
            string[] arrayCancha = { "Programacion", "Ingles", "Etica", "Matematicas", "Español", "Historia", "Geografia" };
            Random aleatorio = new Random();
            miArreglo = new Maestro[1000];
            misArreglos = new Maestros[1000];

            for (int i = 0; i < miArreglo.Length; i++)
            {
                miArreglo[i] = new Maestro();
                miArreglo[i].Matricula = aleatorio.Next(1, 10000);
                miArreglo[i].Sueldo = Math.Round(aleatorio.NextDouble() * 10000, 1);
                miArreglo[i].Materia = arrayCancha[aleatorio.Next(arrayCancha.Length)];
            }

            for (int i = 0; i < miArreglo.Length; i++)
            {
                misArreglos[i] = new Maestros();
                misArreglos[i].Matricula = aleatorio.Next(1, 10000);
                misArreglos[i].Sueldo = Math.Round(aleatorio.NextDouble() * 10000, 1);
                misArreglos[i].Materia = arrayCancha[aleatorio.Next(arrayCancha.Length)];
            }

            ImprimirDatos();
        }

        private void ImprimirDatosss()
        {
            dtgListasOrdenada.Rows.Clear();

            foreach (Maestros q in misArreglos)
            {
                dtgListasOrdenada.Rows.Add(q.Matricula, q.Sueldo, q.Materia);
            }
        }

        private void ImprimirDatos()
        {
            dtgListas.Rows.Clear();

            foreach (Maestro q in miArreglo)
            {
                dtgListas.Rows.Add(q.Matricula, q.Sueldo, q.Materia);
            }
        }

        private void ImprimirDatoss()
        {
            dtgListasOrdenada.Rows.Clear();

            foreach (Maestro q in miArreglo)
            {
                dtgListasOrdenada.Rows.Add(q.Matricula, q.Sueldo, q.Materia);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            string Seleccion = "";

            switch (Seleccion)
            {
                case "ShakerSort":
                    //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
                    if (radAcendente.Checked && radMatricula.Checked)
                        ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

                    if (radAcendente.Checked && radSueldo.Checked)
                        ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

                    if (radAcendente.Checked && radMateria.Checked)
                        ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    if (radDescendente.Checked && radMatricula.Checked)
                        ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

                    if (radDescendente.Checked && radSueldo.Checked)
                        ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

                    if (radDescendente.Checked && radMateria.Checked)
                        ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
                    break;

                default:
                    break;
            }

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnShakerSort_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.Shaker(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnBurbujaIzq_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.BurbujaIzquierda(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.BurbujaIzquierda(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.BurbujaIzquierda(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.BurbujaIzquierda(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.BurbujaIzquierda(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.BurbujaIzquierda(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnBurbujaDer_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.BurbujaDerecha(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.BurbujaDerecha(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.BurbujaDerecha(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.BurbujaDerecha(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.BurbujaDerecha(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.BurbujaDerecha(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnBurbujaSeñal_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.BurbujaConSeñal(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.BurbujaConSeñal(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.BurbujaConSeñal(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.BurbujaConSeñal(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.BurbujaConSeñal(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.BurbujaConSeñal(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            DateTime tiempoInicio = DateTime.Now;
            Ordenamiento<Maestros>.QuickSort(misArreglos, Ordenamiento<Maestros>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
            ImprimirDatosss();
            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.Shell(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.Shell(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.Shell(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.Shell(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.Shell(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.Shell(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            bool Acendente;
            if (radAcendente.Checked)
                Acendente = true;
            else
                Acendente = false;

            ClaseOrdenadores.RadixSort(miArreglo, Acendente);

            ImprimirDatoss();

            //foreach (Maestro q in miArreglo)
            //{
            //    MessageBox.Show(q.Matricula.ToString());
            //}
        }

        private void btnSeleccionDirecta_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.SeleccionDirecta(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.SeleccionDirecta(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.SeleccionDirecta(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.SeleccionDirecta(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.SeleccionDirecta(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.SeleccionDirecta(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnInsercionDirecta_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.InsercionDirecta(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.InsercionDirecta(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.InsercionDirecta(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.InsercionDirecta(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.InsercionDirecta(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.InsercionDirecta(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnInsertBinaria_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.InsercionBinaria(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.InsercionBinaria(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.InsercionBinaria(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.InsercionBinaria(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.InsercionBinaria(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.InsercionBinaria(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;

            DateTime tiempoInicio = DateTime.Now;

            //ORDENAMIENTO EN FORMA ASCENDENTE Y DESCENDENTE DEL NOMBRE DEL EMPLEADO
            if (radAcendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.HeapSort(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.HeapSort(miArreglo, ClaseOrdenadores.Ascendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radAcendente.Checked && radMateria.Checked)
                ClaseOrdenadores.HeapSort(miArreglo, ClaseOrdenadores.Ascendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (radDescendente.Checked && radMatricula.Checked)
                ClaseOrdenadores.HeapSort(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorMatricula, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radSueldo.Checked)
                ClaseOrdenadores.HeapSort(miArreglo, ClaseOrdenadores.Descendente, Maestro.CompararPorSueldo, out Comparaciones, out Movimientos, out MiliSegundos);

            if (radDescendente.Checked && radMateria.Checked)
                ClaseOrdenadores.HeapSort(miArreglo, ClaseOrdenadores.Descendente, Maestro.ComparaPorMateria, out Comparaciones, out Movimientos, out MiliSegundos);

            ImprimirDatoss();

            MessageBox.Show("N° Comparaciones: " + Comparaciones +
                "\nN° Intercambios: " + Movimientos +
                "\nDuracion del ordenado: " + MiliSegundos.ToString() + " ms");
        }
    }
}
