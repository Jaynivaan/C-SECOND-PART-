using  System;
using System.Collections.Generic;

class Program 
{
    static void Main()
    {
        //part1.1: Create array of strings 
        string[] animals = {
            "Dog", "Cat","Bird", "Fish" 
        };
        //part1.2: ask user to input some text
        Console.WriteLine("Enter some text to add to the animal array : ");
        
        string userText = Console.ReadLine();

        //part1.3 : loop throhg the arraya dn  append the user text.
        for
        (int i=0; i< animals.Length; i++)
        {
            animals[i] = animals[i] + ""  + userText;
        }
        //Part1.4: Print updated array
        Console.WriteLine("\nUpdated array: ");
        for 
        (int i = 0; i < animals.Length; i++)
        {
            Console.WriteLine(animals[i]);
        }

        // part 2: 
        // / addinga n infinite loop now
        int counter = 0;
        while(counter< 5)
        {
            Console.WriteLine("Loop iteration: " + counter);
            Console.WriteLine("this is and infinite loop as the counter is set stationary at 0.");

            //addding the counter increment system to fix hte infinite loop.
            counter++;
    
        }

        ///Part 3.1 create a loop using < operator
        /// 
        for(
            int i = 0; 
            i<5; 
            i++
        )
        {
            Console.WriteLine("Loop with  < Operator: " + i);
        }

        //part3.3
        //Loop  using <= operator
        for
        (
            int j =0;
            j<=5;
            j++
        )
        {
            Console.WriteLine("Loop with <= operator: " + j);
        }
        //Part4.1 craatea  list ofstrings where each item inthe listis unique.
        List<string> fruits =  new List<string>()
        {
            "apple",
            "banana",
            "mango",
            "orange",
            "grapes"
        };

        //askthe user to  input a fruit name to search for
        Console.WriteLine("Enter a fruit to search in the list: ");
        string searchItem = Console.ReadLine();
        Console.ReadLine();

        bool found = false;

        for(int i=0; i<fruits.Count; i++)
        {
            if(fruits[i] == searchItem)
            {
                Console.WriteLine("Item found at inndex: " + i);
                found = true;

                //stop oop once match is found
                break;
            }

        }
        if (!found)
        {
            Console.WriteLine("Your input is not on the list.");
        }

        //part 5  searvch llist with identical strings
        List<string> colors = new List<string>()
        {
            "red",
            "blue",
            "green",
            "red",
            "yellow"
        };
        Console.WriteLine("Enter a color to search : ");
        string colorSearch = Console.ReadLine();
        
        bool foundColor = false;

        for(
            int i=0;
            i<colors.Count;
            i++
        )
        {
            if(colors[i] == colorSearch )
            {
                Console.WriteLine("Match found at index: " + i);
                foundColor = true;
            }
        }
        if (!foundColor)
        {
            Console.WriteLine("Your input is not on the list .. ");
        }

        //Part 6 mark unique and duplicte like tags on messages.
        List<string> letters = new List<string>()
        {
            "A",
            "B",
            "C",
            "D",
            "C",
            "A"
        };

        List<string> seenLetters = new List<string>();

        foreach (string letter in letters)
        {

            if (seenLetters.Contains(letter))
            {
                 Console.WriteLine(letter + " = this item is a duplicate");

            }
            else
            {
                 Console.WriteLine(letter + " = this item is unique");
                seenLetters.Add(letter);
            }
       
       
           

        }
        




    }
}
