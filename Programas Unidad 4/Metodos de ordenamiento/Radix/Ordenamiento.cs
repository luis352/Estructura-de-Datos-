using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_4
{
    class Ordenamiento<Tipo> where Tipo : IComparable<Tipo>
    {
        // Delegado para establecer el criterio de ordenamiento (ascendente ó descendente)
        public delegate bool CriterioOrdenamiento(Tipo x, Tipo y);

        // Criterio de ordenamiento ascendente (invocado a través del delegado)
        public static bool Ascendente(Tipo x, Tipo y)
        {
            if (x.CompareTo(y) > 0)
                return (true);
            else
                return (false);
        }

        // Criterio de ordenamiento descendente (invocado a través del delegado)
        public static bool Descendente(Tipo x, Tipo y)
        {
            if (x.CompareTo(y) < 0)
                return (true);
            else
                return (false);
        }

        // Método para intercambiar valores de dos celdas del arreglo
        private static void Intercambia(Tipo[] Arreglo, int a, int b)
        {
            Tipo Auxiliar; // Objeto auxiliar

            Auxiliar = Arreglo[a];
            Arreglo[a] = Arreglo[b];
            Arreglo[b] = Auxiliar;
        }


     





    }
}
