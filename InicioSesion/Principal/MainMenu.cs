
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;

namespace InicioSesion
{
    class MainMenu
    {
        int firstTime = 0;
        public void MenuPrincipal()
        {
            
            if (firstTime == 0)
            {
                FirstTime();
                firstTime++;
            }
                ForMenu();
        }

        void FirstTime()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            LetrasLento.Letras(40,"BIENVENIDO A...");
            Thread.Sleep(500);
            Estetica.TextoParpadeante("██████╗ ██╗██╗  ██╗███████╗██╗     ██████╗ ██╗   ██╗███████╗██╗  ██╗\r\n██╔══██╗██║╚██╗██╔╝██╔════╝██║     ██╔══██╗██║   ██║██╔════╝██║  ██║\r\n██████╔╝██║ ╚███╔╝ █████╗  ██║     ██████╔╝██║   ██║███████╗███████║\r\n██╔═══╝ ██║ ██╔██╗ ██╔══╝  ██║     ██╔══██╗██║   ██║╚════██║██╔══██║\r\n██║     ██║██╔╝ ██╗███████╗███████╗██║  ██║╚██████╔╝███████║██║  ██║\r\n╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝\n(presiona cualquier tecla para comenzar)");
        }
        void ForMenu()
        {
            while (true)
            {
                Console.Clear();
                
                LetrasLento.Letras(12,"¿Que deseas hacer?\n1 - Registrarse\n2 - Iniciar Sesión\n3 - Salir");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Estetica.TextoParpadeante("____  _____ ____ ___ ____ _____ ____   ___  \r\n|  _ \\| ____/ ___|_ _/ ___|_   _|  _ \\ / _ \\ \r\n| |_) |  _| \\___ \\ | |\\___ \\ | | | |_) | | | |\r\n|  _ <| |___ ___) || | ___) || | |  _ <| |_| |\r\n|_| \\_\\_____|____/|___|____/ |_| |_| \\_\\\\___/\n(presiona cualquier tecla para continuar)");
                        SignUp.Registrarse();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        LogIn.InicioSesion();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Estetica.TextoParpadeante("____    _    _     ___ _____ _   _ ____   ___  \r\n/ ___|  / \\  | |   |_ _| ____| \\ | |  _ \\ / _ \\ \r\n\\___ \\ / _ \\ | |    | ||  _| |  \\| | | | | | | |\r\n ___) / ___ \\| |___ | || |___| |\\  | |_| | |_| |\r\n|____/_/   \\_\\_____|___|_____|_| \\_|____/ \\___/ ...\n(presiona cualquier tecla para salir)");
                        return;

                    default:
                        Lamb.error("Escribe una opción válida => 1/2/3");
                        Lamb.clean();
                        continue;
                }
            }
        }

     

    }
}
