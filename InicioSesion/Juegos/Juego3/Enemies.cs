using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace InicioSesion
{
    abstract class Enemies
    {
        public abstract void AtaqueEnemigo();
        public double vidaEnemy { get; set; }
        public double dañoEnemy { get; set; }
        public string queEnemy { get; set; }
        string[] listaEnemigos = { "Zombie", "Asesino", "Ogro"};
        public Enemies(double vida, double daño, int qEnemigo)
        {
            vidaEnemy = vida;
            dañoEnemy = daño;
            queEnemy = listaEnemigos[qEnemigo];
        }
    }
    abstract class Zombie : Enemies
    {
        public Zombie(double health, double damage, int whatEnemy) : base(health, damage, whatEnemy) 
        {

        }
    }
    abstract class Asesino : Enemies
    {
        public Asesino(double health, double damage, int whatEnemy) : base(health, damage, whatEnemy)
        {

        }
    }
    abstract class Ogro : Enemies
    {
        public Ogro(double health, double damage, int whatEnemy) : base(health, damage, whatEnemy)
        {

        }
    }

    class ZombieArmado : Zombie
    {
        public override void AtaqueEnemigo()
        {
             Lamb.error($"El {queEnemy} te ha mordido.");
        }
        public ZombieArmado() : base(40,5,0)
        {

        }
    }
    class ZombieVeloz : Zombie
    {
        public override void AtaqueEnemigo()
        {
            Lamb.error($"El {queEnemy} te ha placado.");
        }
        public ZombieVeloz() : base(30, 5, 0)
        {

        }
    }
    class AsesinoConCuchilla : Asesino
    {
        public override void AtaqueEnemigo()
        {
            Lamb.error($"El {queEnemy} te ha apuñalado.");
        }
        public AsesinoConCuchilla() : base(20, 10, 1)
        {

        }
    }
    class AsesinoConArmadura : Asesino
    {
        public override void AtaqueEnemigo()
        {
            Lamb.error($"El {queEnemy} te ha pegado.");
        }
        public AsesinoConArmadura() : base(50, 5, 1)
        {

        }
    }
    class OgroGigante : Ogro
    {
        public override void AtaqueEnemigo()
        {
            Lamb.error($"El {queEnemy} te ha pisado.");
        }
        public OgroGigante() : base(70, 3, 2)
        {

        }
    }
    class OgroFuerte : Ogro
    {
        public override void AtaqueEnemigo()
        {
            Lamb.error($"El {queEnemy} te ha aplastado.");
        }
        public OgroFuerte() : base(30, 12, 2)
        {

        }
    }
}
