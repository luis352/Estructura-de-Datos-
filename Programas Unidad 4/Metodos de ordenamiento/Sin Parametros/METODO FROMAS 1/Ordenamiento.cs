using System;
using System.Collections.Generic;
using System.Text;

namespace METODO_FROMAS_1
{
    internal abstract class Ordenamiento<Tipo> where Tipo : IComparable<Tipo>
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

        public static void QuickSort(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            // Primera llamada al método recursivo QSort() con el arreglo recibido
            QSort(Arreglo, 0, Arreglo.Length - 1, Orden, ref Comparaciones, ref Movimientos);

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        private static void QSort(Tipo[] Arreglo, int Izquierdo, int Derecho, CriterioOrdenamiento Orden, ref int Comparaciones, ref int Movimientos)
        {
            int i, d;
            Tipo Pivote;  // Declaración del Pivote

            // Inicializa el Pivote con el dato central del arreglo
            Pivote = Arreglo[(Izquierdo + Derecho) / 2];
            i = Izquierdo;
            d = Derecho;

            do
            {
                // Comparaciones de izquierda a derecha
                while (Pivote.CompareTo(Arreglo[i]) > 0)
                {
                    i++;
                    Comparaciones++;
                }

                // Comparaciones de derecha a izquierda
                while (Pivote.CompareTo(Arreglo[d]) < 0)
                {
                    d--;
                    Comparaciones++;
                }

                if (i <= d)
                {
                    Intercambia(Arreglo, i, d);  // Intercambio de datos
                    i++;
                    d--;
                    Movimientos++;
                }
            } while (i <= d);
            if (Izquierdo < d)
                QSort(Arreglo, Izquierdo, d, Orden, ref Comparaciones, ref Movimientos);

            if (i < Derecho)
                QSort(Arreglo, d + 1, Derecho, Orden, ref Comparaciones, ref Movimientos);
        }
    }
}
