using System;

namespace ParsingEnumAssignment
{
    //create an enum for the days of week
    public enum DaysOfTheWeek
    {
        
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
    class Program
    {
        static void Main()
        {
            //variable to keep the loop running till getting a valid input.
            bool isValid = false;

            while(!isValid)
            {
                try{
                    //Ask user to enter a day
                    Console.WriteLine("Enter the curent day of the week: ");


                    //Read the users input
                    string dayInput = Console.ReadLine();
                    //Convert the iput string into the enumn value
                    DaysOfTheWeek day =
                    (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayInput);

                    //display the message 
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();

                    //Input is valid so exit loop
                    isValid = true;

                }
                catch (ArgumentException)
                {
                    //if parsinig fails show this messsage
                    Console.WriteLine("Please Enter an actual day of the week.");
                }
            }
        }
    }
}