using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class Timer
    {
        public static void Temporizador()
        {
            Estetica.TextoParpadeante("_____  _____  __  __  ____    ___   ____   ___  _____   _    ____    ___   ____  \r\n|_   _|| ____||  \\/  ||  _ \\  / _ \\ |  _ \\ |_ _| |__  /  / \\  |  _ \\  / _ \\ |  _ \\ \r\n  | |  |  _|  | |\\/| || |_) || | | || |_) | | |    / /  / _ \\ | | | || | | || |_) |\r\n  | |  | |___ | |  | ||  __/ | |_| ||  _ <  | |   / /_ / ___ \\| |_| || |_| ||  _ < \r\n  |_|  |_____||_|  |_||_|     \\___/ |_| \\_\\|___| /____/_/   \\_\\____/  \\___/ |_| \\_\\");
            while (true)
            {
                Console.Clear();
                LetrasLento.Letras(12,"¿Que deseas hacer?\n1 - Añadir Temporizador\n2 - Volver");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        Tiempo();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        return;
                    default:
                        continue;
                }
            }
        }
        static void Tiempo()
        {
            bool tryParse;
            int val;
            int unSeg = 1000;
            do
            {
                Console.Clear();
                LetrasLento.Letras(20,"Añade el tiempo que quieras esperar(en segundos enteros).");
                tryParse = int.TryParse(Console.ReadLine(), out val);
            }while(!tryParse);
            val *= 1000;
            Console.Clear();
            LetrasLento.Letras(20,$"Presiona cualquier tecla para empezar.({val/1000} segs)");
            Lamb.clean();
            int contador = val / 1000;
            while (val >= 0)
            {
                Console.WriteLine($"TIEMPO: {contador}");
                Thread.Sleep(unSeg);
                val -= unSeg;
                contador--;
                Console.Clear();

            }
            Console.Beep();
            Console.WriteLine("CONTADOR FINALIZADO...\n(presiona cualquier tecla para continuar)");
            Lamb.clean();
        }
    } 
}
