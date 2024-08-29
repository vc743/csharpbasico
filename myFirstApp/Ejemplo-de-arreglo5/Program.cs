using System;
// Aplicacion para imprimir graficos de barras
namespace Ejemplo_de_arreglo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

            Console.WriteLine("Distribucion de las calificaciones:");

            //para cada elemento del arreglo, mostrar en pantalla una barra del grafico

            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                //muestra etiquetas de las barras ( "00-09: ", ..., "90-99: ", "100: " )
                if (contador == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write( "{0:D2}-{1:D2}: ", contador * 10, contador * 10 + 9 );
                }

                // Imprime barra de asteriscos
                for (int estrellas = 0; estrellas < arreglo[ contador ]; estrellas++)
                {
                    Console.Write( '*' );
                }

                Console.WriteLine();
            }

        }
    }
}
