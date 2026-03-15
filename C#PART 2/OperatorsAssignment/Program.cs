using System;
namespace OperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            //create first employee
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "Jay";
            emp1.LastName = "kutty";

            //create second employee
            Employee emp2 = new Employee();
            emp2.Id = 1;
            emp2.FirstName = "Test";
            emp2.LastName = "User";

            //compaere employees using overloaded operator
            bool result = emp1 == emp2;

            //display result
            Console.WriteLine("Are the employee ids same for two employee objects ?  " + result);

            //leave hte console open
            Console.ReadLine();
        }
    }
}