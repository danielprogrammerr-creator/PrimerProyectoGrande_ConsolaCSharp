using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class LetrasLento
    {
        public static void Letras(int velocidad, string texto)
        {
            for(int i = 0; i < texto.Length; i++) 
            {
                Console.Write(texto[i]);
                Thread.Sleep(velocidad);
            }
            Console.WriteLine();
        }
    }
}
