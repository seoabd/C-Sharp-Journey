using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forfLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What word do you want to say?: ");
            string message = Console.ReadLine();
            
            Console.Write("How many time do you want to say the word: ");
            int loopcounter = Convert.ToInt32(Console.ReadLine());

            if (loopcounter <= 0)
            {
                Console.WriteLine("Please enter a number above 0");
            }
            else
            {
                for (int i = 0; i < loopcounter; i++)
                {
                    Console.WriteLine(message);
                }
            }
            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}