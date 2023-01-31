using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort_Estudiantes
{
    class Estudiante
    {
        public delegate int AtributoComparable(Estudiante X, Estudiante Y);




        private string _strMatricula;

        public string Matricula
        {
            get { return _strMatricula; }
            set { _strMatricula = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private int _intGrado;

        public int Grado
        {
            get { return _intGrado; }
            set { _intGrado = value; }
        }

        private char _chrGrupo;

        public char Grupo
        {
            get { return _chrGrupo; }
            set { _chrGrupo = value; }
        }

        private double _dblPromedio;

        public double Promedio
        {
            get { return _dblPromedio; }
            set { _dblPromedio = value; }
        }


        public static int CompararPorPromedio(Estudiante x, Estudiante y) 
        {
            if (x.Promedio > y.Promedio)
            {
                return 1;
            }
            if (x.Promedio < y.Promedio)
            {
                return -1;
            }
            return 0;
        }
        public static int CompararPorNombre(Estudiante x, Estudiante y) {
            return (x.Nombre.CompareTo(y.Nombre)); 
                }
        public static int  CompararPorMatricula(Estudiante x, Estudiante y) { return (x.Matricula.CompareTo(y.Matricula)); }
        public static int CompararPorGrado(Estudiante x, Estudiante y)
        {
            if (x.Grado > y.Grado)
            {
                return 1;
            }
            if (x.Grado < y.Grado)
            {
                return -1;
            }
            return 0;
        }
        public static int CompararPorGrupo(Estudiante x, Estudiante y) 
        {
            if (x.Grupo > y.Grupo)
            {
                return 1;
            }
            if (x.Grupo < y.Grupo)
            {
                return -1;
            }
            return 0;
        }


    }
}
