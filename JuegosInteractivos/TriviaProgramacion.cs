using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosInteractivos
{
     public class TriviaProgramacion
    {
        public void Iniciar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep(500, 300);
            Console.Beep(550, 300);
            Console.Beep(600, 300);
            Console.WriteLine("|=====================================================|" +
                            "\n|     ¡BIENVENIDO A LA TRIVIA DE PROGRAMACIÓN!        |" +
                            "\n|=====================================================|");
            Console.ResetColor();
            Console.WriteLine("Demuestra cuánto sabes sobre desarrollo y lenguajes.");
            Console.WriteLine("Presiona cualquier tecla para comenzar...");
            Console.ReadKey();
            Console.Clear();

            int puntaje = 0;

            puntaje += Pregunta("1. ¿Qué lenguaje se usa principalmente para aplicaciones Android?",
                                "A) Kotlin", "B) Swift", "C) Python", "A", "Kotlin");
            puntaje += Pregunta("2. ¿Qué símbolo se usa para comentarios en C#?",
                                "A) //", "B) #", "C) <!-- -->", "A", "//");
            puntaje += Pregunta("3. ¿Qué estructura de control permite repetir un bloque de código?",
                                "A) if", "B) while", "C) switch", "B", "while");
            puntaje += Pregunta("4. ¿Qué es una 'variable'?",
                                "A) Una función sin retorno", "B) Una constante",
                                "C) Un espacio para almacenar datos", "C", "Un espacio para almacenar datos");
            puntaje += Pregunta("5. ¿Cuál de estos es un lenguaje de programación?",
                                "A) HTML", "B) CSS", "C) Java", "C", "Java");
            puntaje += Pregunta("6. ¿Qué tipo de dato representa valores verdaderos o falsos?",
                                "A) int", "B) bool", "C) string", "B", "bool");
            puntaje += Pregunta("7. ¿Qué palabra clave en C# se usa para declarar una clase?",
                                "A) new", "B) var", "C) class", "C", "class");
            puntaje += Pregunta("8. ¿Cuál es el operador de igualdad en C#?",
                                "A) =", "B) ==", "C) ===", "B", "==");
            puntaje += Pregunta("9. ¿Cuál es la estructura correcta para un bucle 'for' en C#?", "A) for (int i = 0; i < 10; i++)",
                                "B) for i = 0 to 10", "C) for i < 10", "A", "for (int i = 0; i < 10; i++)");
            puntaje += Pregunta("10. ¿Qué hace Console.ReadLine() en C#?",
                                "A) Escribe texto en pantalla", 
                                "B) Lee una línea del teclado", 
                                "C) Lee una línea de un archivo",
                                "B", "Lee una línea del teclado");
            puntaje += Pregunta("11. ¿Qué lenguaje es más usado en desarrollo web del lado del cliente?",
                                "A) JavaScript","B) Python","C) C#","A", "JavaScript");
            puntaje += Pregunta("12. ¿Qué extensión tienen los archivos de código fuente en C#?",
                                "A) .java", "B) .cs", "C) .cpp", "B", ".cs");
            puntaje += Pregunta("13. ¿Qué tipo de estructura es un array?",
                                "A) Un tipo de dato lógico",
                                "B) Un tipo de función",
                                "C) Una colección de elementos",
                                "C", "Una colección de elementos");
            puntaje += Pregunta("14. ¿Cuál de los siguientes es un lenguaje compilado?",
                                "A) Java", "B) HTML", "C) CSS", "A", "Java");
            puntaje += Pregunta("15. ¿Qué es Git?",
                                "A) Un editor de texto",
                                "B) Un sistema de control de versiones",
                                "C) Un lenguaje de programación",
                                "B", "Un sistema de control de versiones");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTu puntaje final fue: " + puntaje + " / 15");
            Console.ResetColor();
            if (puntaje == 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Increíble! ¡Eres un crack de la programación!");
                Console.Beep(1000, 300);
                Console.Beep(1200, 300);
                Console.Beep(1500, 500);
            }
            else if (puntaje >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("¡Muy bien! Vas por buen camino.");
                Console.Beep(1000, 300);
                Console.Beep(1100, 300);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Necesitas practicar más. ¡No te rindas!");
                Console.Beep(400, 300);
                Console.Beep(350, 300);
            }
            Console.ResetColor();
            Console.WriteLine("\nPresiona una tecla para volver al menú...");
            Console.ReadKey();
        }
        public int Pregunta(string enunciado, string opcionA, string opcionB, string opcionC, string correcta, string textoCorrecto)
        {
            Console.WriteLine("\n" + enunciado);
            Console.WriteLine(opcionA);
            Console.WriteLine(opcionB);
            Console.WriteLine(opcionC);
            Console.Write("Respuesta : ");
            string respuesta = Console.ReadLine().ToUpper();

            while (respuesta != "A" && respuesta != "B" && respuesta != "C")
            {
                Console.Write("Respuesta inválida. Intenta con A, B o C: ");
                respuesta = Console.ReadLine().ToUpper();
            }

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
                Console.WriteLine("Incorrecto. La respuesta correcta es: " + textoCorrecto);
                Console.Beep(300, 300);
                Console.ResetColor();
                return 0;
            }
        }
    }
}
