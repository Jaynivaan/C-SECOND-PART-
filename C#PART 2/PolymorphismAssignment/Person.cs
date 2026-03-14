using System;

namespace PolymorphismAssignment
{
    //create an abstract class called person
    public abstract class Person
    {
        //include two string properties
        public string firstName {get; set;}
        public string lastName {get; set;}

        //create a n abstract method called SayName()
        public abstract void SayName();
        
    }
}