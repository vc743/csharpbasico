namespace Programacion_secuencial.ArticuloyCantidad
{
    internal class CalcularProductoyCantidad
    {
        public void Calcular()
        {
            int precioDeArticulo = 0;
            int cantidadDeArticulos = 0;
            int abonoDelComprador = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Ingrese el precio del articulo:");
                linea = Console.ReadLine();

                if(!int.TryParse(linea, out precioDeArticulo))
                {
                    Console.WriteLine("El valor ingresado es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese la cantidad de articulos:");
                linea = Console.ReadLine();

                if(!int.TryParse(linea, out cantidadDeArticulos))
                {
                    Console.WriteLine("El valor de ingresado es invalido.");
                    return;
                }

                abonoDelComprador = (precioDeArticulo * cantidadDeArticulos);

                Console.WriteLine($"El comprador debe abonar {abonoDelComprador} pesos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
