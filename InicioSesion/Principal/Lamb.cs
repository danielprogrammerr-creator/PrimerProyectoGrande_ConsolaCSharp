using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class Lamb
    {
        public static Action<string> error = texto =>
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.White;
        };
        public static Action<string> good = texto =>
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.White;
        };
        public static Action clean = () => 
        {
            Console.ReadKey();
            Console.Clear();
        };

    }
}
