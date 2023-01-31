using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_DE_EJERCICIOS
{
    class Empleado : IComparable<Empleado>
    {
        private string _strNombre;
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private int _intClave;
        public int Clave
        {
            get { return _intClave; }
            set { _intClave = value; }
        }
        private int _intNivel;
        public int Nivel
        {
            get { return _intNivel; }
            set { _intNivel = value; }
        }
        //private char _chrNivel;
        //public char Nivel
        //{
        //    get { return _chrNivel; }
        //    set { _chrNivel = value; }
        //}
        private double _dblSueldo;
        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        // Método público para comparar datos y determinar criterio de ordenamiento
        public int CompareTo(Empleado x)
        {
            if (this.Clave < x.Clave)
                return (-1);
            else
                if (this.Clave > x.Clave)
                return (1);
            else
                return (0);
        }
        //public int CompareTo(Empleado x)
        //{
        //    return (this.Nivel.CompareTo(x.Nivel));
        //}
        //public override string ToString()
        //{
        //    return Clave.ToString();
        //}
    }
}

