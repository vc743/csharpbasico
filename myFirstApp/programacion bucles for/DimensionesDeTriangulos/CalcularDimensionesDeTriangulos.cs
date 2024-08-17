namespace programacion_bucles_for.DimensionesDeTriangulos
{
    internal class CalcularDimensionesDeTriangulos
    {
        public void Calcular()
        {
            //Validar las entradas

            // Solicitar al usuario el número de triángulos
            Console.Write("¿Cuántos triángulos deseas ingresar?: ");
            int numeroDeTriangulos = int.Parse(Console.ReadLine());

            // Límite de área
            double limite = 10.0;
            int contador = 0;

            // Iterar para ingresar las dimensiones de cada triángulo
            for (int i = 0; i < numeroDeTriangulos; i++)
            {
                Console.WriteLine($"Triángulo {i + 1}:");

                // Pedir al usuario que ingrese los lados del triángulo
                Console.Write("Ingresa el lado a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado c: ");
                double c = double.Parse(Console.ReadLine());

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
    }
}
