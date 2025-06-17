using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegosInteractivos;

namespace ProyectoT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=======================================");
                Console.WriteLine("         MENÚ DE JUEGOS INTERACTIVOS   ");
                Console.WriteLine("=======================================");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("[1] El juego de la fábrica de juguetes embrujada");
                Console.WriteLine("[2] Trivia de Cultura General");
                Console.WriteLine("[3] Piedra, Papel o Tijera");
                Console.WriteLine("[4] Tres en raya");
                Console.WriteLine("[0] Salir");
                Console.ResetColor();
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        new SupervivenciaZombi().Iniciar();
                        break;
                    case "2":
                        new TriviaCultural().Iniciar();
                        break;
                    case "3":
                        new JuegoPPT().Inicio();
                        break;
                    case "4":
                        new TresEnRaya().Iniciar();
                        break;
                    case "0":
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("¡GRACIAS POR JUGAR!");
                        Console.ResetColor();
                        Console.WriteLine("Presiona una tecla para salir...");
                        Console.ReadKey();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción no válida. Intenta otra vez.");
                        Console.ResetColor();
                        break;
                }
                Console.WriteLine("Presiona una tecla para volver al menú");
                Console.ReadKey();
            }
                    
        }

    }
}
