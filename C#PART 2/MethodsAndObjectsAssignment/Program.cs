using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main()
        {
            //create and intitialize an Employee object
            //firstName is set to "sample"
            //lastName is set to "student "

            Employee emp = new Employee()
            {
                FirstName ="Sample",
                LastName ="Student",
                Id = 1
            };

            //call hte inherited SayName() 
            emp.SayName();

            Console.ReadLine();
            
        }
    }
}