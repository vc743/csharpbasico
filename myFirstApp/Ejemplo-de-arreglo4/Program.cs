using System;
// calculo de la suma de los elementos de un arreglo.
namespace Ejemplo_de_arreglo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            //sumar el valor de elemento al total
            for ( int contador = 0; contador < arreglo.Length; contador++)
            {
                total += arreglo[contador];
            }

            Console.WriteLine("Total de los elementos del arreglo: {0}" , total );
        }
    }
}
