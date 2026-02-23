using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{
   class ConversorUnidades
    {
        static double datoAñadido;
        static double result;
        public static void Conversor()
        {
            Estetica.TextoParpadeante("____   ___   _   _ __     __ _____ ____   ____   ___   ____  \r\n / ___| / _ \\ | \\ | |\\ \\   / /| ____||  _ \\ / ___| / _ \\ |  _ \\ \r\n| |    | | | ||  \\| | \\ \\ / / |  _|  | |_) |\\___ \\| | | || |_) |\r\n| |___ | |_| || |\\  |  \\ V /  | |___ |  _ <  ___) | |_| ||  _ < \r\n \\____| \\___/ |_| \\_|   \\_/   |_____||_| \\_\\|____/ \\___/ |_| \\_\\ \n _   _  _   _  ___  ____    _    ____   _____  ____  \r\n| | | || \\ | ||_ _||  _ \\  / \\  |  _ \\ | ____|/ ___| \r\n| | | ||  \\| | | | | | | |/ _ \\ | | | ||  _|  \\___ \\ \r\n| |_| || |\\  | | | | |_| / ___ \\| |_| || |___  ___) |\r\n \\___/ |_| \\_||___||____/_/   \\_\\____/ |_____||____/");
            while (true)
            {
                Console.Clear();
                LetrasLento.Letras(12,"¿Que quieres hacer?\n1 - Grados Celsius a Fahrenheit.\n2 - Grados Fahrenheit a Celsius\n3 - Km a Millas\n4 - Millas a Km\n5 - Monedas(€ a otras)\n6 - Volver");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        LeeDato();
                        result = CelsiusFar(datoAñadido);
                        Console.WriteLine(result);
                        Lamb.clean();
                        break;
                    case ConsoleKey.D2:
                        LeeDato();
                        result = FarCelsius(datoAñadido);
                        Console.WriteLine(result);
                        Lamb.clean();
                        break;
                    case ConsoleKey.D3:
                        LeeDato();
                        result = KmMillas(datoAñadido);
                        Console.WriteLine(result);
                        Lamb.clean();
                        break;
                    case ConsoleKey.D4:
                        LeeDato();
                        result = MillasKm(datoAñadido);
                        Console.WriteLine(result);
                        Lamb.clean();
                        break;
                    case ConsoleKey.D5:
                        Monedas();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        return;
                    default:
                        continue;
                }
            }
        }
       static void LeeDato()
        {
            bool tryParse;
            do
            {
                Console.Clear();
                LetrasLento.Letras(20,"Introduce la cantidad:");
                tryParse = double.TryParse(Console.ReadLine(), out datoAñadido);
            } while (!tryParse);
        }
        static void Monedas()
        {
            while (true)
            {
                Console.Clear();
                LetrasLento.Letras(12,"¿Que moneda eliges?\n1 - Euro a Dolar\n2 - Euro a GBP(libras)\n3 - Euro a CHF(francos suizos)\n4 - Volver");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        LeeDato();
                        result = EuroAdolar(datoAñadido);
                        Console.WriteLine(result+ "$");
                        Lamb.clean();
                        break;
                    case ConsoleKey.D2:
                        LeeDato();
                        result = EuroAGBP(datoAñadido);
                        Console.WriteLine(result + "£");
                        Lamb.clean();
                        break;
                    case ConsoleKey.D3:
                        LeeDato();
                        result = EuroAFrancoSuizo(datoAñadido);
                        Console.WriteLine(result + "CHF");
                        Lamb.clean();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        return;
                    default:
                        continue;
                }
            }
        }
       static double CelsiusFar(double dato)
        {
            double resultado = (dato * 9) / 5 + 32;
            return resultado;
        }
       static double FarCelsius(double dato)
        {
            double resultado = ((dato-32)*5)/9;
            return resultado;
        }
       static double KmMillas(double dato)
        {
            double resultado = dato * 0.621371;
            return resultado;
        }
       static double MillasKm(double dato)
        {
            double resultado = dato / 0.621371;
            return resultado;
        }
      static  double EuroAdolar(double dato)
        {
            double resultado = dato * 1.179;
            return resultado;
        }
       static double EuroAGBP(double dato)
        {
            double resultado = dato * 0.87;
            return resultado;
        }
        static double EuroAFrancoSuizo(double dato)
        {
            double resultado = dato * 0.91;
            return resultado;
        }

    }
}
