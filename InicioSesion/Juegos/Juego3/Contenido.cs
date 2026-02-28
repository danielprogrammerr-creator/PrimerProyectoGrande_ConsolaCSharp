using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace InicioSesion
{
    class Contenido
    {
        const int dañoBase = 10;
        const int vidaBase = 100;
        int contadorKills=0;
        double vidaUserr;
        bool isEnemyAlive = false;
        int contador = 0;
        Juego3User j3user = new Juego3User();
        Enemies enemigo;
        Random rnd = new Random();
        public void Juego()
        {
            MenuJuego();
        }
        void MenuJuego()
        {
            while (true)
            {
                DarNivelesAlEmpezar();
                AsignarBoosts();
                Console.Clear();
                Estetica.Parpadeo("¿Que deseas hacer?\n1 - Partida\n2 - Volver");
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        vidaUserr = j3user.vidaUser;
                        Jugar();
                        break;
                    case ConsoleKey.D2:
                        j3user.nivelUser = 0;
                        return;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
        void Jugar()
        {
            while (true)
            {
                if (isEnemyAlive)
                {

                    Console.WriteLine($"HA APARECIDO UN \"{enemigo.queEnemy}\", CUIDADO!!!!(Vida: {enemigo.vidaEnemy}. Daño: {enemigo.dañoEnemy})");
                    while (true)
                    {
                        Console.WriteLine("¿Que deseas hacer?\n1 - Ataque Básico\n2 - Ataque Cargado\n3 - Huir");
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.D1:
                                AtaqueBasico();
                                break;
                            case ConsoleKey.D2:
                                AtaqueCargado();
                                break;
                            case ConsoleKey.D3:
                                SubidaNivel();
                                Lamb.clean();
                                return;
                            default:
                                Console.Clear();
                                continue;
                        }
                        break;
                    }
                    if (vidaUserr <= 0)
                    {
                        return;
                    }
                }
                else
                {
                    enemigo = GeneracionEnemigos();
                    isEnemyAlive = true;
                }
            }
        }
        void AtaqueBasico()
        {
            Console.Clear();
            enemigo.vidaEnemy -= j3user.dañoUser;
            Console.WriteLine($"Has hecho {j3user.dañoUser} de daño al {enemigo.queEnemy}.");
            AtaqueEnemigo();
            contador++;
        }
        void AtaqueCargado()
        {
            if (contador >= 5)
            {
                Console.Clear();
                enemigo.vidaEnemy -= j3user.dañoUser * 3;
                Console.WriteLine($"Has hecho {j3user.dañoUser*3} de daño al {enemigo.queEnemy}.");
                AtaqueEnemigo();
                contador -= 5;
            }
            else
            {
                Console.Clear();
                Lamb.error($"Haz {5-contador} ataques básicos más.");
            }
        }
        void AtaqueEnemigo()
        {
            if (enemigo.vidaEnemy <= 0)
            {
                Console.WriteLine($"HAS ElIMINADO AL {enemigo.queEnemy}!!(+2 puntos.)");
                contadorKills++;
                LogIn.actualUserPoints += 2;
                isEnemyAlive = false;
                Lamb.clean();
            }
            else
            {
                vidaUserr -= enemigo.dañoEnemy;
                if (vidaUserr <= 0)
                {
                    Console.Clear();
                    Lamb.error("Has muerto!!");
                    SubidaNivel();
                    Lamb.clean();
                }
                else
                {
                    enemigo.AtaqueEnemigo();
                    Console.WriteLine($"Te quedan {vidaUserr} de vida.");
                }

            }
        }

        Enemies GeneracionEnemigos()
            {
                int queEnemigo = rnd.Next(0, 7);
                switch (queEnemigo)
                {
                    case 0:
                        return new ZombieArmado();
                    case 1:
                        return new ZombieVeloz();
                    case 2:
                        return new AsesinoConArmadura();
                    case 3:
                        return new AsesinoConCuchilla();
                    case 4:
                        return new OgroFuerte();
                    case 5:
                        return new OgroGigante();
                    default:
                        return new ZombieArmado();
                }
            }
        void SubidaNivel()
        {
            while (contadorKills != 0)
            {
                if (contadorKills >= 2)
                {
                    j3user.nivelUser += 1;
                    contadorKills -= 2;
                    Lamb.good("+1 nivel.");
                    LogIn.actualNivelJ3++;
                }else
                {
                    return;
                }
            }
            Console.WriteLine($"Nivel actual: {j3user.nivelUser}");
        }
        void DarNivelesAlEmpezar()
        {
            j3user.nivelUser = 0;
            if(LogIn.actualNivelJ3 > 0)
            {
                    j3user.nivelUser = LogIn.actualNivelJ3;

            }
            else
            {
                return;
            }
        }
        void AsignarBoosts()
        {
            if (j3user.vidaUser > 0)
            {
                j3user.boostVida = 1;
                j3user.boostDaño = 1;
                for (int i = 0; i < j3user.nivelUser; i++)
                {
                    j3user.boostVida += 0.1;
                    j3user.boostDaño += 0.1;
                }
                j3user.dañoUser = dañoBase*j3user.boostDaño;
                j3user.vidaUser = vidaBase*j3user.boostVida;
            }
            else
            {
                return;
            }
        }
    }
}
