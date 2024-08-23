namespace programacion_bucles_for.SueldosDeEmpleados
{
    internal class CalcularSueldosDeEmpleados
    {
        public void Calcular()
        {
			try
			{
                int numeroDeEmpleados;
                int sueldo;
                int contador100_300 = 0;
                int contadorMas300 = 0;
                int gastoTotal = 0;
                string linea = string.Empty;

                Console.Write("Ingrese el numero de empleados en la empresa: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero de empleados es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out numeroDeEmpleados))
                {
                    Console.WriteLine("Entrada invalida.");
                    return;
                }

                for (int i = 0; i < numeroDeEmpleados; i++)
                {
                    Console.Write($"Ingrese el sueldo del empleado { i + 1 }: ");
                    linea = Console.ReadLine();

                    if (string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine("El sueldo del empleado es requerido.");
                        return;
                    }

                    if (!int.TryParse(linea, out sueldo))
                    {
                        Console.WriteLine("Entrada invalida.");
                        return;
                    }

                    if (sueldo >= 100 && sueldo <= 300)
                    {
                        contador100_300++;

                    } else if (sueldo > 300)
                    {
                        contadorMas300++;
                    }

                    gastoTotal += sueldo;
                }

                Console.WriteLine($"Empleados con sueldo entre $100 y $300: { contador100_300 }");
                Console.WriteLine($"Empleados con sueldo mayor a $300: {contadorMas300}");
                Console.WriteLine($"Gasto total en sueldos: { gastoTotal }");

			}
			catch (Exception ex)
			{
                Console.WriteLine($"Ocurrio un error: { ex }");
			}
        }
    }
}
