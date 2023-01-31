using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_4
{
    class Empleado : IComparable<Empleado>
    {
        private string _strNombre;
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private int _intEdad;
        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }
        private int _intNivel;
        public int Nivel
        {
            get { return _intNivel; }
            set { _intNivel = value; }
        }
       
        private double _dblSueldo;
        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        // Método público para comparar datos y determinar criterio de ordenamiento
        public int CompareTo(Empleado x)
        {
            if (this.Edad < x.Edad)
                return (-1);
            else
                if (this.Edad > x.Edad)
                return (1);
            else
                return (0);
        }
        
    }
}
