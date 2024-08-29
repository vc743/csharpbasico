﻿using System;
// aplicacion para analizar encuestas.
namespace Ejemplo_de_arreglo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arreglo de respuestas a la encuesta
            int[] respuestas = {
                1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6,
                10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7, 5, 6, 6, 
                5, 6, 7, 5, 6, 4, 8, 6, 8, 10 };

            // arreglo de contadores de frecuencia
            int[] frecuencia = new int[11];

            /*para cada respuesta, selecciona el elemento de respuestas y usa ese valor
             como subindice de frecuencia para determinar el elemento a incrementar*/
            for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
            {
                ++frecuencia[respuestas[respuesta]];
            }

            Console.WriteLine("{0}{1,11}", "Calificacion", "Frecuencia");

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int calificacion = 1; calificacion < frecuencia.Length; calificacion++)
            {
                Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia[calificacion]);
            }
        }
    }
}
