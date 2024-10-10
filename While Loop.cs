using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            int firstnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your second number: ");
            int secondnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the value of" + firstnum + "x" + secondnum + "?");
            Console.WriteLine();
            
            int sum = firstnum * secondnum;
            int useranswer = 0;

            while (sum != useranswer)
            {
                Console.Write("Please enter your result: ");
                useranswer = Convert.ToInt32(Console.ReadLine());
                
                if (sum != useranswer)
                {
                    Console.WriteLine("Close, please try again! ");
                }
            
            }
            
            Console.WriteLine("Well Done!");

            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}