namespace programacion_bucles_while.SumaYPromedio
{
    internal class CalcularSumaYPromedio
    {
        public void Calcular()
        {
            int suma = 0;
            int contador = 0;
            int cantidadNumeros = 10;
            string linea = string.Empty;

            while (contador < cantidadNumeros)
            {
                Console.WriteLine("Ingrese un numero:");
                linea = Console.ReadLine();
                int numero;

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out numero))
                {
                    Console.WriteLine("El valor es invalido.");
                    return;
                }

                suma += numero;
                contador++;
            }

            double promedio = (double)suma / cantidadNumeros;

            Console.WriteLine($"La suma es igual a: {suma}");
            Console.WriteLine($"El promedio es igual a: {promedio}");
        }
    }
}
