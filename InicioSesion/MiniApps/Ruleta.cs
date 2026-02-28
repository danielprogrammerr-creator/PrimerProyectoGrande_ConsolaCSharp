using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace InicioSesion
{
     class Ruleta
    {
        Random rnd = new Random();
        List<int> numeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        int resultado;
        int decision;
        int invertirMonedas;
        int monedas = 1000;
        public void Rule()
        {
            while (true)
            {
                Console.Clear();
                Estetica.Parpadeo($"Bienvenido, tienes {monedas}, ¿que deseas hacer?\n1 - Tirar Ruleta\n2 - Volver");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        MostrarNumeros();
                        ElegirNumero();
                        GirarRuleta();
                        DarPremios();
                        Lamb.clean();
                        break;
                    case ConsoleKey.D2:
                        return;
                    default:
                        break;
                }
            }
        }

        void GirarRuleta()
        {
            Console.Clear();
            Console.BackgroundColor= ConsoleColor.White;
            for (int i = 0; i < 25; i++)
            {
                Console.Clear();
                resultado = numeros[rnd.Next(numeros.Count)];
                if(Lamb.par(resultado) && resultado != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (!Lamb.par(resultado))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (resultado == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(resultado);
                Console.Beep(1000, 2); //si no estas en Windows quita los valores. 
                Thread.Sleep(200+i*3);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        void MostrarNumeros()
        {
            int yR = 1;
            int yB  = 1;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 0);
            Lamb.error("Números Rojos:");
            Console.SetCursorPosition(20, 0);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Números Negros:");
            foreach (var a in numeros)
            {
                if (Lamb.par(a) && a != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(20, yB);
                    yB++;
                    Console.WriteLine(a);

                }
                else if (a == 0)
                {
                    Console.SetCursorPosition(40,0 );
                    Lamb.good($"Verdes:");
                    Console.SetCursorPosition(40, 1);
                    Lamb.good($"{a}");
                }
                else
                {
                    Console.SetCursorPosition(2, yR);
                    yR++;
                    Lamb.error($"{a}");
                }
                
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;
            Console.SetCursorPosition(0, 20);
  

        }
        void ElegirNumero()
        {
            bool prueba;
            do
            {
                LetrasLento.Letras(15,"¿Que número deseas elegir? (rojos x2, negros x2, verde x16//acertar número x4 (rojos y negros))");
                string a = Console.ReadLine();  
                prueba = int.TryParse(a, out decision);
                Console.SetCursorPosition(0, 0);
                Console.Clear();
            } while (!prueba || decision < 0 || decision > 36);
            do
            {
                LetrasLento.Letras(15,$"Número {decision} seleccionado...\n¿Cuantas monedas deseas apostar(tienes: {monedas} monedas)?");
                string a = Console.ReadLine();
                prueba = int.TryParse(a, out invertirMonedas);
                Console.Clear();
            } while (!prueba || invertirMonedas < 0 || invertirMonedas>monedas);
            Console.Clear();
            monedas -= invertirMonedas;
            LetrasLento.Letras(15,$"{invertirMonedas} monedas apostadas, te quedan {monedas} monedas.\nPresiona cualquier tecla para tirar la ruleta... ¡Suerte!");
            Lamb.clean();
        }
        void DarPremios()
        {
            if(decision == 0 && decision == resultado)
            {
                invertirMonedas *= 16;
                monedas += invertirMonedas;
                Lamb.good($"Enhorabuena, has ganado {invertirMonedas} monedas, tienes {monedas} monedas.");
            }
            if(decision != 0 &&decision == resultado)
            {
                invertirMonedas *= 4;
                monedas += invertirMonedas;
                Lamb.good($"Enhorabuena, has ganado {invertirMonedas} monedas, tienes {monedas} monedas.");
            }
            else if (Lamb.par(decision) && !Lamb.par(resultado) || !Lamb.par(decision) && Lamb.par(resultado))
            {
                Lamb.error("Lo siento, has perdido, suerte para la próxima.");
            }
            else if (Lamb.par(decision) && Lamb.par(resultado) || !Lamb.par(decision) && !Lamb.par(resultado))
            {
                invertirMonedas *= 2;
                monedas += invertirMonedas;
                Lamb.good($"Enhorabuena, has ganado {invertirMonedas} monedas, tienes {monedas} monedas.");
            }
        }

    }
}
