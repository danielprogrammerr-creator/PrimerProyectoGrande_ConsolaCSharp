using InicioSesion;
using System;
using System.Collections.Generic;
using System.Text;

namespace InicioSesion
{ 
    class Estadisticas
    {
        public void Stats()
        {
            LetrasLento.Letras(20,$"{LogIn.actualUserName}:\n{LogIn.actualUserPoints} puntos.");
            Console.WriteLine("(presiona cualquier tecla para salir)");
            Lamb.clean();
        }
    }
}
