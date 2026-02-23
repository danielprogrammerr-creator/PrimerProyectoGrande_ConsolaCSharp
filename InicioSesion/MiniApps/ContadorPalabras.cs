using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
    class ContadorPalabras
    {
        public static void ContadorLetras()
        {
            Estetica.TextoParpadeante("____   ___   _   _  _____   _    ____    ___   ____  \r\n / ___| / _ \\ | \\ | ||_   _| / \\  |  _ \\  / _ \\ |  _ \\ \r\n| |    | | | ||  \\| |  | |  / _ \\ | | | || | | || |_) |\r\n| |___ | |_| || |\\  |  | | / ___ \\| |_| || |_| ||  _ < \r\n \\____| \\___/ |_| \\_|  |_|/_/   \\_\\____/  \\___/ |_| \\_\\");
            while (true) {
                Console.Clear();
                LetrasLento.Letras(12,"¿Que deseas hacer?\n1 - Contar\n2 - Volver");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Contar();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        return;
                    default:
                        continue;
                }
            }
        }
        static void Contar()
        {
            LetrasLento.Letras(20,"Escribe tu frase: ");
            string? frase = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(frase))
            {
                LetrasLento.Letras(20,"Aqui no hay nada...");

            }
            else
            {
                int contadorCaracteres = 0;
                int contadorPalabras = 0;
                bool firstTime = true;
                int contadorEspacios = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ')
                    {
                        contadorEspacios ++;
                        if (frase.Length - 1 == i)
                        { }
                        else {
                        if (frase[i] == ' ' && frase[i + 1] != ' ')
                            {
                                contadorPalabras++;
                                firstTime = false;
                            }
                        }
                    }
                    else
                    {
                        if(firstTime)
                        { contadorPalabras++; firstTime = false; }
                        contadorCaracteres ++;
                    }
                   
                    
                }
                LetrasLento.Letras(20, $"RESULTADOS DEL CONTADOR:\nCaracteres => {contadorCaracteres}\nPalabras => {contadorPalabras}\nEspacios => {contadorEspacios}");
            }

            Console.WriteLine("(presiona cualquier tecla para continuar)");
            Lamb.clean();

        }
    }
}
