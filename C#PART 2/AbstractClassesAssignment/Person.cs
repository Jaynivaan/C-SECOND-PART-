using System;

namespace AbstractClassesAssignment
{
    //create an abstract class called Person
    //abstrct means this class cannot be instantiated  on can be inheritted from.
    
    public abstract class Person
    {
        //create a string property firstname nd another string property as LastName
        public string firstName{get; set;}
        public string lastName{get; set;}
        //create an  abstact method called sayName()
        //Abstract methods doesnt contain a body it is usually implemented byu the derived classes.
        public abstract void SayName();
    }
}