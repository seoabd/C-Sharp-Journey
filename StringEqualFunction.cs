using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrinEqualfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }
            Console.ReadLine();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //if (name != "")
            if (!name.Equals(string.Empty)) // (name != "")
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("You entered an empty input!");
            }
            
            Console.ReadLine();
        }
    }
}