using System;
using System.Collections.Generic;
using System.Text;

namespace METODO_FROMAS_1
{
    public class Maestros : IComparable<Maestros>
    {
        private int _intMatricula;  // Matricula del objeto de cada celda
        private double _dblSueldo;
        private string _strMateria;

        // Propiedad pública para acceder al _intMatricula
        public int Matricula { get { return (_intMatricula); } set { _intMatricula = value; } }
        public double Sueldo { get { return (_dblSueldo); } set { _dblSueldo = value; } }
        public string Materia { get { return (_strMateria); } set { _strMateria = value; } }

        // Método público para comparar datos y determinar el
        // Criterio de ordenamiento
        public int CompareTo(Maestros x)
        {
            if (this.Matricula < x.Matricula)
                return (-1);
            else
                if (this.Matricula > x.Matricula)
                return (1);
            else
                return (0);
        }

        public override string ToString()
        {
            return  Matricula.ToString();
        }
    }
}
