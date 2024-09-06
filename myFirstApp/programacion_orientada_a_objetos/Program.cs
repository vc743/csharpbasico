
using programacion_orientada_a_objetos.Ejercicio1;

MostrarInfoLibro();

void MostrarInfoLibro()
{
    try
    {
        Libro oLibro = new Libro();

        Console.Write("Ingrese el titulo del libro: ");
        oLibro.Titulo = Console.ReadLine();

        Console.Write("Ingrese el nombre del autor: ");
        oLibro.Autor = Console.ReadLine();

        Console.Write("Ingrese el numero de paginas del libro: ");
        oLibro.Paginas = Convert.ToInt32(Console.ReadLine());

        oLibro.MostrarInformacion();
        oLibro.EsLargo();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrio un error: {ex.Message}");
    }
}