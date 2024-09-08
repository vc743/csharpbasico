
namespace programacion_orientada_a_objetos.Ejercicio1
{
    internal class PuntoEnElPlano
    {

        private int x;
        private int y;

        #region metodos
        public void CargarValores()
        {

            try
            {
                Console.Write("Ingrese el valor de x: ");
                if (int.TryParse(Console.ReadLine(), out int valorDeX))
                {
                    x = valorDeX;
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    return;
                }

                Console.Write("Ingrese el valor de y: ");
                if (int.TryParse(Console.ReadLine(), out int valorDeY))
                {
                    y = valorDeY;
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    return;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}");
            }

        }

        public void ImprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el primer cuadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el segundo cuadrante.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el tercer cuadrante.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el cuarto cuadrante.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("El punto esta sobre el eje Y.");
            }
            else if (y == 0 && x != 0){
                Console.WriteLine("El punto esta sobre el eje X.");
            }
            else
            {
                Console.WriteLine("El punto esta en el origen.");
            }
        }
        #endregion
    }
}
