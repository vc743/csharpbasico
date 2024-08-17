namespace programacion_bucles_for.DivisiblesPor3Y5
{
    internal class CalcularSiEsDivisible
    {
        public void Calcular()
        {
            // Conjunto de 10 numeros
            int[] numeros = new int[10];
            string linea = string.Empty;

            int contador = 0;

            // Iterar sobre cada numero en el conjunto
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out numeros[i]))
                {
                    Console.WriteLine("Entrada invalida.");
                    return;
                }

                // Verificar si el numero actual cumple con una de las condiciones
                if (numeros[i] % 3 == 0 || numeros[i] % 5 == 0)
                {
                    contador++;
                }
            }

            // Mostrar el resultado
            Console.WriteLine($"Numeros de elementos divisibles por 3 y por 5: {contador}");
        }
    }
}
