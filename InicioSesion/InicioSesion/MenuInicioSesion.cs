
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InicioSesion
{
    class MenuInicioSesion
    {
        public void MainMenuInicioSesion()
        {
            Menu();
        }

        void Menu()
        {
                Estetica.TextoParpadeante("██████╗ ██╗██╗  ██╗███████╗██╗     ██████╗ ██╗   ██╗███████╗██╗  ██╗\r\n██╔══██╗██║╚██╗██╔╝██╔════╝██║     ██╔══██╗██║   ██║██╔════╝██║  ██║\r\n██████╔╝██║ ╚███╔╝ █████╗  ██║     ██████╔╝██║   ██║███████╗███████║\r\n██╔═══╝ ██║ ██╔██╗ ██╔══╝  ██║     ██╔══██╗██║   ██║╚════██║██╔══██║\r\n██║     ██║██╔╝ ██╗███████╗███████╗██║  ██║╚██████╔╝███████║██║  ██║\r\n╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝\n____ ___  __  __ ___ _____ _   _ _____  _    \r\n / ___/ _ \\|  \\/  |_ _| ____| \\ | |__  / / \\   \r\n| |  | | | | |\\/| || ||  _| |  \\| | / / / _ \\  \r\n| |__| |_| | |  | || || |___| |\\  |/ /_/ ___ \\ \r\n \\____\\___/|_|  |_|___|_____|_| \\_/____/_/   \\_\\          _        _    \r\n| |      / \\   \r\n| |     / _ \\  \r\n| |___ / ___ \\ \r\n|_____/_/   \\_\\ \n _ __     _______ _   _ _____ _   _ ____      _    \r\n   / \\\\ \\   / / ____| \\ | |_   _| | | |  _ \\    / \\   \r\n  / _ \\\\ \\ / /|  _| |  \\| | | | | | | | |_) |  / _ \\  \r\n / ___ \\\\ V / | |___| |\\  | | | | |_| |  _ <  / ___ \\ \r\n/_/   \\_\\\\_/  |_____|_| \\_| |_|  \\___/|_| \\_\\/_/   \\_\\ \n(presiona cualquier tecla para empezar)");
                while (true)
                {
                    LetrasLento.Letras(12,"¿Que deseas hacer? \n1 - Juegos\n2 - Ruleta\n3 - Calculadora\n4 - Conversor datos\n5 - Contador frases\n6 - Temporizador\n7 - Sobre la cuenta\n8 - Cerrar Sesión");
                    ConsoleKeyInfo queHacer = Console.ReadKey(true);
                    switch (queHacer.Key)
                    {
                        case ConsoleKey.D1:
                        Console.Clear();
                        Program.mj.MenuJuego();
                            break;
                        case ConsoleKey.D2:
                        Program.rule.Rule();
                        break;
                        case ConsoleKey.D3:
                        Program.calc.Calculator();
                        break;
                        case ConsoleKey.D4:
                        Program.convUnids.Conversor();
                        break;
                    case ConsoleKey.D5:
                        Program.contPalabras.ContadorLetras();
                        break;
                    case ConsoleKey.D6:
                        Program.timer.Temporizador();
                        break;
                        case ConsoleKey.D7:
                        Console.Clear();
                        Console.WriteLine("Cuenta actual: ");
                        LetrasLento.Letras(15,$"Nombre => {LogIn.actualUserName}\nMail => {LogIn.actualUserMail}\nContraseña => {LogIn.encriptedPassword}\nID => {LogIn.actualUserId}"); 
                        Console.WriteLine("Presiona cualquier tecla para continuar");
                        Lamb.clean();
                            break;
                    case ConsoleKey.D8:
                        LetrasLento.Letras(20,"¿Estás seguro que quieres cerrar sesión? s/n");
                        string queHacer2 = Console.ReadLine().ToLower();
                        switch (queHacer2) 
                        {
                            case "s":
                                LogIn.actualUserName = null;
                                LogIn.actualUserMail = null;
                                LogIn.actualUserPassword = null;
                                LogIn.actualUserId = null;
                                Program.gu.users[LogIn.queHacerA].userPoints = LogIn.actualUserPoints;
                                LogIn.actualUserPoints = 0;
                                LogIn.sesionIniciada = false;
                                LogIn.sesionCerrada = true;
                                LogIn.encriptedPassword = null;
                                LetrasLento.Letras(40,"Cerrando Sesión...");
                                Lamb.clean();
                                return;
                            case "n":
                                LetrasLento.Letras(40,"Volviendo...");
                                Lamb.clean();
                                break;
                            default:
                                LetrasLento.Letras(25,"Respuesta no reconocida, Volviendo...");
                                Lamb.clean();
                                break;

                        }
                        break;
                        default:
                            Console.Clear();
                            continue;
                    }
                }
            
        }

    }
}
