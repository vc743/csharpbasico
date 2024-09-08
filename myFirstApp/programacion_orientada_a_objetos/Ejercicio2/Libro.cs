
namespace programacion_orientada_a_objetos.Ejercicio2
{
    internal class Libro
    {

        #region atributos
        private string _titulo;
        private string _autor;
        private int _paginas;
        #endregion

        #region propiedades
        public string Titulo
        {
            get { return _titulo; }
            set
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(_titulo));
                }
                _titulo = value; 
            }
        }

        public string Autor
        {
            get { return _autor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(_autor));
                }
                _autor = value;
            }
        }

        public int Paginas
        {
            get { return _paginas; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _paginas = value;
            }
        }
        #endregion

        #region metodos
        public void MostrarInformacion()
        {
            Console.WriteLine("\nInformacion del libro");
            Console.WriteLine($"Titulo:\t\t\t{Titulo}");
            Console.WriteLine($"Autor:\t\t\t{Autor}");
            Console.WriteLine($"Numero de paginas:\t{Paginas}");

            if (EsLargo())
            {
                Console.WriteLine("El libro es largo.");
            }
            else
            {
                Console.WriteLine("El libro no es largo.");
            }
        }

        public bool EsLargo()
        {
            return Paginas > 500 ? true : false;
        }
        #endregion

    }
}
