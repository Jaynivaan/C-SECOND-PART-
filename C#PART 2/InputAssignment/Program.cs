using System;
using System.IO;

class Program
{
    static void Main()
    {
        //ask the user to enter a number
        Console.WriteLine("Enter a number: ");

        //read the number typed by the user
        String number= Console.ReadLine();
        
        //Define the file name werhere the number will be stored.
        string filePath = "numberLog.txt";

        
        //write the number to the textfile
        File.WriteAllText(filePath, number);

        //read the content from hte textfile
        string fileContent = File.ReadAllText(filePath);

        //pritn the content to the console
        Console.WriteLine("The number stored in the file is : ");
        Console.WriteLine(fileContent);

        //leave the console opene
        Console.ReadLine();

    }
}