using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JuegosInteractivos
{
    public class TresEnRaya
    {       
        private char[,] tablero = new char[3, 3];
        private Random random = new Random();
        public void Iniciar()
        {
            Console.Beep(400, 300);
            Console.Beep(600, 300);
            Console.Beep(800, 300);
            Console.Beep(1000, 500);
            Console.Beep(1200, 700);
            InicializarTablero();
            bool juegoTerminado = false;
            int turnos = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|==================================|" +
                            "\n|    Tres en Raya vs Computadora   |" +
                            "\n|==================================|");
            Console.ResetColor();
            Console.Write("Tú eres ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("X");
            Console.ResetColor();
            Console.Write(", la computadora es ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("O");
            Console.ResetColor();
            Console.WriteLine("Presiona ENTER para comenzar...");
            Console.ReadLine();
            while (!juegoTerminado && turnos < 9)
            {
                Console.Clear();
                MostrarTablero();
                if (turnos % 2 == 0)
                {
                    Console.Write("\nTu turno (elige una casilla del 1 al 9): ");
                    string entrada = Console.ReadLine();
                    if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 9)
                    {
                        if (MarcarCasilla(eleccion, 'X'))
                        {
                            turnos++;
                            if (VerificarGanador('X'))
                            {
                                Console.Clear();
                                MostrarTablero();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Beep(1000, 200);
                                Console.Beep(1200, 200);
                                Console.Beep(1400, 200);
                                Console.WriteLine("\n¡Ganaste!");
                                Console.ResetColor();
                                juegoTerminado = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Casilla ocupada. Presiona ENTER para intentar otra vez.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Presiona ENTER para intentar otra vez.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("\nTurno de la computadora...");
                    System.Threading.Thread.Sleep(1000);
                    int jugada = JugarComputadora();
                    turnos++;
                    if (VerificarGanador('O'))
                    {
                        Console.Clear();
                        MostrarTablero();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Beep(400, 500);
                        Console.Beep(350, 500);
                        Console.WriteLine("\n¡La computadora ganó!");
                        Console.ResetColor();
                        juegoTerminado = true;
                    }
                }
            }
            if (!juegoTerminado)
            {
                Console.Clear();
                MostrarTablero();
                Console.Beep(600, 400);
                Console.Beep(700, 400);
                Console.Beep(600, 400);
                Console.WriteLine("\n¡Empate!");
            }
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
        }
        private void InicializarTablero()
        {
            char valor = '1';
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tablero[i, j] = valor++;
        }
        private void MostrarTablero()
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    char c = tablero[i, j];
                    if (c == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(c);
                        Console.ResetColor();
                    }
                    else if (c == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(c);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(c);
                    }
                    Console.Write(" | ");
                }
                Console.WriteLine("\n-------------");
            }
        }
        private bool MarcarCasilla(int posicion, char jugador)
        {
            int fila = (posicion - 1) / 3;
            int columna = (posicion - 1) % 3;
            if (tablero[fila, columna] != 'X' && tablero[fila, columna] != 'O')
            {
                tablero[fila, columna] = jugador;
                return true;
            }
            return false;
        }
        private bool VerificarGanador(char jugador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador) return true;
                if (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador) return true;
            }
            if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador) return true;
            if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador) return true;
            return false;
        }
        private int JugarComputadora()
        {
            int casilla;
            do
            {
                casilla = random.Next(1, 10);
            }
            while (!MarcarCasilla(casilla, 'O'));
            return casilla;
        }
    }
}
