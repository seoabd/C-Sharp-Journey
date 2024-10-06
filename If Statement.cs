using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            //Console.WriteLine(name);

            Console.WriteLine(); // if we want a gap between two questions!

            Console.Write("What is your age: ");
            string inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge); 
            
            // It is crusial to change to int because if the input is number and space it wont show us any value. Converting it to int is significally important!

            //Console.WriteLine(age);

            Console.Write("Your name is " + name + " and your age is " + age);

            if (age >= 18 && age <= 30)
            {
                Console.WriteLine();
                Console.Write("You are between 18 and 30");
            }
            else if (age >= 31)
            {
                Console.WriteLine();
                Console.WriteLine("Your are definetely older than 30");
            }

            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}
