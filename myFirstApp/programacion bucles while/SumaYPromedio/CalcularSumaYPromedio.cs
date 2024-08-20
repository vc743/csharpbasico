namespace programacion_bucles_while.SumaYPromedio
{
    internal class CalcularSumaYPromedio
    {
        public void Calcular()
        {

            try
            {
                int suma = 0;
                int contador = 0;
                int cantidadNumeros = 10;
                string linea = string.Empty;

                while (contador < cantidadNumeros)
                {
                    Console.Write("Ingrese un numero:");
                    linea = Console.ReadLine();
                    int numero;

                    if (int.TryParse(linea, out numero))
                    {
                        suma += numero;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida. Por favor, ingrese un valor numerico.");
                    }

                }

                double promedio = (double)suma / cantidadNumeros;

                Console.WriteLine($"La suma es igual a: {suma}");
                Console.WriteLine($"El promedio es igual a: {promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: { ex }");
            }

        }
    }
}
