using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main()
        {
            //instantiate Mathoperation 1 class
            MathOperation1 mathOp = new MathOperation1();

            //ask user to provide the first parameter
            Console.WriteLine("Enter an integer : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Ask the user to provide  a second parameter
            Console.WriteLine("Enter a second integer, or jusr press enter: ");
            try{
                //call method if both parameters provided
                int num2= Convert.ToInt32(Console.ReadLine());
                int results = mathOp. MathOperation(num1,num2);
                Console.WriteLine(num1 + " x " + num2 + "= " + results);

            }
            catch
            {
                //csll method if only one parameter is provided
                int results= mathOp. MathOperation(num1);
                Console.WriteLine(num1 + "x Default 1 =" + results);
            }
            Console.ReadLine();

        }
    }
}