using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_4
{
    class Ordenar
    {

        //Método principal que ordena el arreglo usando Radix Sort
        public static void RadixSort(Empleado[] arreglo, bool ascendente)
        {
            int tamaño = arreglo.Length;
            // Recorre el arreglo para obterner el valor máximo del arreglos
            // para sabr el número de dígitos
            int max = arreglo[0].Edad;
            for (int i = 1; i < tamaño; i++)
            {
                if (arreglo[i].Edad > max) max = arreglo[i].Edad;
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
        private static void CountingSortAscendente(Empleado[] arreglo, int tamaño, int exp)
        {
            Empleado[] temp = new Empleado[tamaño]; //Arreglo temporal para almacenar la salida

            int i; //Contador de los ciclos

            //Creación de los buckets
            int[] count = new int[10];

            // Almacena el conteo de los digitos del arreglo en count[]
            for (i = 0; i < tamaño; i++)
            {
                count[(arreglo[i].Edad / exp) % 10]++;
            }

            //Cambia count[i] para que contenga la posición actual
            //del digito en temp[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Coloca los elementos en orden
            for (i = tamaño - 1; i >= 0; i--)
                temp[--count[(arreglo[i].Edad / exp) % 10]] = arreglo[i];

            //Copia el arreglo de salida al arreglo para que contenga los
            //elementos ordenados acorde al dígito acutal
            for (i = 0; i < tamaño; i++)
                arreglo[i] = temp[i];
        }

        private static void CountingSortDescendente(Empleado[] arreglo, int tamaño, int exp)
        {
            Empleado[] temp = new Empleado[tamaño]; //Arreglo temporal para almacenar la salida

            int i; //Contador de los ciclos

            //Creación de los buckets
            int[] count = new int[10];

            // Almacena el conteo de los digitos del arreglo en count[]
            for (i = 0; i < tamaño; i++)
                count[9 - arreglo[i].Edad / exp % 10]++;

            //Cambia count[i] para que contenga la posición actual
            //del digito en temp[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Coloca los elementos en orden
            for (i = tamaño - 1; i >= 0; i--)
                temp[--count[9 - arreglo[i].Edad / exp % 10]] = arreglo[i];

            //Copia el arreglo de salida al arreglo para que contenga los
            //elementos ordenados acorde al dígito acutal
            for (i = 0; i < tamaño; i++)
                arreglo[i] = temp[i];
        }



    }







}

