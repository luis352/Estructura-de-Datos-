using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellSort_Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Estudiante[] arregloEstudiante;
        Random aleatorio = new Random();

        // ordenar 
        private void button3_Click(object sender, EventArgs e)
        {
            int Comp = 0, Inter = 0;

            DateTime tiempoInicio = DateTime.Now;

            if (radAscendente.Checked && radPorMatricula.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Ascendente, Estudiante.CompararPorMatricula, ref Comp, ref Inter);
            if (radAscendente.Checked && radPorNombre.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Ascendente, Estudiante.CompararPorNombre, ref Comp, ref Inter);
            if (radAscendente.Checked && radPorGrado.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Ascendente, Estudiante.CompararPorGrado, ref Comp, ref Inter);
            if (radAscendente.Checked && radPorGrupo.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Ascendente, Estudiante.CompararPorGrupo, ref Comp, ref Inter);
            if (radAscendente.Checked && radPorPromedio.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Ascendente, Estudiante.CompararPorPromedio, ref Comp, ref Inter);


            if (radDescendente.Checked && radPorMatricula.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Descendente, Estudiante.CompararPorMatricula, ref Comp, ref Inter);
            if (radDescendente.Checked && radPorNombre.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Descendente, Estudiante.CompararPorNombre, ref Comp, ref Inter);
            if (radDescendente.Checked && radPorGrado.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Descendente, Estudiante.CompararPorGrado, ref Comp, ref Inter);
            if (radDescendente.Checked && radPorGrupo.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Descendente, Estudiante.CompararPorGrupo, ref Comp, ref Inter);
            if (radDescendente.Checked && radPorPromedio.Checked)
                ShellSort.Ordenar(arregloEstudiante, ShellSort.Descendente, Estudiante.CompararPorPromedio, ref Comp, ref Inter);


            RefrescarDGV();
            DateTime tiempoFin = DateTime.Now;
            TimeSpan tiempo = tiempoFin - tiempoInicio;
            MessageBox.Show("N° Comparaciones: " + Comp +
                "\nN° Intercambios: " + Inter +
                "\nDuracion del ordenado: " + tiempo.TotalMilliseconds + " ms");


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {


            Estudiante miEstu = new Estudiante();

            miEstu.Grado = int.Parse(txtGrado.Text);
            miEstu.Grupo = char.Parse(txtGrupo.Text); 
            miEstu.Matricula = txrmatricula.Text;
            miEstu.Nombre = txtNombre.Text;
            miEstu.Promedio = double.Parse(txtPromedio.Text);


            RefrescarDGV(); 


        }

        public void RefrescarDGV() 
        {
            dgEstudiantes.Rows.Clear();

            foreach (Estudiante estu in arregloEstudiante)
            {
                dgEstudiantes.Rows.Add( estu.Matricula, estu.Nombre,
                estu.Grado.ToString(), estu.Grupo.ToString(),
                estu.Promedio.ToString("N2"));
            }


        
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            arregloEstudiante = new Estudiante[aleatorio.Next(10, 100)];
            string[] Nombre = new string[] {"Hugo ","Martin", "Lucas", "Mateo", "Leo", "Daniel", "Alejandro", "Pablo", "Manuel", "Alvaro",
                "Adrian", "Carlos", "David", "Mario", "Diego", "Enzo", "Edgar", "Marcos", "Izan", "Javier", "Alex", "Bruno", "Oliver", "Miguel",
            "Juan","Gonzalo","Gael","Sergio","Nicolas","Dylan","Gabriel","Jorge","Jose","Adam","Liam","Eric","Samuel","Dario","Hector","Luca",
                "Iker","Amir"};
            for (int i = 0; i <10 ; i++) 
            {
                arregloEstudiante[i] = new Estudiante();
                arregloEstudiante[i].Nombre = Nombre[aleatorio.Next(0,(Nombre.Length-1))];
                arregloEstudiante[i].Matricula = Guid.NewGuid().ToString().Substring(0, 9);
               
                arregloEstudiante[i].Grado = aleatorio.Next(0, 14);
                arregloEstudiante[i].Grupo =
                char.Parse(Guid.NewGuid().ToString().Substring(0, 1));
                arregloEstudiante[i].Promedio = aleatorio.Next(0, 100);
               
            }
            
         RefrescarDGV();
            MessageBox.Show("Se han generado: " + arregloEstudiante.Length + " Datos");
        }
    }
}
