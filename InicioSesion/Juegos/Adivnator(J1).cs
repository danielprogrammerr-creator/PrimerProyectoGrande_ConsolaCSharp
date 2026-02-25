
using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    //Elegir número random
    class JuegoUno
    {
        Random rnd = new Random();
        int dificultad;
        int intentos;
        int obtencionPuntos;
        public void Juego1()
        {
            Estetica.TextoParpadeante("___  ______ _____ _   _ _ _   _  ___ _____ ___________ \r\n / _ \\ |  _  \\_   _| | | | | \\ | |/ _ \\_   _|  _  | ___ \\\r\n/ /_\\ \\| | | | | | | | | | |  \\| / /_\\ \\| | | | | | |_/ /\r\n|  _  || | | | | | | | | | | . ` |  _  || | | | | |    / \r\n| | | || |/ / _| |_ \\ \\_/ /| |\\  | | | || | \\ \\_/ / |\\ \\ \r\n\\_| |_/|___/  \\___/  \\___/ \\_| \\_\\_| |_/\\_/  \\___/\\_| \\_| \n(presiona cualquier tecla para seguir)");
            while (true)
            {
                LetrasLento.Letras(12, "--ADIVNATOR--\n¿Que deseas hacer?\n1 - Jugar\n2 - ¿Como Jugar?\n3 - Volver");
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        ElJuego();
                       continue;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("¿Como jugar?\nPara jugar a este juego, se escogerá un número aleatorio del 0-20 y depende de la dificultad que escojas tienes un número (x) de intentos para hacertarlo, si lo aciertas ganarás puntos.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Lamb.error("(presiona cualquier tecla para salir)");
                        Lamb.clean();
                       continue;
                    case ConsoleKey.D3:
                        Console.Clear();
                        break; 
                    default:
                        Console.Clear();
                        continue;

                }
                break;
                
            }

        }
        void ElegirDificultad()
        {
            
            while (true)
            {
                Console.Clear();
                LetrasLento.Letras(20,"Elige tu dificultad:\n1 - Fácil\n2 - Medio\n3 - Dificil");
                Console.SetCursorPosition(20, 5);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nota: obtendrás más o menos puntos según la dificultad seleccionada...");
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        dificultad = 1;
                        break;
                    case ConsoleKey.D2:
                        dificultad = 2;
                        break;
                    case ConsoleKey.D3:
                        dificultad = 3;
                        break;
                    default:
                        continue;
                }
                break;
            }
            intentos = (dificultad == 1) ? 5 : (dificultad == 2) ? 4 : (dificultad == 3) ? 3 : 3;
            obtencionPuntos = (dificultad == 1) ? 5 : (dificultad == 2) ? 15 : (dificultad == 3) ? 25 : 25;
        }

        void ElJuego()
        {
            ElegirDificultad();
            int numeroAleatorio = rnd.Next(0, 21);
            Console.Clear();
            while (true)
            {
                LetrasLento.Letras(20,$"Tienes {intentos} intentos... elige un número (0-20)");
                bool probar = int.TryParse(Console.ReadLine(), out int numeroElegido);
                Console.Clear();
                if (numeroElegido == numeroAleatorio)
                {
                    LetrasLento.Letras(20,$"Enhorabuena, número acertado, has obtenido {obtencionPuntos} puntos.(presiona cualquier tecla para continuar)");
                    LogIn.actualUserPoints += obtencionPuntos;
                    Lamb.clean();
                    break;
                }
                else if(numeroElegido >20)
                {
                    Lamb.error("Elige un número => 0-20");
                }
                else
                {
                    intentos--;
                    if (intentos <= 0)
                    {
                        Lamb.error($"Has perdido, te quedan 0 intentos, buen intento! (el número era {numeroAleatorio}");
                        Console.WriteLine("(presiona cualquier tecla para continuar)");
                        Lamb.clean();
                        break;
                    }
                    Lamb.error($"Número fallado.");

                }
            }
        }
    }
}
