namespace programacion_condicional.PromedioDeCalificaciones
{
    internal class CalcularPromedioDeCalificaciones
    {
        public void Calcular()
        {
            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal nota3 = 0;
            decimal notaTotal = 0;
            decimal promedio = 0;
            string linea = string.Empty;

            try
            {

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Ingrese la nota {i}:");
                    linea = Console.ReadLine();
                    notaTotal += Convert.ToDecimal(linea);
                }

                promedio = notaTotal / 3;

                string mensaje = promedio >= 7 ? $"Aprobado con: {promedio}" 
                                               : $"Reprobado con: {promedio}";

                Console.WriteLine(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
