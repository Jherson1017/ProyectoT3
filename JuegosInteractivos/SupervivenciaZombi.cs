using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JuegosInteractivos
{
    public class SupervivenciaZombi
    {
        public void Iniciar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Beep(400, 300);
            Console.Beep(350, 300); 
            Console.Beep(300, 300);
            Console.WriteLine("|===================================================|" +
                            "\n|    EL JUEGO DE LA FÁBRICA DE JUGUETES EMBRUJADA   |" +
                            "\n|===================================================|");
            Console.ResetColor();
            Console.WriteLine("Despiertas en una casa oscura... escuchas gruñidos...");
            Console.WriteLine("¡Un juguetes embrujada te ha visto y viene por ti!");
            Console.WriteLine("¡Debes escapar resolviendo acertijos para sobrevivir!");
            Console.WriteLine("Presiona una tecla para comenzar tu huida...");
            Console.ReadKey();
            if (!PrimerHabitacion()) return;
            if (!SegundoPasillo()) return;
            if (!SalaFinal()) return;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep(700, 200);
            Console.Beep(800, 200); 
            Console.Beep(1000, 500);
            Console.WriteLine("\n¡Lo lograste! Escapaste de la casa y sobreviviste. ");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.WriteLine("Presiona una tecla para regresar al menú...");
            Console.ReadKey();
        }
        private bool PrimerHabitacion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Llegas a una puerta con un candado digital...");
            Console.ResetColor();
            Console.WriteLine("Para abrirla, resuelve este acertijo:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Esta criatura camina con cuatro patas por la mañana,\ndos al mediodía y tres por la noche.");
            Console.ResetColor();
            Console.Write("Tu respuesta: ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta.Contains("humano"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ¡Correcto! La puerta se abre y entras al siguiente pasillo.");
                Console.Beep(900, 300);
                Thread.Sleep(2000);
                Console.ResetColor();
                return true;
            }
            else
            {
                Derrota("El juguetes embrujada te alcanza y te devora.");
                return false;
            }
        }
        private bool SegundoPasillo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Una trampa con flechas te bloquea el paso.");
            Console.ResetColor();
            Console.WriteLine("Resuelve este acertijo para desactivarla:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Este objeto no se puede ver, ni oír, ni tocar.\nLlena una habitación, pero no deja huella al pasar.");
            Console.ResetColor();
            Console.Write("Tu respuesta: ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta.Contains("oscuridad"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Acertaste! Saltas la trampa justo a tiempo.");
                Console.Beep(950, 300);
                Thread.Sleep(2000);
                Console.ResetColor();
                return true;
            }
            else
            {
                Derrota("Las flechas se disparan... y no sobrevives.");
                return false;
            }
        }
        private bool SalaFinal()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Entras a la última sala... el juguetes embrujada está justo detrás.");
            Console.ResetColor();
            Console.WriteLine("Solo una puerta te puede salvar. Tiene un enigma escrito:");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("¿Qué sube pero nunca baja?");
            Console.ResetColor();
            Console.Write("Tu respuesta: ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta.Contains("edad"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Correcto! Cruzas la puerta y la cierras justo a tiempo.");
                Console.Beep(1000, 400); Console.Beep(1200, 400);
                Thread.Sleep(2000);
                Console.ResetColor();
                return true;
            }
            else
            {
                Derrota("El juguetes embrujada te atrapa en la sala final.");
                return false;
            }
        }

        private void Derrota(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep(300, 300); Console.Beep(250, 400); Console.Beep(200, 500);
            Console.WriteLine(mensaje);
            Thread.Sleep(2500);
            Console.ResetColor();
            Console.WriteLine("Presiona una tecla para regresar al menú...");
            Console.ReadKey();
        }
    }
}

