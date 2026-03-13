using System;

namespace MethodsAndObjectsAssignment
{
    //create a class called Person
    public class Person
    {
        //create the first string property first name
        public string FirstName {get; set;}

        //create a string property called LastName
        public string LastName {get; set;}

        //create a void method called SayName()
        //This method takes no parameters it prints the full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}