namespace programacion_bucles_for.SumaDeUltimos5
{
    internal class CalcularSumaDeUltimos5
    {
        public void Calcular()
        {
            int[] numeros = new int[10];
            string linea = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;

            for (int i = 5;i < 10; i++)
            {
                suma += numeros[i];
            }

            Console.WriteLine($"La suma de los ultimos 5 numeros es: {suma}");
        }
    }
}
