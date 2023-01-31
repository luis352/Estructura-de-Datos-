using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort_Estudiantes
{
     class ShellSort
    {
        public delegate bool CriterioOrdenamiento(Estudiante x, Estudiante y, Estudiante.AtributoComparable campo);

        public static bool Ascendente(Estudiante x, Estudiante y, Estudiante.AtributoComparable campo) 
        {

            if (campo(x,y)>0)
            {
                return true;
            }
            return false;
        }

        public static bool Descendente(Estudiante x, Estudiante y, Estudiante.AtributoComparable campo)
        {
            if (campo(x, y) < 0)
            {
                return true;
            }
            return false;
        }

        public static void Ordenar(Estudiante[] arreglo, CriterioOrdenamiento orden, Estudiante.AtributoComparable campo,ref int Comp, ref int Inter) 
        {
            int Npasos = arreglo.Length / 2;
            Estudiante aux;
            bool Bandera;
            int x=1;


            while (Npasos>0)
            {
                do
                {
                    Bandera = false;
                    x = 1;
                    while (x <= arreglo.Length-Npasos)
                    {
                        Comp++;
                        if (orden(arreglo[x-1],arreglo[(x-1)+Npasos],campo) )
                        {
                            Inter++;
                            aux = arreglo[(x - 1) + Npasos];
                            arreglo[(x - 1) + Npasos] = arreglo[x - 1];
                            arreglo[x - 1] = aux;
                            Bandera = true;
                            
                        }
                        x++;
                    }
                } while (Bandera);



                Npasos /= 2;
            }

        }

    }
}
