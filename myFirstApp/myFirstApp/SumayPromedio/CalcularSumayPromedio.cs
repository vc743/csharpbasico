namespace Programacion_secuencial.SumayPromedio
{
    internal class CalcularSumayPromedio
    {
        public void Calcular()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma = 0;
            int promedio = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Ingrese el primer numero:");
                linea = Console.ReadLine();

                if(!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el segundo numero:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el tercer numero:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out num3))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el cuarto numero:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out num4))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                suma = (num1 + num2 + num3 + num4);
                promedio = (num1 + num2 + num3 + num4) / (4);

                Console.WriteLine($"La suma es {suma} y el promedio es {promedio}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
