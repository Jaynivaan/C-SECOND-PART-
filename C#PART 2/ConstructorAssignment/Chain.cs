using System;

namespace ConstructorAssignment
{
    public class Chain
    {
        //Constructor when only a number is provided
        public Chain (float num1) : this(num1, "Bob")
        {
            Console.WriteLine(num1 + " and  your default name is  " + Name);
        }

        //constructor when only name is provided
        public Chain (string name1) : this (42, name1)
        {
            Console.WriteLine(name1 + " and your default favourite number is " + Num);

        }

        //constructor when both parameter are provided
        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }
        //Properties
        string  Name { get; set; }
        float Num { get; set;}
    }
}