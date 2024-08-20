namespace programacion_bucles_for.DimensionesDeTriangulos
{
    internal class CalcularDimensionesDeTriangulos
    {
        public void Calcular()
        {

            try
            {
                double limite = 10.0;
                int contador = 0;
                int numeroDeTriangulos = 0;
                double a = 0;
                double b = 0;
                double c = 0;
                string linea = string.Empty;


                // Solicitar al usuario el número de triángulos
                Console.Write("¿Cuántos triángulos deseas ingresar?: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero de triángulos a procesar es necesario.");
                    return;
                }

                if (!int.TryParse(linea, out numeroDeTriangulos))
                {
                    Console.WriteLine("Entrada invalida.");
                    return;
                }

                // Iterar para ingresar las dimensiones de cada triángulo
                for (int i = 0; i < numeroDeTriangulos; i++)
                {
                    Console.WriteLine($"Triángulo {i + 1}:");

                    // Pedir al usuario que ingrese los lados del triángulo
                    Console.Write("Ingresa el lado a: ");
                    linea = Console.ReadLine();

                    if (string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine("El lado a es requerido.");
                        return;
                    }

                    if (!double.TryParse(linea, out a))
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }

                    Console.Write("Ingresa el lado b: ");
                    linea = Console.ReadLine();

                    if (string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine("El lado b es requerido.");
                        return;
                    }

                    if (!double.TryParse(linea, out b))
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }

                    Console.Write("Ingresa el lado c: ");
                    linea = Console.ReadLine();

                    if (string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine("El lado c es requerido.");
                        return;
                    }

                    if (!double.TryParse(linea, out c))
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }

                    // Calcular el semiperímetro
                    double s = (a + b + c) / 2;

                    // Calcular el área usando la fórmula de Herón
                    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                    // Comparar área con el límite
                    if (area > limite)
                    {
                        contador++;
                    }
                }

                // Mostrar el resultado
                Console.WriteLine("Número de triángulos cuya área excede el límite: " + contador);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: { ex }");
            }
        }
    }
}
