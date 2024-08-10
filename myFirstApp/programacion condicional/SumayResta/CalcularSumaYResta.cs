namespace programacion_condicional.SumayResta
{
    internal class CalcularSumaYResta
    {
        public void Calcular()
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal suma = 0;
            decimal resta = 0;
            decimal producto = 0;
            decimal division = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Ingrese el primer valor:");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El primer valor es requerido.");
                    return;
                }

                if(!decimal.TryParse(linea, out num1))
                {
                    Console.WriteLine("El primer valor es invalido.");
                    return;
                }
                else
                {
                    num1 = Convert.ToInt32(linea);
                }

                Console.WriteLine("Ingrese el segundo valor:");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El segundo valor es requerido");
                    return;
                }

                if(!decimal.TryParse(linea, out num2))
                {
                    Console.WriteLine("El segundo valor es invalido.");
                    return;
                }
                else
                {
                    num2 = Convert.ToInt32(linea);
                }

                if(num1 > num2)
                {
                    suma = (num1 + num2);
                    resta = (num1 - num2);

                    Console.WriteLine($"La suma es igual a {suma} y la resta es igual a {resta}");
                }
                else
                {
                    producto = (num1 * num2);
                    division = (num1 / num2);
                    Console.WriteLine($"El producto es igual a {producto} y la division es igual a {division}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
