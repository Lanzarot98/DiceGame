// Nombre estudiante: Luis Miguel Rojas Franco
// Grupo: 213022_48
// Programa: Ingeniería de Sistemas
// Código Fuente: autoría propia

namespace juegoDadosFase2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables:
            String player1, player2, player3;
            int score1, score2, score3;

            // Inputs de nombres y puntaje:
            Console.WriteLine("Ingrese el nombre del jugador 1: ");
            player1 = Console.ReadLine();
            while(!isValidName(player1))
            {
                Console.WriteLine("El nombre debe tener al menos 3 caracteres y solo contener letras. Ingrese el nombre del jugador 1: ");
                player1 = Console.ReadLine();
            }
            Console.WriteLine("Ingrese el puntaje del jugador 1: ");
            // validar que sea un número entero entre 1 y 6
            while (!Int32.TryParse(Console.ReadLine(), out score1) || score1 < 1 || score1 > 6)
            {
                Console.WriteLine("El puntaje debe ser un número entero entre 1 y 6. Ingrese el puntaje del jugador 1: ");
            }

            Console.WriteLine("Ingrese el nombre del jugador 2: ");
            player2 = Console.ReadLine();
            while (!isValidName(player2))
            {
                Console.WriteLine("El nombre debe tener al menos 3 caracteres y solo contener letras. Ingrese el nombre del jugador 2: ");
                player2 = Console.ReadLine();
            }
            Console.WriteLine("Ingrese el puntaje del jugador 2: ");
            // validar que sea un número entero entre 1 y 6
            while (!Int32.TryParse(Console.ReadLine(), out score2) || score2 < 1 || score2 > 6)
            {
                Console.WriteLine("El puntaje debe ser un número entero entre 1 y 6. Ingrese el puntaje del jugador 2: ");
            }

            Console.WriteLine("Ingrese el nombre del jugador 3: ");
            player3 = Console.ReadLine();
            while (!isValidName(player3))
            {
                Console.WriteLine("El nombre debe tener al menos 3 caracteres y solo contener letras. Ingrese el nombre del jugador 3: ");
                player3 = Console.ReadLine();
            }
            Console.WriteLine("Ingrese el puntaje del jugador 3: ");
            // validar que sea un número entero entre 1 y 6
            while (!Int32.TryParse(Console.ReadLine(), out score3) || score3 < 1 || score3 > 6)
            {
                Console.WriteLine("El puntaje debe ser un número entero entre 1 y 6. Ingrese el puntaje del jugador 3: ");
            }

            // Lógica para determinar el ganador:
            if (score1 > score2 && score1 > score3)
            {
                Console.WriteLine("El ganador es: " + player1 + " Con un puntaje de: " + score1 + " puntos.");
            }
            else if (score2 > score1 && score2 > score3)
            {
                Console.WriteLine("El ganador es: " + player2 + " Con un puntaje de: " + score2 + " puntos.");
            }
            else if (score3 > score1 && score3 > score2)
            {
                Console.WriteLine("El ganador es: " + player3 + " Con un puntaje de: " + score3 + " puntos.");
            }
            else
            {
                Console.WriteLine("Hubo un empate");
            }

        }
        // Método para validar que la variable player# contenga letras:
        static bool isValidName(string name)
        {
            // Comprobar que la cadena tenga al menos 3 caracteres
            if (name.Length < 3)
            {
                return false;
            }

            // Comprobar que todos los caracteres sean letras
            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }
    }

}
