namespace programacion_bucles_while.AreasDeTriangulos
{
    internal class CalcularAreaDeTriangulos
    {
        public void Calcular()
        {
			try
			{
                int i = 0;
                int numeroDetriangulos;
                int baseTriangulo;
                int altura;
                int area;
                int areasMayoresA12 = 0;
                string linea = string.Empty;

                Console.Write("Ingrese el numero de triangulos a procesar: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero de triangulos es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out numeroDetriangulos))
                {
                    Console.WriteLine("Entrada invalida.");
                    return;
                }

                while (i < numeroDetriangulos)
                {
                    Console.Write($"Ingrese la base del triangulo { i + 1 }: ");
                    linea = Console.ReadLine();

                    if (string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine("La base del triangulo es requerida.");
                        return;
                    }

                    if (!int.TryParse(linea, out baseTriangulo))
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }

                    Console.Write($"Ingrese la altura del triangulo {i + 1}: ");
                    linea = Console.ReadLine();

                    if (string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine("La altura del triangulo es requerida.");
                        return;
                    }

                    if (!int.TryParse(linea, out altura))
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }

                    area = (baseTriangulo * altura) / 2;

                    Console.WriteLine($"\nTriangulo { i + 1 }:\nbase:\t{baseTriangulo}\naltura:\t{altura}\narea:\t{ area }\n");

                    if(area > 12)
                    {
                        areasMayoresA12++;
                    }

                    i++;
                }

                Console.WriteLine($"Cantidad de triangulos con areas mayores a 12: { areasMayoresA12 }");

			}
			catch (Exception ex)
			{
                Console.Write($"Ocurrio un error: { ex }");
			}
        }
    }
}
