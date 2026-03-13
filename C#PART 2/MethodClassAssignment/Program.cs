using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main()
        {
            //create object from MathDisplay class
            MathDisplay mathObj = new MathDisplay();

            //call method by passing two numbers normally
            mathObj.ShowMath(5, 20);

            Console.WriteLine();

            //call method again using named parameters
            mathObj.ShowMath(secondNumber: 50, firstNumber: 12);
            
            Console.ReadLine();
        }
    }
}