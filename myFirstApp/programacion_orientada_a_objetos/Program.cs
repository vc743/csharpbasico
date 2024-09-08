#region Ejercicio 1
//using programacion_orientada_a_objetos.Ejercicio1;

//PuntoEnElPlano oPuntoEnElPlano = new PuntoEnElPlano();

//oPuntoEnElPlano.CargarValores();
//oPuntoEnElPlano.ImprimirCuadrante();
#endregion


#region Ejercicio 2
using programacion_orientada_a_objetos.Ejercicio2;
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
#endregion


#region Ejercicio 3
#endregion