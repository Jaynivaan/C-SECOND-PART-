using System;

namespace ClassMethodAssignment
{
    //create a class called void method
    class VoidMethod
    {
        //create a property to store the divided result
        public int Value {get; set;}

        //create a void method that takes one integer parameter
        //this created void method willdivide the entered number by 2
        // Then it shores the answer derived inside the Value variable.
        
        public void MathOp(int number)
        {
            Value = number / 2;
        }
        //create a method that output parameters
        //this method returns the same phase
        // and also sends the length of the phrase through an output parameter
        
        public string StringCounter(string input, out int count)
        {
            count = input.Length;
            return "You Entered : " + input;
            
        }

        //overload the method
        //This version only takes one string parameter
        //and directly returns the length of the phrase
        public int StringCounter(string input)
        {
            return input.Length;
            
        }
        //Declare a class method as static
        //this method counts how many letter i's appear in the text
        public static int IFinder (string input)
        {
            int count = 0;
            
            foreach (char c in input)
            {
                if (c == 'i' || c == 'I')
                {
                    count++;
                }
            }
            return count;
        }
    }
}