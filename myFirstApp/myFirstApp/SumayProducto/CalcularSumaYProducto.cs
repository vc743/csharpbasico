namespace Programacion_secuencial.SumayProducto
    ///<summary>
    /// Calcular el producto y suma de dos numeros.
    /// </summary>
{
    public class CalcularSumaYProducto
    {

        /// <summary>
        /// Mostrar el producto y suma a partir de dos numeros.
        /// </summary>

        public void Calcular()
        {
            //Declaracion de variables
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int producto = 0;
            string linea = string.Empty;

            try
            {
                //Pedir numeros por teclado
                Console.WriteLine("Ingrese el primer valor:");
                linea = Console.ReadLine();

                //Validar el tipo de dato
                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el segundo valor:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                suma = num1 + num2;
                producto = num1 * num2;

                Console.WriteLine($"La suma es {suma} y el producto es {producto}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error {ex.Message}.");
            }
        }
    }
}
