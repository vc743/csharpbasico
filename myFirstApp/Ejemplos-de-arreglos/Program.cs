using System;
//Creacion de un arreglo.
namespace Ejemplo_de_arreglo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara un arreglo llamado arreglo
            int[] arreglo;

            //crea el espacio para el arreglo y lo inicializa con ceros predeterminados
            arreglo = new int[10]; //10 elementos int

            Console.WriteLine( "{0}{1,8}", "Indice", "Valor" );

            // imprime por pantalla el valor de cada elemento del arreglo
            for ( int contador = 0; contador < arreglo.Length; contador++)
            {
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[ contador ]);
            }
        }
    }
}
