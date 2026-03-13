using System;

namespace MethodClassAssignment
{
    class MathDisplay
    {
        //This void method takes two integers.
        //It performs mathon first integer.
        //and displays the second integer
        public void ShowMath(int firstNumber, int secondNumber)
        {
            int result = firstNumber + 10;
            Console.WriteLine("First Number after adding 10: " + result );
            Console.WriteLine("Second Number is : " + secondNumber);
            
        }
    }
}