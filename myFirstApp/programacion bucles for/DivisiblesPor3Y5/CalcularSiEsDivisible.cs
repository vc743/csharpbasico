namespace programacion_bucles_for.DivisiblesPor3Y5
{
    internal class CalcularSiEsDivisible
    {
        public void Calcular()
        {

            try
            {
                string linea = string.Empty;

                int contador = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Ingrese un numero: ");
                    linea = Console.ReadLine();
                    int numero;

                    if (string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine("El valor es requerido.");
                        return;
                    }

                    if (!int.TryParse(linea, out numero))
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }

                    if (numero % 3 == 0 || numero % 5 == 0)
                    {
                        contador++;
                    }
                }

                Console.WriteLine($"Numeros de elementos divisibles por 3 y por 5: {contador}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: { ex }");
            }
        }
    }
}
