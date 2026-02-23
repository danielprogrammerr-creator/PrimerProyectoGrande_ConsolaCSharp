using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
   class LogIn
    {
        public static int queHacerA;
        public static string? actualUserName = null;
        public static string? actualUserMail = null;
        public static string? actualUserPassword = null;
        public static int? actualUserId = null;
        public static int actualUserPoints = 0;
        public static bool hayUsuariosCreados = false;
        public static bool sesionIniciada = false;
        public static bool sesionCerrada = false;
        public static string? encriptedPassword = null;
        public static void InicioSesion()
        {
            if (!hayUsuariosCreados)
            {
               Lamb.error("Crea alguna cuenta primero.");
            }
            else
            {
                if(sesionCerrada)
                {
                    sesionCerrada = false;
                    return;
                }
                Estetica.TextoParpadeante("___ _   _ ___ ____ ___ ___     ____  _____ ____ ___ ___  _   _ \r\n|_ _| \\ | |_ _/ ___|_ _/ _ \\   / ___|| ____/ ___|_ _/ _ \\| \\ | |\r\n | ||  \\| || | |    | | | | |  \\___ \\|  _| \\___ \\ | | | | |  \\| |\r\n | || |\\  || | |___ | | |_| |   ___) | |___ ___) || | |_| | |\\  |\r\n|___|_| \\_|____\\____|___\\___/  |____/|_____|____/|___\\___/|_| \\_|\n(presiona cualquier tecla para continuar)");
                IniciarSesion();
            }
        }
        static void IniciarSesion()
        {
            int contador = 0;
            LetrasLento.Letras(25,"Quien va a iniciar sesión?");
            foreach (User a in Program.gu.users)
            {
                Console.WriteLine($"{contador} - {a.userName}");
                contador ++;
            }
            bool probar = int.TryParse(Console.ReadLine(), out  queHacerA );
            if (probar &&queHacerA >= 0 && queHacerA < Program.gu.users.Count() )
            {
                actualUserName = Program.gu.users[queHacerA].userName;
                actualUserMail = Program.gu.users[queHacerA].userMail;
                actualUserPassword = Program.gu.users[queHacerA].userPassword;
                actualUserId = Program.gu.users[queHacerA].userId;
                actualUserPoints = Program.gu.users[queHacerA].userPoints;
                EncriptarContraseña();
                int intentos = 3;
                LetrasLento.Letras(20,$"Usuario: {actualUserName} elegido, introduce su contraseña para continuar.({actualUserMail})");
                while (true)
                {
                    string pruebaPassword = Console.ReadLine();
                    if (pruebaPassword == actualUserPassword)
                    {
                        Lamb.good("Sesión iniciada con éxito.(presiona cualquier tecla para continuar)");
                        sesionIniciada = true;
                        Lamb.clean();
                        Program.mIs.MainMenuInicioSesion();
                    }
                    else
                    {
                        Console.Clear();
                        intentos--;
                        if(intentos == 0)
                        {
                            Lamb.error("Te quedan 0 intentos, vuelve más tarde.");
                            LogIn.actualUserName = null;
                            LogIn.actualUserMail = null;
                            LogIn.actualUserPassword = null;
                            LogIn.actualUserId = null;
                            LogIn.actualUserPoints = 0;
                            LogIn.encriptedPassword = null;
                            return;
                        }
                        else
                        {
                            Lamb.error($"Te quedan {intentos} intentos, vuelve a escribir tu contraseña:");
                            continue;
                        }
                       
                    }
                    break;
                }
            }

        }
        public static void EncriptarContraseña()
        {
            for (int i = 0; i < actualUserPassword.Length; i++)
            {
               
                if (i > 1)
                {
                    encriptedPassword += "*";
                }
                else
                {
                    encriptedPassword += actualUserPassword[i];
                }
            }
            
        }
    }
}
