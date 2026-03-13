using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main()
        {
            //create object of MathMethods2 class
            MathMethods2 math1 = new MathMethods2();

            //call the first method woth int paramweter
            Console.WriteLine(math1.MathOp(8));

            //callthe second method with decimal parameter
            Console.WriteLine(math1.MathOp(55.6m));

            //callthe third method with string parameter
            Console.WriteLine(math1.MathOp("333"));

            Console.ReadLine();

        }
    }
}