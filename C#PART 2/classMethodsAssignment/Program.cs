using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main ()
        {
            //instantiate the class
            VoidMethod math = new VoidMethod();

            //ask the user to enter a number 
            Console.WriteLine("Enter a number: ");

            //Read the number from the user
            int divident = Convert.ToInt32(Console.ReadLine());

            //Call the void Method on that number
            math.MathOp(divident);

            //displaythe divident to user
            Console.WriteLine("divided by 2 : " + math.Value);
            Console.ReadLine();

            //call the method with output parameters
            Console.WriteLine("Input a Phrase: ");
            string input = Console.ReadLine();

            //The method returns a phrase
            //and also sends our the length through the out parameter

            int count;
            string phrase = math.StringCounter(input, out count);

            Console.WriteLine(phrase);
            Console.WriteLine("Length is : " + count);

            Console.ReadLine();
            
            
            // Call the overloaded Metho
            Console.WriteLine("Input another pHrase: ");
            string  input2 = Console.ReadLine();

            int phrase2Len = math.StringCounter(input2);

            Console.WriteLine("This phrase " + input2 + "is "+ phrase2Len + " characters long.");
            Console.ReadLine();




            //call the static method
            Console.WriteLine("Input another Phrase: ");
            string input3 = Console.ReadLine();

            int iCount = VoidMethod.IFinder(input3);
            Console.WriteLine("This phrase has " + iCount + "i's in it.  ");

            Console.ReadLine();
        }
    }
}