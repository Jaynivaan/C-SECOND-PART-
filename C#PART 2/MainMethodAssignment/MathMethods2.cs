using System;

namespace MainMethodAssignment
{
    //this class contains overloaded math methods.    
    public class MathMethods2
    {
        //first method that takes an integer
        public int MathOp(int number)
        {
            //add 77 to the integer
            return number + 77;            

        }

        //Second method takes a decimal
        public int MathOp(decimal number)
        {
            //convert decimalt o integer first
            int newnum = Convert.ToInt32(number);

            //multiply the converted number by 99
            return newnum * 99;

        }

        //Third Method takes a string
        public int MathOp (string number)
        {
            //convert string to integer first
            int newnum =  Convert.ToInt32(number);

            //find the remainder when divided by 88
            return newnum % 88;

        }
        
    }
}