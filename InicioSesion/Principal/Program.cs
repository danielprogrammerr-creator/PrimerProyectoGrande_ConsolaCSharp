using System;
using System.Collections.Generic;
namespace InicioSesion
{
    class Program
    {
        public static Contenido j3 = new Contenido();
        public static AttackSimulator attack = new AttackSimulator();
        public static Estadisticas stats = new Estadisticas();
        public static ContadorPalabras contPalabras = new ContadorPalabras();
        public static ConversorUnidades convUnids = new ConversorUnidades();
        public static Timer timer = new Timer();
        public static Ruleta rule = new Ruleta();
        public static JuegoDos j2 = new JuegoDos();
        public static Calculadora calc = new Calculadora();
        public static MenuInicioSesion mIs = new MenuInicioSesion(); 
        public static JuegoUno j1 = new JuegoUno();
        public static MJ mj = new MJ();
        public  static GestorUsers gu = new GestorUsers();
        public static MainMenu menu = new MainMenu();
        static void Main(string[] args)
        {
            menu.MenuPrincipal();
        }
    }
}