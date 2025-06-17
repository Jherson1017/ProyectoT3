using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosInteractivos
{
    public class AdivinaLaPalabra
    {
        public void iniciar()
        {
            string[] palabras = { "perro", "sol", "agua", "libro", "escuela", "computadora" };
            string[] pistas = {
            "Es el mejor amigo del hombre",
            "Es una estrella que da calor",
            "Líquido esencial para la vida",
            "Objeto que lees para aprender o entretenerte",
            "Lugar donde estudian los niños",
            "La usas para programar"
             
        };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|============================================|" +
                            "\n|    ¡BIENVENIDO A DIVINA LAS 6 PALABRAS!    |" +
                            "\n|============================================|");
            Console.ResetColor();
            Console.WriteLine("Escribe 'salir' si deseas terminar el juego.\n");

            for (int i = 1; i < palabras.Length; i++)
            {
                string palabraSecreta = palabras[i];
                string pista = pistas[i];
                int intentos = 3;

                Console.Write("Palabra " + i + ": ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(pista);
                Console.ResetColor();
                Console.ResetColor();

                while (intentos > 0)
                {
                    Console.Write("Tu respuesta: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string respuesta = Console.ReadLine().ToLower();

                    if (respuesta == "salir")
                    {
                        Console.WriteLine("Has salido del juego.");
                        return;
                    }

                    if (respuesta == palabraSecreta)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Correcto! \n");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        intentos--;
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Incorrecto. Te quedan " + intentos + " intento(s).");
                        Console.ResetColor();
                    }
                }

                if (intentos == 0)
                {
                    Console.WriteLine(" La palabra era: " + palabraSecreta);
                }
            }
            Console.WriteLine("¡Juego terminado! Gracias por jugar.");
            Console.ReadKey();
        }
    }
}
