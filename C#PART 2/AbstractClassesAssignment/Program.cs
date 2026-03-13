using System;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main()
        {
            //instantiate Employeee object 
            // and set the first and last name as sample adn student
            Employee sam = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };
            //csll the sayname method on the employee object
            sam.SayName();
            //keep the console opeen

            Console.ReadLine();
        }
    }
}