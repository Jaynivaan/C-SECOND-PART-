using System;

namespace OperatorsAssignment
{
    //create an Employee class 
    class Employee
    {
        //create and id property
        public int Id {get; set;}

        //create firstname property and lastnameproperty
        public string FirstName {get; set;}
        public string LastName {get; set; }


        //overload the == operator 
        //this shouldl be checking if hte two employee objects have same Id property value.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //Handle null comparison carefully
            if (ReferenceEquals(emp1,emp2))
            {
                return true;
            }
            if ((Object)emp1 == null || (Object)emp2 == null )
            {
                return false;
            }
            return emp1.Id == emp2.Id;
        }

        //overload hte not operator 
        //this is the opposite case of == 
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);   
        }
    }
}