using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("what is your name:");
            string PlayerName = Console.ReadLine();
            //message at start
            Console.WriteLine("you have encountered jay the fool and he launches a surprise attack.");
            
            //ask for input 
            Console.WriteLine("Input your defense stat -a number: ");
            //set input as defense from user
            int defense = Convert.ToInt32(Console.ReadLine());

            //use method from mathmethods to compute enemy damage.
            int enemy_damage = MathMethods.Defense(defense);
            //give the damage taken to user on display
            Console.WriteLine("You have taken " + enemy_damage + "HP of damage.");

            Console.WriteLine("Your healer the " + PlayerName +" from the highest realms actively heals you now");

            Console.WriteLine("input " + PlayerName + "magic stat number");
            int magic = Convert.ToInt32(Console.ReadLine());

            int heal = MathMethods.Heal(magic);
            Console.WriteLine(" The skills of " +PlayerName+ "from higher realms is so powerful that you healed "+ heal + "HP.");


            Console.WriteLine("Now wheels turned time for counter attack");
            Console.WriteLine("Input you strength -a number: ");
            int strength = Convert.ToInt32(Console.ReadLine());

            int damage = MathMethods.Attack(strength);
            Console.WriteLine("You dealt " + damage + "damage.");

            Console.ReadLine();


        }
    }
}