using System;
using System.Collections.Generic;
using System.Text;

namespace METODO_FROMAS_1
{
    class ClaseOrdenadores
    {
        // Delegado para establecer el criterio de ordenamiento (ascendente ó descendente)
        public delegate bool CriterioOrdenamiento(Maestro x, Maestro y, Maestro.AtributoComparable campo);

        // Criterio de ordenamiento ascendente (invocado a través del delegado)
        public static bool Ascendente(Maestro x, Maestro y, Maestro.AtributoComparable campo)
        {
            if (campo(x, y) > 0)
                return (true);
            else
                return (false);
        }

        // Criterio de ordenamiento descendente (invocado a través del delegado)
        public static bool Descendente(Maestro x, Maestro y, Maestro.AtributoComparable campo)
        {
            if (campo(x, y) < 0)
                return (true);
            else
                return (false);
        }

        // Método para intercambiar valores de dos celdas del arreglo
        private static void Intercambia(Maestro[] Arreglo, int a, int b)
        {
            Maestro Auxiliar; // Objeto auxiliar
            Auxiliar = Arreglo[a];
            Arreglo[a] = Arreglo[b];
            Arreglo[b] = Auxiliar;
        }

        public static void Shaker(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
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
                    if (orden(Arreglo[i - 1], Arreglo[i], campo)) // Comparación a través del delegado
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
                    if (orden(Arreglo[i - 1], Arreglo[i], campo)) // Comparación a través del delegado
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

        public static void BurbujaIzquierda(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
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
                    if (orden(Arreglo[j - 1], Arreglo[j], campo))  // Comparación a través del delegado
                    {
                        Intercambia(Arreglo, j - 1, j);  // Intercambio de datos
                        Movimientos++;
                    }
                }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        public static void BurbujaDerecha(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
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
                    if (orden(Arreglo[j], Arreglo[j + 1], campo)) // Comparación a través del delegado
                    {
                        Intercambia(Arreglo, j, j + 1); // Intercambio de datos
                        Movimientos++;
                    }
                }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        public static void BurbujaConSeñal(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
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
                    if (orden(Arreglo[j], Arreglo[j + 1], campo)) // Comparación a través del delegado
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

        public static void QuickSort(Maestro[] Arreglo, CriterioOrdenamiento Orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            // Primera llamada al método recursivo QSort() con el arreglo recibido
            QSort(Arreglo, 0, Arreglo.Length - 1, Orden, campo, ref Comparaciones, ref Movimientos);

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        private static void QSort(Maestro[] Arreglo, int Izquierdo, int Derecho, CriterioOrdenamiento Orden, Maestro.AtributoComparable campo, ref int Comparaciones, ref int Movimientos)
        {
            int i, d;
            Maestro Pivote;  // Declaración del Pivote

            // Inicializa el Pivote con el dato central del arreglo
            Pivote = Arreglo[(Izquierdo + Derecho) / 2];
            i = Izquierdo;
            d = Derecho;

            do
            {

                //orden(Arreglo[i - 1], Arreglo[i], campo)    Pivote.CompareTo(Arreglo[i]) > 0
                // Comparaciones de izquierda a derecha
                //while (Pivote > Arreglo[i])
                //{
                //    i++;
                //    Comparaciones++;
                //}

                //// Comparaciones de derecha a izquierda
                //while (Pivote.CompareTo(Arreglo[d]) < 0)
                //{
                //    d--;
                //    Comparaciones++;
                //}

                if (i <= d)
                {
                    Intercambia(Arreglo, i, d);  // Intercambio de datos
                    i++;
                    d--;
                    Movimientos++;
                }
            } while (i <= d);
            if (Izquierdo < d)
                QSort(Arreglo, Izquierdo, d, Orden, campo, ref Comparaciones, ref Movimientos);

            if (i < Derecho)
                QSort(Arreglo, d + 1, Derecho, Orden, campo, ref Comparaciones, ref Movimientos);
        }

        public static void Shell(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
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
                        if (orden(Arreglo[Posicion], Arreglo[Posicion + Salto], campo)) // Comparación a través del delegado
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

        public static void SeleccionDirecta(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            Maestro DatoSeleccionado;
            int i, j, PosicionDatoSeleccionado;

            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            for (i = 0; i <= Arreglo.Length - 2; i++)
            {
                DatoSeleccionado = Arreglo[i];
                PosicionDatoSeleccionado = i;

                for (j = i + 1; j <= Arreglo.Length - 1; j++)
                {
                    Comparaciones++;
                    if (orden(DatoSeleccionado, Arreglo[j], campo)) // Comparación a través del delegado
                    {
                        DatoSeleccionado = Arreglo[j];
                        PosicionDatoSeleccionado = j;
                    }
                }

                Arreglo[PosicionDatoSeleccionado] = Arreglo[i];
                Arreglo[i] = DatoSeleccionado;
                Movimientos++;
            }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        public static void InsercionDirecta(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            Maestro Dato;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            int j;
            for (int i = 1; i <= Arreglo.Length - 1; i++)
            {
                Dato = Arreglo[i];
                j = i - 1;

                Comparaciones++;
                while (j >= 0 && orden(Arreglo[j], Dato, campo)) // Comparación a través del delegado
                {
                    Arreglo[j + 1] = Arreglo[j];
                    j--;
                    Movimientos++;
                    Comparaciones++;
                }
                Arreglo[j + 1] = Dato;
                Movimientos++;
            }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        public static void InsercionBinaria(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            Maestro Dato;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            int j, PosicionCentral, Izquierdo, Derecho;

            for (int i = 1; i <= Arreglo.Length - 1; i++)
            {
                Dato = Arreglo[i];
                Izquierdo = 0;
                Derecho = i - 1;
                while (Izquierdo <= Derecho)
                {
                    PosicionCentral = (Izquierdo + Derecho) / 2;

                    // Comparación a través del delegado
                    if (orden(Arreglo[PosicionCentral], Dato, campo))
                        Derecho = PosicionCentral - 1;
                    else
                        Izquierdo = PosicionCentral + 1;

                    Comparaciones++;
                }

                for (j = i - 1; j >= Izquierdo; j--)
                {
                    Arreglo[j + 1] = Arreglo[j];
                    Movimientos++;
                }

                Arreglo[Izquierdo] = Dato;
                Movimientos++;
            }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        private static void AjustarArbol(Maestro[] Arreglo, int PosicionPadre, int Derecho, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, ref int Comparaciones, ref int Movimientos)
        {
            Maestro NodoPadre = Arreglo[PosicionPadre];
            int PosicionHijoMayor = PosicionPadre * 2;

            while (PosicionHijoMayor <= Derecho)
            {
                Comparaciones++;
                if (PosicionHijoMayor < Derecho && orden(Arreglo[PosicionHijoMayor + 1], Arreglo[PosicionHijoMayor], campo))
                    PosicionHijoMayor = PosicionHijoMayor + 1;

                Comparaciones++;
                if (orden(Arreglo[PosicionHijoMayor], NodoPadre, campo))
                {
                    Arreglo[PosicionPadre] = Arreglo[PosicionHijoMayor];
                    PosicionPadre = PosicionHijoMayor;
                    PosicionHijoMayor = PosicionPadre * 2;
                    Movimientos++;
                }
                else
                    break;
            }

            Arreglo[PosicionPadre] = NodoPadre;
            Movimientos++;
        }

        public static void HeapSort(Maestro[] Arreglo, CriterioOrdenamiento orden, Maestro.AtributoComparable campo, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
            // Inicializa los contadores de comparaciones y movimientos
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj para calcular el tiempo de ordenamiento
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            //Construye el árbol
            for (int i = (Arreglo.Length - 1) / 2; i >= 0; i--)
                AjustarArbol(Arreglo, i, Arreglo.Length - 1, orden, campo, ref Comparaciones, ref Movimientos);

            //Intercambia la raíz por el último nodo del árbol
            for (int i = Arreglo.Length - 1; i >= 1; i--)
            {
                Intercambia(Arreglo, 0, i); // Intercambio de la raíz con la celda i
                Movimientos++;
                AjustarArbol(Arreglo, 0, i - 1, orden, campo, ref Comparaciones, ref Movimientos);
            }

            // Finalización del reloj y cálculo del tiempo transcurrido
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }


        //Método principal que ordena el arreglo usando Radix Sort
        public static void RadixSort(Maestro[] arreglo, bool ascendente)
        {
            int tamaño = arreglo.Length;
            // Recorre el arreglo para obterner el valor máximo del arreglos
            // para sabr el número de dígitos
            int max = arreglo[0].Matricula;
            for (int i = 1; i < tamaño; i++)
            {
                if (arreglo[i].Matricula > max) max = arreglo[i].Matricula;
            }

            //Realiza el ordenamiento por conteo para cada dígito
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                if (ascendente) CountingSortAscendente(arreglo, tamaño, exp);
                else CountingSortDescendente(arreglo, tamaño, exp);
            }
        }

        //Método para ordenar con Counting sort el arreglo dado acorde
        //a exp(unidades, decenas, centenas, etc)
        public static void CountingSortAscendente(Maestro[] arreglo, int tamaño, int exp)
        {
            Maestro[] temp = new Maestro[tamaño]; //Arreglo temporal para almacenar la salida

            int i; //Contador de los ciclos

            //Creación de los buckets
            int[] count = new int[10];

            // Almacena el conteo de los digitos del arreglo en count[]
            for (i = 0; i < tamaño; i++)
            {
                count[(arreglo[i].Matricula / exp) % 10]++;
            }

            //Cambia count[i] para que contenga la posición actual
            //del digito en temp[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Coloca los elementos en orden
            for (i = tamaño - 1; i >= 0; i--)
                temp[--count[(arreglo[i].Matricula / exp) % 10]] = arreglo[i];

            //Copia el arreglo de salida al arreglo para que contenga los
            //elementos ordenados acorde al dígito acutal
            for (i = 0; i < tamaño; i++)
                arreglo[i] = temp[i];
        }

        public static void CountingSortDescendente(Maestro[] arreglo, int tamaño, int exp)
        {
            Maestro[] temp = new Maestro[tamaño]; //Arreglo temporal para almacenar la salida

            int i; //Contador de los ciclos

            //Creación de los buckets
            int[] count = new int[10];

            // Almacena el conteo de los digitos del arreglo en count[]
            for (i = 0; i < tamaño; i++)
                count[9 - arreglo[i].Matricula / exp % 10]++;

            //Cambia count[i] para que contenga la posición actual
            //del digito en temp[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Coloca los elementos en orden
            for (i = tamaño - 1; i >= 0; i--)
                temp[--count[9 - arreglo[i].Matricula / exp % 10]] = arreglo[i];

            //Copia el arreglo de salida al arreglo para que contenga los
            //elementos ordenados acorde al dígito acutal
            for (i = 0; i < tamaño; i++)
                arreglo[i] = temp[i];
        }
    }
}
