using System;

namespace programaArray1
{
    internal class Program
    {

        private static int[] numeros;
        static void Main(string[] args)
        {
            MostrarNumeros();
        }

        static void MostrarNumeros()
        {
            numeros = new int[20];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i * 5;
                Console.WriteLine($"Numero en la posicion {i}: {numeros[i]}");
            }
        }
    }
}
