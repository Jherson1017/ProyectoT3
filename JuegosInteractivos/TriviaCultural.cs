using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosInteractivos
{
    public class TriviaCultural
    {
        public void Iniciar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Beep(400, 300);
            Console.Beep(350, 300);
            Console.Beep(300, 300);
            Console.Beep(400, 300);
            Console.Beep(350, 300);
            Console.Beep(300, 300);
            Console.WriteLine("|===================================================|" +
                            "\n|    ¡BIENVENIDO A LA TRIVIA DE CULTURA GENERAL!    |" +
                            "\n|===================================================|");
            Console.ResetColor();
            Console.WriteLine("Responde las preguntas correctamente y demuestra tus conocimientos.");
            Console.WriteLine("Presiona cualquier tecla para comenzar...");
            Console.ReadKey();
            Console.Clear();
            int puntaje = 0;
            puntaje += Pregunta("1. ¿Capital de Francia?", "A) Berlín", "B) París", "C) Roma", "B");
            puntaje += Pregunta("2. ¿Quién pintó la Mona Lisa?", "A) Van Gogh", "B) Picasso", "C) Da Vinci", "C");
            puntaje += Pregunta("3. ¿Cuál es el océano más grande?", "A) Atlántico", "B) Índico", "C) Pacífico", "C");
            puntaje += Pregunta("4. ¿Cuál es el planeta más grande del sistema solar?", "A) Marte", "B) Júpiter", "C) Saturno", "B");
            puntaje += Pregunta("5. ¿Quién escribió 'Cien años de soledad'?", "A) Vargas Llosa", "B) Borges", "C) García Márquez", "C");
            puntaje += Pregunta("6. ¿Cuál es el símbolo químico del oro?", "A) Ag", "B) Au", "C) Pb", "B");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Tu puntaje final fue " + puntaje);
            Console.ResetColor();
            if (puntaje == 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Perfecto! Eres un genio de la cultura.");
                Console.Beep(1000, 300);
                Console.Beep(1200, 300);
                Console.Beep(1500, 500);
            }
            else if (puntaje >= 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¡Muy bien! Estas en algo");
                Console.Beep(1000, 300);
                Console.Beep(1200, 300);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERES MALISIMO!");
                Console.Beep(600, 300);
                Console.Beep(500, 300);
            }

            Console.ResetColor();
            Console.WriteLine("\nPresiona una tecla para volver al menú...");
            Console.ReadKey();
        }

        public int Pregunta(string enunciado, string opcionA, string opcionB, string opcionC, string correcta)
        {
            Console.WriteLine("\n" + enunciado);
            Console.WriteLine(opcionA);
            Console.WriteLine(opcionB);
            Console.WriteLine(opcionC);
            Console.Write("Respuesta: ");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta == correcta)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Correcto!");
                Console.Beep(900, 200);
                Console.ResetColor();
                return 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrecto.");
                Console.Beep(300, 300);
                Console.ResetColor();
                return 0;
            }
        }
    }
}

