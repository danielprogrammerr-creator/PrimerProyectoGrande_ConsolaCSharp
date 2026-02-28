using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class Estetica
    {
       public static void TextoParpadeante(string texto)
        {
            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                Thread.Sleep(500);
                ColorAleatorio();
                Console.WriteLine(texto);
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                Thread.Sleep(500);
                Console.Clear();
            }
        }
        static void ColorAleatorio()
        {
            Random rnd = new Random();
            int color = rnd.Next(1, 7);
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
        }

        public static void Parpadeo(string texto)
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine(texto);
                Thread.Sleep(500);
                if (Console.KeyAvailable)
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Thread.Sleep(500);
                if (Console.KeyAvailable)
                {
                    Console.Clear();
                    break;
                }

            }
        }
    }
}

