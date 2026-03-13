using System;

namespace MethodsAndObjectsAssignment

{
    //create another class clalled Employee
    //Employee inherits form the class Person that wer creaated in Person.cs file
    public class Employee : Person
    {
        //Give Employee an integer property called Id
        public int Id {
            get; set;
        }
    }
}