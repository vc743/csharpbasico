namespace programacion_bucles_for.DivisiblesPor3Y5
{
    internal class CalcularSiEsDivisible
    {
        public void Calcular()
        {
            // Conjunto de 10 numeros
            int[] numeros = { 15, 22, 33, 40, 57, 60, 71, 80, 90, 101 };

            int contador = 0;

            // Iterar sobre cada numero en el conjunto
            for (int i = 0; i < numeros.Length; i++)
            {
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
