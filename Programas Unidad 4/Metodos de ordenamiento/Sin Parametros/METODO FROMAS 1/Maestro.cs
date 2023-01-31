using System;
using System.Collections.Generic;
using System.Text;

namespace METODO_FROMAS_1
{
    public class Maestro
    {
        public delegate int AtributoComparable(Maestro X, Maestro Y);

        private int _intMatricula;  // Matricula del objeto de cada celda
        private double _dblSueldo;
        private string _strMateria;

        // Propiedad pública para acceder al _intMatricula
        public int Matricula { get { return (_intMatricula); } set { _intMatricula = value; } }
        public double Sueldo { get { return (_dblSueldo); } set { _dblSueldo = value; } }
        public string Materia { get { return (_strMateria); } set { _strMateria = value; } }

        public static int ComparaPorMateria(Maestro X, Maestro Y)
        {
            return (X.Materia.CompareTo(Y.Materia));
        }

        public static int CompararPorMatricula(Maestro x, Maestro Y)
        {
            if (x.Matricula < Y.Matricula)
                return (-1);
            else
                if (x.Matricula > Y.Matricula)
                return (1);
            else
                return (0);
        }

        public static int CompararPorSueldo(Maestro x, Maestro Y)
        {
            if (x.Sueldo < Y.Sueldo)
                return (-1);
            else
                if (x.Sueldo > Y.Sueldo)
                return (1);
            else
                return (0);
        }
    }
}
