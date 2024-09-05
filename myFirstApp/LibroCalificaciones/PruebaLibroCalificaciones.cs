// Crea un objeto LibroCalificaciones y llama a su método MostrarMensaje.
using System;

public class PruebaLibroCalificaciones
{
    // El método Main comienza la ejecución del programa
    public static void Main(string[] args)
    {
        // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

        // pide el nombre del curso y lo recibe como entrada
        Console.WriteLine("Por favor escriba el nombre del curso:");
        string nombreDelCurso = Console.ReadLine(); // lee una línea de texto
        Console.WriteLine(); // imprime en pantalla una línea en blanco

        // llama al método MostrarMensaje de miLibroCalificaciones 
        // y pasa nombreDelCurso como argumento
        miLibroCalificaciones.MostrarMensaje(nombreDelCurso);
    }
}