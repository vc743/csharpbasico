
namespace programacion_orientada_a_objetos.Ejercicio3
{
    internal class Alumno
    {
        #region atributos
        private string _nombre;
        private string _matricula;
        private string _carrera;
        private List<int> _calificaciones;
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(_nombre));
                }
                _nombre = value;
            }
        }

        public string Matricula
        {
            get { return _matricula; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(_matricula));
                }
                _matricula = value;
            }
        }

        public string Carrera
        {
            get { return _carrera; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(_carrera));
                }
                _carrera = value;
            }
        }

        public List<int> Calificaciones
        {
            get { return _calificaciones; }
            set 
            {
                _calificaciones = value;
            }
        }

        #endregion

        #region metodos
        public decimal CalcularPromedio()
        {
            decimal promedio = 0;
            int suma = 0;

            for (int i = 0; i < Calificaciones.Count; i++)
            {
                suma += Calificaciones[i];
            }

            promedio = suma / Calificaciones.Count;

            return promedio;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre:\t\t{Nombre}");
            Console.WriteLine($"Matricula:\t{Matricula}");
            Console.WriteLine($"Carrera:\t{Carrera}");
            Console.WriteLine($"Promedio:\t{CalcularPromedio()}\n");
        }

        #endregion
    }
}
