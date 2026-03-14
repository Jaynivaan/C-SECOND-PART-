using System;

namespace PolymorphismAssignment
{
    //Employee inherits from person
    ///Employee also implements the iquittable interface
    public class Employee : Person, IQuittable

    {
        //Give emplyee an extra integer property called Id

        public int Id {get; set;}

        //override the inherited abstract method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //Implement the Quit() method from the interface
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has decided to quit the job.");
        }
    }
}

