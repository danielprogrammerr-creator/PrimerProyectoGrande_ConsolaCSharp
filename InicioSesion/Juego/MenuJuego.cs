using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class MJ
    {
        public void MenuJuego()
        {
            Console.Clear();
            while (true)
            {
                LetrasLento.Letras(12, "¿Que deseas hacer?\n1 - ADIVNATOR\n2 - Juego 2 \n3 - Juego 3\n4 - Estadísticas\n5 - Volver");
            ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        Program.j1.Juego1();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        Estetica.TextoParpadeante("_____ ____ _____  _    ____ ___ ____ _____ ___ ____    _    ____  \r\n| ____/ ___|_   _|/ \\  |  _ \\_ _/ ___|_   _|_ _/ ___|  / \\  / ___| \r\n|  _| \\___ \\ | | / _ \\ | | | | |\\___ \\ | |  | | |     / _ \\ \\___ \\ \r\n| |___ ___) || |/ ___ \\| |_| | | ___) || |  | | |___ / ___ \\ ___) |\r\n|_____|____/ |_/_/   \\_\\____/___|____/ |_| |___\\____/_/   \\_\\____/\n(presiona cualquier tecla para continuar)");
                        Estadisticas.Stats();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        return;
                    default:
                        continue;
                }
            }
        }
    }
}
