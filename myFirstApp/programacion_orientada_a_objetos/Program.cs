#region Ejercicio 1
//using programacion_orientada_a_objetos.Ejercicio1;

//PuntoEnElPlano oPuntoEnElPlano = new PuntoEnElPlano();

//oPuntoEnElPlano.CargarValores();
//oPuntoEnElPlano.ImprimirCuadrante();
#endregion


#region Ejercicio 2
//using programacion_orientada_a_objetos.Ejercicio2;
//MostrarInfoLibro();
//void MostrarInfoLibro()
//{
//    try
//    {
//        Libro oLibro = new Libro();

//        Console.Write("Ingrese el titulo del libro: ");
//        oLibro.Titulo = Console.ReadLine();

//        Console.Write("Ingrese el nombre del autor: ");
//        oLibro.Autor = Console.ReadLine();

//        Console.Write("Ingrese el numero de paginas del libro: ");
//        oLibro.Paginas = Convert.ToInt32(Console.ReadLine());

//        oLibro.MostrarInformacion();
//        oLibro.EsLargo();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ocurrio un error: {ex.Message}");
//    }
//}
#endregion


#region Ejercicio 3
using programacion_orientada_a_objetos.Ejercicio3;

try
{
    Alumno oAlumno1 = new Alumno();
    oAlumno1.Nombre = "Victor Alejandro";
    oAlumno1.Matricula = "2020";
    oAlumno1.Carrera = "Ingenieria de software";
    oAlumno1.Calificaciones = [80, 90, 100, 90, 87];
    oAlumno1.MostrarInformacion();

    Alumno oAlumno2 = new Alumno();
    oAlumno2.Nombre = "Pedro Perez";
    oAlumno2.Matricula = "2023";
    oAlumno2.Carrera = "Administracion de empresas";
    oAlumno2.Calificaciones = [70, 96, 77, 80, 87];
    oAlumno2.MostrarInformacion();

    Alumno oAlumno3 = new Alumno();
    oAlumno3.Nombre = "Rafael Martinez";
    oAlumno3.Matricula = "2022";
    oAlumno3.Carrera = "Arquitectura";
    oAlumno3.Calificaciones = [86, 79, 91, 88, 70];
    oAlumno3.MostrarInformacion();
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio un error: {ex.Message}");
}
#endregion