using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main()
        {
            //Create constant variables
            const string const1 = "Your name is : ";
            const string const2 = "Your favorite number is : ";

            //ask the user for an input
            Console.WriteLine("Enter Your Name or Favorite Number : ");

            //create a variable using a var keyword
            var answer = Console.ReadLine();

            //check if the input is a number 
            float x;
            if (float.TryParse(answer, out x))
            {
                Console.WriteLine(const2);

                //constructor chained when number is entered.
                Chain newChain = new Chain(x);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine(const1);

                //constructor chained for the name entry
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}