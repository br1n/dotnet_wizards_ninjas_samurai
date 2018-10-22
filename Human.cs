using System;

namespace wizard_ninja_samurai
{
    public class Human
    {
        //creating fields
        public string name;
        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }
        public Human(string person) 
        {
            //default values for fields
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100; 
        }

        public Human(string person, int str, int intel, int dex, int hp)
        {
            //additional constructor that accepts 5 parameters
            //for custom value for fields
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp; 
        }

          public void attack(Human target)
        {   
            if(target == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                target.health -= strength * 5;
            }
        }
    }
}