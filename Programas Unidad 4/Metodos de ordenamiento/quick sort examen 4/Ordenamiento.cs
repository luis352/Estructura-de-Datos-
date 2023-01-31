using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_4
{
    class Ordenamiento<Tipo> where Tipo : IComparable<Tipo>
    {
        
        public delegate bool CriterioOrdenamiento(Tipo x, Tipo y);

        
        public static bool Ascendente(Tipo x, Tipo y)
        {
            if (x.CompareTo(y) > 0)
                return (true);
            else
                return (false);
        }

       
        public static bool Descendente(Tipo x, Tipo y)
        {
            if (x.CompareTo(y) < 0)
                return (true);
            else
                return (false);
        }

       
        private static void Intercambia(Tipo[] Arreglo, int a, int b)
        {
            Tipo Auxiliar; 

            Auxiliar = Arreglo[a];
            Arreglo[a] = Arreglo[b];
            Arreglo[b] = Auxiliar;
        }


        public static void QuickSort(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int Comparaciones, out int Movimientos, out int MiliSegundos)
        {
           
            Comparaciones = 0;
            Movimientos = 0;

            // Inicia el reloj
            System.Diagnostics.Stopwatch Reloj = System.Diagnostics.Stopwatch.StartNew();

            // Primera llamada al método recursivo QSort() 
            QSort(Arreglo, 0, Arreglo.Length - 1, Orden, ref Comparaciones, ref Movimientos);

            // Finalización 
            MiliSegundos = Reloj.Elapsed.Milliseconds;
        }

        private static void QSort(Tipo[] Arreglo, int Izquierdo, int Derecho, CriterioOrdenamiento Orden, ref int Comparaciones, ref int Movimientos)
        {
            int i, d;
            Tipo Pivote; 

            
            Pivote = Arreglo[(Izquierdo + Derecho) / 2];
            i = Izquierdo;
            d = Derecho;

            do
            {
               
                if (Orden.Method.Name.Equals("Ascendente"))
                {
                    
                    while (Pivote.CompareTo(Arreglo[i]) > 0)
                    {
                        i++;
                        Comparaciones++;
                    }

                    
                    while (Pivote.CompareTo(Arreglo[d]) < 0)
                    {
                        d--;
                        Comparaciones++;
                    }
                }
                else  
                {
                    
                    while (Pivote.CompareTo(Arreglo[i]) < 0)
                    {
                        i++;
                        Comparaciones++;
                    }

                    
                    while (Pivote.CompareTo(Arreglo[d]) > 0)
                    {
                        d--;
                        Comparaciones++;
                    }
                }

                if (i <= d)
                {
                    Intercambia(Arreglo, i, d);  
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
