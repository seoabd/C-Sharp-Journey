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
            string age = Console.ReadLine();
            
              // if we want to convert the value to int!
             // string ageInput = Console.Readline();
             // int age = Convert.ToInt32(ageInput);
            
            //Console.WriteLine(age);

            Console.Write("Your name is " + name + " and your age is " + age);
            

            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}
