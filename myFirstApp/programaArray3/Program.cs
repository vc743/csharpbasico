using System;

namespace programaArray3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int numeroElementos;
                int[] numeros;
                string linea = string.Empty;

                Console.WriteLine("Cuantos numeros desea ingresar?");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido");
                    return;
                }

                if (!int.TryParse(linea, out numeroElementos))
                {
                    Console.WriteLine("Entrada invalida");
                    return;
                }

                numeros = new int[numeroElementos];

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write($"Ingrese el numero {i + 1}: ");
                    linea = Console.ReadLine();

                    if (int.TryParse(linea, out int elementoActual))
                    {
                        numeros[i] = elementoActual;
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }
                }

                int menor = numeros[0];
                for (int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                }

                bool hayRepetidos = false;
                for (int i = 0; i < numeros.Length - 1; i++)
                {
                    for (int j = i + 1; j < numeros.Length; j++)
                    {
                        if (numeros[i] == numeros[j])
                        {
                            hayRepetidos = true;
                            break;
                        }
                    }
                    if (hayRepetidos) break;
                }

                Console.WriteLine($"El menor valor ingresado es: {menor}");

                if (hayRepetidos)
                {
                    Console.WriteLine("Al menos un numero se repite");
                }
                else
                {
                    Console.WriteLine("No hay numeros repetidos");
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine($"Error: { ex.Message}");
			}
        }
    }
}
