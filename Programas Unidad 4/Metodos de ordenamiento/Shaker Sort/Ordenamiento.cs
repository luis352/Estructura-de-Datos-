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


        public static void ShakerSort(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            int Izquierda = 1;
            int Derecha = Arreglo.Length - 1;
            int PosicionDerechaIntercambio = Derecha;

            do
            {
                // Recorre el arreglo de derecha a izquierda
                for (int i = Derecha; i >= Izquierda; i--)
                {
                    Comparaciones++;
                    if (Orden(Arreglo[i - 1], Arreglo[i])) // Comparación a través del delegado
                    {
                        Intercambia(Arreglo, i - 1, i); // Intercambio de datos
                        PosicionDerechaIntercambio = i;
                        Movimientos++;
                    }
                }

                Izquierda = PosicionDerechaIntercambio + 1;

                // Recorre el arreglo de izquierda a derecha
                for (int i = Izquierda; i <= Derecha; i++)
                {
                    Comparaciones++;
                    if (Orden(Arreglo[i - 1], Arreglo[i])) // Comparación a través del delegado
                    {
                        Intercambia(Arreglo, i - 1, i); // Intercambio de datos
                        PosicionDerechaIntercambio = i;
                        Movimientos++;
                    }
                }

                Derecha = PosicionDerechaIntercambio - 1;
            }
            while (Derecha >= Izquierda);

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }


    }
}
