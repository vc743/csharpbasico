using System;
// Inicialización de arreglos rectangulares y dentados.
namespace Ejemplo_de_arreglos_bidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // con los arreglos rectangulares,
            // cada columna debe tener la misma longitud.
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };

            // con los arreglos dentados,
            // necesitamos usar "new int[]" para cada fila,
            // pero cada columna no necesita tener la misma longitud.
            int[][] dentado = { new int[] { 1, 2 },
                                new int[] { 3 },
                                new int[] { 4, 5, 6 } };

            ImprimirArreglo(rectangular); // muestra el arreglo rectangular por fila
            Console.WriteLine(); // imprime una línea en blanco
            ImprimirArreglo(dentado); // muestra el arreglo dentado por fila
        }

        public static void ImprimirArreglo(int[,] arreglo)
        {
            Console.WriteLine("Los valores en el arreglo rectangular por fila son");

            // itera a través de las filas del arreglo
            for (int fila = 0; fila < arreglo.GetLength(0); fila++)
            {
                // itera a través de las columnas de la fila actual
                for (int columna = 0; columna < arreglo.GetLength(1); columna++)
                    Console.Write("{0} ", arreglo[fila, columna]);

                Console.WriteLine(); // inicia nueva línea de salida
            }
        }

        // imprime filas y columnas de un arreglo dentado
        public static void ImprimirArreglo(int[][] arreglo)
        {
            Console.WriteLine( "Los valores en el arreglo dentado por fila son" );
            
            // itera a través de las filas del arreglo
            for (int fila = 0; fila<arreglo.Length; fila++ )
            {
                // itera a través de las columnas de la fila actual
                for (int columna = 0; columna<arreglo[fila].Length; columna++ )
                    Console.Write( "{0} ", arreglo[fila][columna] );
                
                Console.WriteLine(); // inicia nueva línea de salida
            }
        }
    }
}
