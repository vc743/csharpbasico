﻿using System;
public class PruebaLibroCalificaciones
{
    // El método Main comienza la ejecución del programa
    public static void Main(string[] args)
    {
        // crea el objeto LibroCalificaciones
        LibroCalificaciones libroCalificaciones1 = new LibroCalificaciones("CS101 Introducción a la programación en C#");
        LibroCalificaciones libroCalificaciones2 = new LibroCalificaciones("CS102 Estructuras de datos en C#");
        
        // muestra el valor inicial de nombreCurso para cada LibroCalificaciones
        Console.WriteLine("El nombre del curso de libroCalificaciones1 es: {0}",
            libroCalificaciones1.NombreCurso);
        Console.WriteLine("El nombre del curso de libroCalificaciones2 es: {0}",
            libroCalificaciones2.NombreCurso);
    }
}