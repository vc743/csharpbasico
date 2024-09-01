using System;

namespace Caso_de_estudio_simulacion_barajar_repartir_cartas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaqueteDeCartas miPaqueteDeCartas = new PaqueteDeCartas();
            miPaqueteDeCartas.Barajar(); // coloca las cartas en orden aleatorio
            
            // imprime las 52 cartas en el orden en el que se reparten
            for (int i = 0; i < 13; i++)
            {
                // reparte e imprime 4 objetos Carta
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}",
                    miPaqueteDeCartas.RepartirCarta(), miPaqueteDeCartas.RepartirCarta(),
                    miPaqueteDeCartas.RepartirCarta(), miPaqueteDeCartas.RepartirCarta());
                }
        }
    }

    // La clase Carta representa una carta de juego.
    public class Carta
    {
        private string cara; // cara de la carta ("As", "Dos", ...)
        private string palo; // palo de la carta ("Corazones", "Diamantes", ...)

        // el constructor con dos parámetros inicializa la cara y el palo de la carta
        public Carta(string caraCarta, string paloCarta)
        {
            cara = caraCarta; // inicializa la cara de la carta
            palo = paloCarta; // inicializa el palo de la carta
        }

        // devuelve representación de cadena del objeto Carta
        public override string ToString()
        {
            return cara + " de " + palo;
        }
    }

    public class PaqueteDeCartas
    {
        private Carta[] paquete; // arreglo de objetos Carta
        private int cartaActual; // subíndice de la siguiente Carta a repartir
        private const int NUMERO_DE_CARTAS = 52; // constante para el número de objetos Carta
        private Random numerosAleatorios; // generador de números aleatorios

        // el constructor llena el paquete de objetos Carta
        public PaqueteDeCartas()
        {
            string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", "Seis",
                "Siete", "Ocho", "Nueve", "Diez", "Joto", "Qüina", "Rey" };

            string[] palos = { "Corazones", "Diamantes", "Tréboles", "Espadas" };

            paquete = new Carta[NUMERO_DE_CARTAS]; // crea un arreglo de objetos Carta
            cartaActual = 0; // establece cartaACtual para que la primera Carta repartida sea paquete[0]

            numerosAleatorios = new Random(); // crea el generador de números aleatorios

            // llena el paquete con objetos Carta
            for (int cuenta = 0; cuenta < paquete.Length; cuenta++)
                paquete[cuenta] = new Carta(caras[cuenta % 13], palos[cuenta / 13]);
        }

        // baraja el paquete de objetos Carta con un algoritmo de una pasada
        public void Barajar()
        {
            // después de barajar, la repartición debe empezar otra vez en paquete[ 0 ]
            cartaActual = 0; // reinicializa cartaActual

            // para cada Carta, selecciona otra Carta aleatoria y las intercambia
            for (int primera = 0; primera<paquete.Length; primera++)
            {
                // selecciona un número aleatorio entre 0 y 51
                int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);
                // intercambia la Carta actual con la Carta seleccionada al azar
                Carta temp = paquete[primera];
                paquete[primera] = paquete[segunda];
                paquete[segunda] = temp;
            }
        }

        // reparte una Carta
        public Carta RepartirCarta()
        {
            // determina si hay objetos Carta por repartir
            if (cartaActual<paquete.Length )
                return paquete[cartaActual++]; // devuelve la Carta actual en el arreglo
            else
                return null; // devuelve null para indicar que se repartieron todos los objetos Carta
        }
    }
}