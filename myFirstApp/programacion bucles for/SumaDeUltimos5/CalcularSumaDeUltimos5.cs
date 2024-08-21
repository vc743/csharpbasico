namespace programacion_bucles_for.SumaDeUltimos5
{
    internal class CalcularSumaDeUltimos5
    {
        public void Calcular()
        {
            try
            {
                int suma = 0;
                string linea = string.Empty;

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Ingrese un numero: ");
                    int numero;

                    if (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Write("Entrada invalida.");
                        return;
                    }

                    if (i >= 5)
                    {
                        suma += numero;
                    }

                }

                Console.WriteLine($"La suma de los ultimos 5 numeros es: { suma }");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex}");
            }
        }
    }
}
