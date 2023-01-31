using System;

namespace Ordenamiento_shell_shor_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0; 
            
            Console.WriteLine("introduzca la cantidad de arreglos !");

            cantidad= int.Parse(Console.ReadLine());  

            int [] arreglo  = new int[cantidad];
            int salto = arreglo.Length / 2;
            bool Bandera = true;
            int posicion = 0; 


            while(salto >0)
            {
                Bandera = true; 
                while(Bandera == true)
                {
                    Bandera = false;
                    posicion = 0; 
                }

                while(posicion < arreglo[cantidad] - salto  )
                {
                    if(arreglo[posicion] > arreglo[posicion+salto] )
                    {
                       

                    }
                }
            }
         

            
                


        }
    }
}
