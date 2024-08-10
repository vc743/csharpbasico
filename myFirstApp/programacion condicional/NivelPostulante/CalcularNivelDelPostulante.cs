namespace programacion_condicional.NivelPostulante
{
    internal class CalcularNivelDelPostulante
    {
        public void Calcular()
        {
            int totalPreguntas = 0;
            int respuestasCorrectas = 0;
            double porcentaje = 0;
            string nivel;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Ingrese el numero total de preguntas:");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero de preguntas es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out totalPreguntas))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el numero de repuestas correctas:");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero de respuestas correctas es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out respuestasCorrectas))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                porcentaje = (double)respuestasCorrectas / totalPreguntas * 100;

                if (porcentaje >= 90)
                {
                    nivel = "Nivel maximo";
                }
                else if(porcentaje >= 75)
                {
                    nivel = "Nivel medio";
                }
                else if(porcentaje >= 50)
                {
                    nivel = "Nivel regular";
                }
                else
                {
                    nivel = "Fuera de nivel";
                }

                Console.WriteLine($"porcentaje: {porcentaje}");
                Console.WriteLine($"El nivel del postulante es: {nivel}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
