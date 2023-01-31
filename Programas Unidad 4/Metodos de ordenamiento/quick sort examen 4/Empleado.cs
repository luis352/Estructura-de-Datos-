using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_4
{
    class Empleado : IComparable<Empleado>
    {
        private int _intEdad;
        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }


        private string _strNombre;
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
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
            if (this.Sueldo < x.Sueldo)
                return (-1);
            else
                if (this.Sueldo > x.Sueldo)
                return (1);
            else
                return (0);
        }
        
    }
}
