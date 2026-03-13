using System;

namespace AbstractClassesAssignment
{
    ////create a class called Employee
    /// it inherits het abstract class person
    public class Employee : Person
    {
        //give employee an integer property called id
        public int Id  {get; set;}
         
        //implement the abstract method sayname()

        //because Person file declared  this method as abstract we must override it here
        public override void SayName()
        {
            //Print the full nema to the conssole
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}