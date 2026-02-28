using InicioSesion;
using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class JuegoDos
    {
        public void Juego2()
        {
            MenuJuego2();
        }
        void MenuJuego2()
        {
            while (true)
            {
                Console.Clear();
                LetrasLento.Letras(12, "¿Que deseas hacer?\n1 - Jugar\n2 - Volver");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        Decision();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        return;
                    default:
                        break;

                }
            }
        }
        Random rnd = new Random();
        string ElegirMáquina()
        {
            int opcion = rnd.Next(1,4);
            switch (opcion)
            {
                case 1:
                    return "tijera";
                case 2:
                    return "piedra";
                case 3:
                    return "papel";
                default:
                    return "piedra";
            }
        }
        string ElegirUser()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("¿Que ópcion deseas hacer? \n1 - Piedra\n2 - Papel\n3 - Tijera");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        return "piedra";
                    case ConsoleKey.D2:
                        return "papel";
                    case ConsoleKey.D3:
                        return "tijera";
                    case ConsoleKey.D4:
                        return "piedra";
                    default:
                        continue;
                }

            }
        }
        void Ganado()
        {
            Console.Clear();
            LetrasLento.Letras(20,"Enhorabuena, has ganado 5 puntos!!");
            Lamb.error("(presiona cualquier tecla para salir)");
            LogIn.actualUserPoints += 5;
            Lamb.clean();
        }
            void Perdido()
        {
            Console.Clear();
            LetrasLento.Letras(20,"Has perdido!");
            Lamb.error("(presiona cualquier tecla para salir)");
            Lamb.clean();
        }
        void Empate()
        {
            Console.Clear();
            LetrasLento.Letras(20, "Empate!!");
            Lamb.error("(presiona cualquier tecla para salir)");
            Lamb.clean();
        }
        void Decision()
        {
            string maquina = ElegirMáquina();
            string user = ElegirUser();
            Console.Clear();
            Console.WriteLine($"{user} contra {maquina}...");
            Lamb.clean();
            if (maquina == "piedra" && user == "papel" || maquina == "papel" && user == "tijera" || maquina == "tijera" && user == "piedra")
            {
                Ganado();
            }
            if (maquina == "piedra" && user == "tijera" || maquina == "tijera" && user == "papel" || maquina == "papel" && user == "piedra")
            {
                Perdido();  
            }
            if (maquina == "piedra" && user == "piedra"|| maquina == "tijera" && user == "tijera"|| maquina == "papel" && user == "papel")
            {
                Empate();
            }
           
        }
    }
}
