using System;

namespace ShellSort
{
    class Program
    {

        static void ShellSort(ref int[] Arreglo, ref int Comparaciones,ref int Intercambios) 
        {
            int Npasos = Arreglo.Length/2;
            
            int aux = 0;
            int x=0;
            bool Bandera;

            while (Npasos>0)
            {
                
                do
                {


                    Bandera = false;



                    // Muestra de datos
                    for (int i = 0; i < Arreglo.Length; i++)
                    {
                        Console.Write("[{0}] ", Arreglo[i].ToString("D2"));
                        x++;
                        if (Npasos <= x)
                        {
                            Console.WriteLine();
                            x = 0;
                        }

                    }





                    x = 1;
                    //Si T - Comparacion n
            while (x <= (Arreglo.Length-Npasos))
            {
                        Comparaciones++;

                        //Si T - Intercambio
                if (Arreglo[x-1] > Arreglo[(x-1)+Npasos])
                {
                    aux = Arreglo[(x - 1) + Npasos];
                    Arreglo[(x - 1) + Npasos] = Arreglo[x - 1];
                    Arreglo[x - 1] = aux;
                            Bandera = true;
                            Intercambios++;
                }
                x++;
            }

                    x = 0;
                    Console.WriteLine("\n");
                } while (Bandera);
                Console.WriteLine("Comparaciones: " + Comparaciones);
                Console.WriteLine("Intercambios: " + Intercambios);
                Npasos = Npasos / 2;
        

            }
            Console.WriteLine("Datos ordenados");
        }


        static void ShellSortGrafico(ref int[] Arreglo, ref int Comparaciones, ref int Intercambios)
        {
            int Npasos = Arreglo.Length / 2;

            int aux = 0;
            int x = 0;
            bool Bandera;

            while (Npasos > 0)
            {

                do
                {
                   // Muestra de datos
                    for (int i = 0; i < Arreglo.Length; i++)
                    {
                        Console.Write("[{0}] ", Arreglo[i].ToString("D2"));
                        x++;
                        if (Npasos <= x)
                        {
                            Console.WriteLine();
                            x = 0;
                        }

                    }

                    Bandera = false;




                    x = 1;
                    //Si T - Comparacion n
                    while (x <= (Arreglo.Length - Npasos))
                    {
                        Comparaciones++;

                        //Si T - Intercambio
                        if (Arreglo[x - 1] > Arreglo[(x - 1) + Npasos])
                        {
                            aux = Arreglo[(x - 1) + Npasos];
                            Arreglo[(x - 1) + Npasos] = Arreglo[x - 1];
                            Arreglo[x - 1] = aux;
                            Bandera = true;
                            Intercambios++;
                        }
                        x++;
                    }

                    x = 0;
                    Console.WriteLine("\n");
                } while (Bandera);
                Console.WriteLine("Comparaciones: " + Comparaciones);
                Console.WriteLine("Intercambios: " + Intercambios);
                Npasos = Npasos / 2;


            }
        }












        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Random random = new Random();
            int Comparaciones = 0, Intercambios = 0;
            int[] Arreglo=null;
            do
            {

                System.Diagnostics.Stopwatch TiempoOperacion = new System.Diagnostics.Stopwatch();
                Console.Clear();
                Console.WriteLine("***************************");
                Console.WriteLine("1.Generar Ejemplo");
                Console.WriteLine("2.Generar numeros aleatorios");
                Console.WriteLine("3.Mostrar orden actual");
                Console.WriteLine("4.Aplicar Shell Sort");
            
                Console.WriteLine("0.Salir");
                Console.WriteLine("***************************");
                Console.WriteLine("\n\nTeclee su opcion");
                cki = Console.ReadKey(true);
                Console.Clear();
                switch (cki.KeyChar)
                {
                    case '1':
                        Arreglo = new int[10] { 99, 75, 44, 12, 38, 54, 79, 41, 3, 16 };
                        Console.WriteLine(Arreglo.Length + " Numeros generados");
                        break;
                    case '2':

                        
                        int n = random.Next(20,50 );
                        Arreglo = new int[n];
                        for (int i = 0; i < Arreglo.Length; i++)
                        {
                            Arreglo[i] = random.Next(0, 10);
                        }
                        Console.WriteLine(Arreglo.Length+" Numeros generados al azar");
                        
                        break;
                    case '3':
                        foreach (int i in Arreglo)
                        {
                            Console.Write("[{0}] ",i.ToString("D2"));
                        }
                        
                        break;
                    case '4':
                        TiempoOperacion.Start();
                        ShellSort(ref Arreglo,ref Comparaciones,ref Intercambios);
                        TiempoOperacion.Stop();
                        Console.ReadKey(true);
                        
                        //Mostrar estadisticas
                        Console.Clear();
                        Console.WriteLine($"Tiempo: {TiempoOperacion.Elapsed.TotalMilliseconds} ms");
                        Console.WriteLine("Comparaciones realizadas: "+Comparaciones);
                        Console.WriteLine("Intercambios realizados: "+Intercambios);
                        break;
                   
                }


                Console.ReadKey(true);

            } while (cki.KeyChar != '0');
            Console.Clear();
            Console.WriteLine("Saliendo...");
        }
    }
}
