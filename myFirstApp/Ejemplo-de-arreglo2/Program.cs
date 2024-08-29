﻿using System;
// Inicializacion de los elementos de un arreglo, mediante un inicializador de arreglos.
namespace Ejemplo_de_arreglo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // la lista inicializadora especifica el valor para cada elemento
            int[] arreglo = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

            Console.WriteLine( "{0}{1,8}", "Indice", "Valor" ); //encabezados

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                Console.WriteLine( "{0,5}{1,8}", contador, arreglo[contador] );
            }
        }
    }
}
