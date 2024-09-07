using System;
// Declaracion de una clase con un metodo
public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso para este LibroCalificaciones

    // el constructor inicializa nombreCurso con el objeto string suministrado como argumento
    public LibroCalificaciones( string nombre)
    {
        NombreCurso = nombre; //inicializa nombreCurso usando la propiedad
    }

    // propiedad para obtener (get) y establecer (set) el nombre del curso
    public string NombreCurso
    {
        get { return nombreCurso; }
        set { nombreCurso = value; }
    }

    // Muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
    public void MostrarMensaje()
    {
        Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!", NombreCurso);
    }

}
