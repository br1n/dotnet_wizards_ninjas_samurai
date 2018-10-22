using System;

namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            dexterity = 175;
        }
        public void steal(object target)
        {
            Human enemy = target as Human;
            if(enemy != null) 
            {
                attack(enemy);
                health += 10;
            }
        }
        public void get_away()
        {
            health -= 15;
        }
    }
}