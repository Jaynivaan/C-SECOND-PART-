using System;
using System.Collections.Generic;

namespace ConsoleArrayAssignment
{
    class Program
    {
        static void Main()
        {
            //string array
            //create  an array of colors
            string[] colorArray = 
            {
                "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown"
            };

            Console.WriteLine("Select a number between 0 and 9 to choose a color: ");
            
            int colorIndex = Convert.ToInt32(Console.ReadLine());


            try
            {
                Console.WriteLine("Your favourite color is : " + colorArray[colorIndex]);

            }
            catch
            {
                Console.WriteLine("sorry the index does not exist. Kindly try again.");

            }
            //stiing list
            List<string> occupationList = new List<string>()
            {
                "Data Analyst",
                "UX Designer",
                "Artist",
                "Teacher",
                "Lawyer",
                "Cowboy",
                "Athlete",
                "Podcast Host",
                "Software Developer",
                "QA Tester"
            };
            Console.WriteLine("\nSelect a number between 0 and 9 to choose an occupation: ");

            int listIndex = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("Your new occupation is : " + occupationList[listIndex]);
            }
            catch
            {
                Console.WriteLine("Sorry, that Index does not exist.");
            }
            Console.ReadLine();
        }
    }
}