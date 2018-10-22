using System;

namespace wizard_ninja_samurai
{
    public class Samuria : Human
    {
        public static int count = 0;
       public Samuria(string name) : base(name)
       {
           count++;
           health = 200;
       }
       public void death_blow(object target)
        {
            Human enemy = target as Human;
            if(enemy != null) 
            {
                if(enemy.health < 50)
                {
                    enemy.health = 0;
                }
            }
        }
        public void meditate()
        {
            health = 200;
        }
        public void how_many()
        {
            Console.WriteLine($"There are {count} Samurai!");
        }
    }
}