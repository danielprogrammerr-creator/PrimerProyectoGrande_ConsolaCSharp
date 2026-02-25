using InicioSesion;
using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{ 
    //Hecha en 30 minutos sin buscar nada.
class Calculadora
    {
        List<string> registro = new List<string>(); 
        public void Calculator()
        {
            Estetica.TextoParpadeante("____    _    _       ____  _   _  _         _     ____    ___   ____      _    \r\n / ___|  / \\  | |     / ___|| | | || |       / \\   |  _ \\  / _ \\ |  _ \\    / \\   \r\n| |     / _ \\ | |    | |    | | | || |      / _ \\  | | | || | | || |_) |  / _ \\  \r\n| |___ / ___ \\| |___ | |___ | |_| || |___  / ___ \\ | |_| || |_| ||  _ <  / ___ \\ \r\n \\____/_/   \\_\\_____| \\____| \\___/ |_____|/_/   \\_\\____/  \\___/ |_| \\_\\/_/   \\_\\");
            MenuCalc();
        }
        void MenuCalc()
        {
            while (true)
            {
                Console.Clear();
                LetrasLento.Letras(20,"¿Que deseas hacer?\n1 - Calcular\n2 - Registro de Cálculos(10)\n3 - Volver");
                ConsoleKeyInfo queHacer = Console.ReadKey(true);
                switch (queHacer.Key)
                {
                    case ConsoleKey.D1:
                        Calculos();
                        break;
                    case ConsoleKey.D2:
                        RegistroCalculos();
                        break;
                        case ConsoleKey.D3:
                        Console.Clear();
                        return;
                }
            }
        }
         void Calculos()
            {
            List<double> listaNums = new List<double>();
            double resultado = 0;
            double contador=0;
            string añadir;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Introduce los números con los que quieras operar, escribe (suma=>s, resta=>r, multiplicacion=>m, division=>d(al final del calculo)) para acabar. ");
                añadir = Console.ReadLine();
                if(añadir == "s"|| añadir == "r"|| añadir == "m"|| añadir == "d")
                { break; }
                bool probar = double.TryParse(añadir, out double añadirNum);
                if(probar)
                {
                    listaNums.Add(añadirNum);
                }
            } 
            Console.Clear();
            switch (añadir)
            {
                case "s":
                    foreach(int i in listaNums)
                    {
                        resultado += i;
                    }
                    break;
                case "r":
                    foreach (int i in listaNums)
                    {
                        if(contador < 1)
                        { 
                            resultado += i;
                            contador++; 
                        }
                        else
                        {
                            resultado -= i;
                        }
                        
                    }
                    break;
                case "m":
                    resultado = 1;
                    foreach (int i in listaNums)
                    {
                        resultado *= i;
                    }
                    break;
                case "d":
                    foreach (int i in listaNums)
                    {
                        if (contador < 1)
                        {
                            resultado += i;
                            contador++;
                        }
                        else
                        {
                            resultado /= i;
                        }

                    }
                    break;
            }
            LetrasLento.Letras(20,$"El resultado de tu operación es: {resultado}.");
            string conversion = Convert.ToString(resultado);
            while(registro.Contains(conversion))
            {
                conversion += " ";
            }

            registro.Add(conversion);
            Lamb.clean();


        }
        void RegistroCalculos()
        {
            Console.Clear();
            int a = 0;
            while(registro.Count > 10)
            {
                registro.RemoveAt(a);
                    a++;
            }
            LetrasLento.Letras(25,"Registro de los 10 últimos resultados: ");
            if (registro.Count() != 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i > registro.Count() -1 )
                    {
                        LetrasLento.Letras(15,"Hueco Vacío.");
                    }
                    else
                    {
                        LetrasLento.Letras(20,registro[i]);
                    }

                }
            }
            else
            {
                LetrasLento.Letras(20,"No hay ningun calculo por aquí...");
                
            }
            Lamb.clean();
        }
    }
}
