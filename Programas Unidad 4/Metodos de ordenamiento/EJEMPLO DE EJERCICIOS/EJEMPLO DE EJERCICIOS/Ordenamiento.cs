using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_DE_EJERCICIOS
{
    abstract class Ordenamiento<Tipo> where Tipo : IComparable<Tipo>
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

        public static void BurbujaDerecha(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            for (int i = Arreglo.Length - 2; i >= 0; i--)
                for (int j = 0; j <= i; j++)
                {
                    Comparaciones++;
                    if (Orden(Arreglo[j], Arreglo[j + 1])) // Comparación a través del delegado
                    {
                        Intercambia(Arreglo, j, j + 1); // Intercambio de datos
                        Movimientos++;
                    }
                }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }
        public static void BurbujaIzquierda(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 1; i <= Arreglo.Length - 1; i++)
                for (int j = Arreglo.Length - 1; j >= i; j--)
                {
                    Comparaciones++;
                    if (Orden(Arreglo[j - 1], Arreglo[j]))  // Comparación a través del delegado
                    {
                        Intercambia(Arreglo, j - 1, j);  // Intercambio de datos
                        Movimientos++;
                    }
                }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
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
                // Si el criterio de ordenamiento es ascendente
                if (Orden.Method.Name.Equals("Ascendente"))
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
                }
                else  // Ordenamiento descendente
                {
                    // Comparaciones de izquierda a derecha
                    while (Pivote.CompareTo(Arreglo[i]) < 0)
                    {
                        i++;
                        Comparaciones++;
                    }

                    // Comparaciones de derecha a izquierda
                    while (Pivote.CompareTo(Arreglo[d]) > 0)
                    {
                        d--;
                        Comparaciones++;
                    }
                }

                if (i <= d)
                {
                    Intercambia(Arreglo, i, d);  // Intercambio de datos
                    i++;
                    d--;
                    Movimientos++;
                }

            } while (i <= d);

            // LLamadas recursivas
            if (Izquierdo < d)
                QSort(Arreglo, Izquierdo, d, Orden, ref Comparaciones, ref Movimientos);

            if (i < Derecho)
                QSort(Arreglo, d + 1, Derecho, Orden, ref Comparaciones, ref Movimientos);
        }

    }

}
