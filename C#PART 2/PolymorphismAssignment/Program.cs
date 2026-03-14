using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main()
        {
            //instantiate the employee obj
            Employee emp = new Employee()
            {
                firstName ="Sample",
                lastName = "Student",
                Id = 1
            };

            //call the say name ()
            emp.SayName();

            //use polymorphism
            //create an object of interface type IQuittable
            //and assign the new interface object to employee
            IQuittable quittablePerson = emp;

            //call the Quit()mehthod through the interface method
            quittablePerson.Quit();

            //keep console open
            Console.ReadLine();
        }
    }
}