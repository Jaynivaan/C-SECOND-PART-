using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main()
        {
            //Print the current date and time to the console.
            Console.WriteLine("The current date and time is : " + DateTime.Now);

            //Ask the user for a number
            Console.WriteLine("Enter a number of hours: ");

            //Read the users entry
            double hours = Convert.ToDouble(Console.ReadLine());

            //Calculate the future time
            DateTime futureTime = DateTime.Now.AddHours(hours);

            //display the future time computed to the user
            Console.WriteLine("In {0} hour(s) the time will be {1}", hours, futureTime);
        }
    }
}