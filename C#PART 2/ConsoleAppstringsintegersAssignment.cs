using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //create a list of integers
        List<int> intList = new List<int>() {
            5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000
        };
        //variable to control loop until valid input
        bool numValid = false;

        while (!numValid)
        {
            try{
                //ask user fo r a number
                Console.WriteLine("\nEnter a number to divide the list by: ");
                float numDivide = float.Parse(Console.ReadLine());

                //check if user entered zero
                if(numDivide==0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                else
                {
                    //divide each number in the llist by the input
                    foreach (int num in intList)
                    {
                        float result = num / numDivide;
                        Console.WriteLine(num + "/" + numDivide +  "=" + result);
                    }

                    numValid = true;
                }

            }
            catch(FormatException)
            {
                //this runs if user types text instead of number
                Console.WriteLine("Invalid input. Please enter a number.");


            }

        }
        //message after try catch block
        Console.WriteLine("The Program has exited the try/catch block.");
        Console.ReadLine();

    }
}