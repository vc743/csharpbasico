namespace programacion_bucles_while.PiezasDeHierro
{
    internal class CalcularPiezasDeHierro
    {
        public void Calcular()
        {
            int contadorPiezas = 0;
            int piezasAptas = 0;
            int cantidadPiezas = 0;
            string linea = string.Empty;

            Console.Write("Ingresa la cantidad de piezas en el lote: ");
            linea = Console.ReadLine();

            if (string.IsNullOrEmpty(linea))
            {
                Console.WriteLine("El valor es requerido.");
                return;
            }

            if(!int.TryParse(linea, out cantidadPiezas))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un valor numerico.");
                return;
            }


            Console.Write("Ingresa la longitud minima aceptable: ");
            linea = Console.ReadLine();
            double longitudMinima;

            if (string.IsNullOrEmpty(linea))
            {
                Console.WriteLine("El valor es requerido");
                return;
            }

            if (!double.TryParse(linea, out longitudMinima))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un valor numerico.");
                return;
            }

            Console.Write("Ingresa la longitud maxima aceptable: ");
            linea = Console.ReadLine();
            double longitudMaxima;

            if (string.IsNullOrEmpty(linea))
            {
                Console.WriteLine("El valor es requerido");
                return;
            }

            if (!double.TryParse(linea, out longitudMaxima))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un valor numerico.");
                return;
            }

            while (contadorPiezas < cantidadPiezas)
            {
                Console.Write("Ingrese la longitud de la pieza: ");
                double longitudPieza;

                // Validacion para la longitud de la pieza
                if (double.TryParse(Console.ReadLine(), out longitudPieza))
                {
                    if (longitudPieza >= longitudMinima && longitudPieza <= longitudMaxima)
                    {
                        piezasAptas++;
                    }
                    contadorPiezas++;
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Por favor, ingrese un valor numerico.");
                }
            }

            Console.WriteLine($"Cantidad de piezas aptas para fabricar perfiles: {piezasAptas}");
        }
    }
}
