using System;

namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            intelligence = 25;
            health = 50;
        }
        public void heal()
        //heal method heals wizard by 10* intel
        {
            health = 10 * this.intelligence;
        }
        public void fireball(object target)
        {
            Human enemy = target as Human;
            if(enemy != null)
            {
                Random rand = new Random();
                enemy.health += rand.Next(20,51);
            }
        }
    }
}