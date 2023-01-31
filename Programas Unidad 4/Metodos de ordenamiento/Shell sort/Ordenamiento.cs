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



        public static void Shell(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            bool Bandera;  // Declaración de la Bandera

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            int Posicion;
            int Salto = Arreglo.Length / 2;

            while (Salto > 0)
            {
                Bandera = true;  // "Enciende" la Bandera
                while (Bandera)
                {
                    Bandera = false;  // "Apaga" la Bandera
                    Posicion = 0;
                    while (Posicion < (Arreglo.Length - Salto))
                    {
                        Comparaciones++;
                        if (Orden(Arreglo[Posicion], Arreglo[Posicion + Salto])) // Comparación a través del delegado
                        {
                            Intercambia(Arreglo, Posicion, Posicion + Salto);  // Intercambio de datos
                            Bandera = true;  // "Enciende" la Bandera
                            Movimientos++;
                        }
                        Posicion++;
                    }
                }
                Salto = Salto / 2;  // Divide el salto a la mitad
            }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }









    }
}
