using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class LetrasLento
    {
        public static void Letras(int velocidad, string texto)
        {
            string texto2;
            for (int i = 0; i < texto.Length; i++) 
            {
                if(Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    Console.Write(texto.Substring(i));
                    break;
                }
                Console.Write(texto[i]);
                Thread.Sleep(velocidad);
            }
            Console.WriteLine();
        }
    }
}
