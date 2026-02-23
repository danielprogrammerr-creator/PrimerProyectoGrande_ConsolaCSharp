using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class SignUp
    {
        static Random rnd = new Random();
        static string queDato;
        static string textoExtra = "";
        static int tamañoMin;
        static int tamañoMax;
        static char[] invalidChars =  { '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=', '{', '}', '[', ']', '|', ':', ';', '"', '<', '>', ',', '.', '?', '/', '~', '`', ' ' };
        public static void Registrarse()
        {
            bool idYaExiste = true;
            queDato = "NOMBRE";
            tamañoMin = 3;
            tamañoMax = 12;
            string name=Datos();
            queDato = "CORREO ELECTRÓNICO";
            textoExtra = "(correo de google(no incluir @gmail.com))";
            tamañoMin = 1;
            tamañoMax = 64;
            string email = Datos() +"@gmail.com";
            queDato = "CONTRASEÑA";
            textoExtra = "";
            tamañoMin = 8;
            tamañoMax = 20;
            string password = Datos();
            int id = rnd.Next(1, 10000001);
            while (idYaExiste)
            {
                idYaExiste = false;
                foreach (User u in Program.gu.users)
                {
                    if (u.userId == id)
                    {
                        idYaExiste = true;
                    }
                }
                if (idYaExiste)
                {
                    id = rnd.Next(1, 10000001);
                }
            }
            Program.gu.GestorUsuarios(name, email, password, id);

            

        }
        static string Datos()
        {
            bool valido;
            bool confirmar = false;
            string dato;
            do
            {
                valido = true;
                LetrasLento.Letras(20,$"Ingresa tu {queDato} ({tamañoMin}-{tamañoMax} letras) {textoExtra}");
                dato = Console.ReadLine();
                if (dato != null && dato.Length>=tamañoMin&&dato.Length<=tamañoMax)
                {
                    for (int i = 0; i < dato.Length; i++)
                    {
                        if (invalidChars.Contains(dato[i]))
                        {
                            valido = false;
                            Lamb.error("Se ha detectado algún caractér no valido.");
                            break;
                        }
                    }
                    if (valido)
                    {
                        while (true)
                        {

                            LetrasLento.Letras(25,$"Quieres confirmar tu {queDato}? s/n");
                            ConsoleKeyInfo seguir = Console.ReadKey(true);
                            switch (seguir.Key)
                            {
                                case ConsoleKey.S:
                                    confirmar = true;
                                    Lamb.good($"{queDato}: {dato} confirmado con éxito.(presiona cualquier tecla para continuar)");
                                    Lamb.clean();
                                    break;
                                case ConsoleKey.N:
                                    confirmar = false;
                                    Lamb.error($"{queDato} rechazado con éxito.(presiona cualquier tecla para continuar)");
                                    Lamb.clean();
                                    break;
                                default:
                                    Lamb.error($"Escribe una opción válida.(presiona cualquier tecla para continuar)");
                                    continue;

                            }
                            break;
                        }
                    }

                }
                else
                {
                    valido = false;
                    Console.Clear();
                }
  
            } while (dato == null || dato.Length > tamañoMax || dato.Length < tamañoMin || !valido || !confirmar);
            return dato;
            
        }
    }
}
