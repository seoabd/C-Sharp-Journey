using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStringLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba";
            int age = 32;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age);  // "\n" produces a new line
            Console.WriteLine("Name: {0}\nAge: {1}",name, age);

            Console.WriteLine();    

            Console.WriteLine("Your name is " + name + ", and your age is " + age);
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);   // for the code to look more complete.

            Console.ReadLine();
        }
    }
}