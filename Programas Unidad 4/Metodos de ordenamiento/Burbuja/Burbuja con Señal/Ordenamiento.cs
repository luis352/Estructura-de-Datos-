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


        public static void BurbujaConSeñal(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            int i = 0;
            bool Bandera = true; // Declaración de la Bandera

            // Mientras haya celdas en el arreglo y la Bandera esté "encendida"
            while (i < Arreglo.Length && Bandera)
            {
                Bandera = false;  // "Apaga" la Bandera
                for (int j = 0; j <= Arreglo.Length - i - 2; j++)
                {
                    Comparaciones++;
                    if (Orden(Arreglo[j], Arreglo[j + 1])) // Comparación a través del delegado
                    {
                        Intercambia(Arreglo, j, j + 1); // Intercambio de datos
                        Bandera = true;  // "Enciende" la Bandera
                        Movimientos++;
                    }
                }

                i++;
            }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

    }
}
