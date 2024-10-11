using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a number: ");
            int UserType = Convert.ToInt32(Console.ReadLine());

            if ((UserType % 3 == 0) && (UserType % 5 == 0))
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (UserType % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (UserType % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(UserType);
            }
            Console.ReadLine();
        }
    }
}