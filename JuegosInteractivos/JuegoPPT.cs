using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosInteractivos
{
    public class JuegoPPT
    {
        public void Inicio()
        {
            Console.Beep(400, 300);
            Console.Beep(600, 300);
            Console.Beep(800, 300);
            Console.Beep(1000, 500);
            Console.Beep(1200, 700);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|===============================|" +
                            "\n|    PIEDRA , PAPEL O TIJERA    |" +
                            "\n|===============================|");
            Console.ResetColor();
            Console.WriteLine();
            int puntospalJugador = 0;
            int puntosComputadora = 0;
            int rondas = 0;
            string opcion1 = "piedra";
            string opcion2 = "papel";
            string opcion3 = "tijera";
            Random random = new Random();
            while (rondas < 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Escribe: piedra, papel o tijera:");
                Console.Write("elegiste: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                string jugador = Console.ReadLine();
                Console.ResetColor();
                if (jugador != opcion1 && jugador != opcion2 && jugador != opcion3)
                {
                    Console.WriteLine("Opción incorrecta:");
                }
                string computadora = "";
                int num = random.Next(1, 4);
                if (num == 1)
                    computadora = opcion1;
                else if (num == 2)
                    computadora = opcion2;
                else
                    computadora = opcion3;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Computadora eligió: " + computadora);
                Console.ResetColor();
                if (jugador == computadora)
                {
                    Console.Beep(600, 400);
                    Console.Beep(700, 400);
                    Console.Beep(600, 400);
                    Console.WriteLine("Empate.");
                }
                else if ((jugador == "piedra" && computadora == "tijera") ||
                         (jugador == "papel" && computadora == "piedra") ||
                         (jugador == "tijera" && computadora == "papel"))
                {
                    Console.WriteLine("¡Ganaste!");
                    puntospalJugador++;
                    Console.Beep(1000, 200);
                    Console.Beep(1200, 200);
                    Console.Beep(1400, 200);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Perdiste.");
                    Console.Beep(400, 500);
                    Console.Beep(350, 500);
                    Console.ResetColor();
                    puntosComputadora++;
                }
                rondas++;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Puntaje: Tú " + puntospalJugador + " - Computadora " + puntosComputadora);
                Console.ResetColor();
            }
            if (puntospalJugador == puntosComputadora)
            {
                Console.Beep(600, 400);
                Console.Beep(700, 400);
                Console.Beep(600, 400);
                Console.WriteLine("EMPATE TOTAL - Se jugará una ronda extra para definir al ganador.");
                while (true)
                {
                    Console.WriteLine("Ronda extra - Escribe piedra, papel o tijera:");
                    string jugador = Console.ReadLine().ToLower();
                    if (jugador != opcion1 && jugador != opcion2 && jugador != opcion3)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }
                    string computadora = "";
                    int num = random.Next(1, 4);
                    if (num == 1)
                        computadora = opcion1;
                    else if (num == 2)
                        computadora = opcion2;
                    else
                        computadora = opcion3;
                    Console.WriteLine("Computadora eligió: " + computadora);
                    Console.WriteLine("Empate otra vez!!! Se repite la ronda extra (´0´)");
                    if (jugador == computadora)
                    {
                        Console.Beep(600, 400);
                        Console.Beep(700, 400);
                        Console.Beep(600, 400);
                    }
                    else if ((jugador == "piedra" && computadora == "tijera") ||
                             (jugador == "papel" && computadora == "piedra") ||
                             (jugador == "tijera" && computadora == "papel"))
                    {
                        Console.WriteLine("Ganaste la ronda extra （＾▿＾）");
                        puntospalJugador++;
                        Console.Beep(1000, 200);
                        Console.Beep(1200, 200);
                        Console.Beep(1400, 200);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Perdiste la ronda extra (×̯×).");
                        puntosComputadora++;
                        break;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("===RESULTADO FINAL===");

            Console.WriteLine("Tú: " + puntospalJugador + " - Computadora: " + puntosComputadora);

            if (puntospalJugador > puntosComputadora)
                Console.WriteLine("Ganaste el juego  (^<>^) ");
            else
                Console.WriteLine("Perdiste el juego :(  ");
            Console.Beep(350, 600);
            Console.Beep(300, 600);

            Console.WriteLine("Gracias por jugar :V");
            Console.ResetColor();
        }
    }
}

