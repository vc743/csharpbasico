using System;
using System.Xml.Serialization;

namespace programaArray2
{
    internal class Program
    {
        private static int[] matriz1;
        private static int[] matriz2;
        static void Main(string[] args)
        {
            CapturarValores();
        }

        static void CapturarValores()
        {
            try
            {

                Console.Write("Ingrese la longitud de la matriz 1: ");
                if(int.TryParse(Console.ReadLine(), out int longitudMatriz1))
                {
                    matriz1 = new int[longitudMatriz1];
                }
                else
                {
                    Console.WriteLine("Entrada invalida");
                    return;
                }

                Console.Write("Ingrese la longitud de la matriz 2: ");
                if (int.TryParse(Console.ReadLine(), out int longitudMatriz2))
                {
                    matriz2 = new int[longitudMatriz2];
                }
                else
                {
                    Console.WriteLine("Entrada invalida");
                    return;
                }

                string linea = string.Empty;

                Console.WriteLine("Valores de la matriz 1");
                for (int i = 0; i < matriz1.Length; i++)
                {
                    Console.Write($"Ingrese el valor {i}: ");
                    linea = Console.ReadLine();

                    if(int.TryParse(linea, out int elementoActual))
                    {
                        matriz1[i] = elementoActual;
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }
                }

                Console.WriteLine("Valores de la matriz 2");
                for (int i = 0; i < matriz2.Length; i++)
                {
                    Console.Write($"Ingrese el valor {i}: ");
                    linea = Console.ReadLine();

                    if (int.TryParse(linea, out int elementoActual))
                    {
                        matriz2[i] = elementoActual;
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }
                }

                if (ChequearIgualdad())
                {
                    Console.WriteLine("Las matrices son iguales.");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }

        static bool ChequearIgualdad()
        {
            if (matriz1.Length != matriz2.Length)
            {
                return false;
            }

            for (int i = 0; i < matriz1.Length; i++)
            {
                if (matriz1[i] != matriz2[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
