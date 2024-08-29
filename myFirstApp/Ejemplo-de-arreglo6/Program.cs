using System;
// Tirar 6000 veces un dado de seis lados.
namespace Ejemplo_de_arreglo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generador de numeros aleatorios.
            Random numerosAleatorios = new Random();

            //arreglo de contadores de frecuencia
            int[] frecuencia = new int[7];

            /* tira el dado 6000 veces; usa el valor
             del dado como subindice de frecuencia*/
            for ( int tiro = 1; tiro <= 6000; tiro++)
            {
                ++frecuencia[numerosAleatorios.Next(1, 7)];
            }

            Console.WriteLine( "{0}{1,10}", "Cara", "Frecuencia" );

            // imprime en pantalla el valor de cada elemento del arreglo
            for ( int cara = 1; cara < frecuencia.Length; cara++)
            {
                Console.WriteLine( "{0,4}{1,10}", cara, frecuencia[ cara ] );
            }
        }
    }
}
