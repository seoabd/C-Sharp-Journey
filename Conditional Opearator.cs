using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 10;

            /*if (age >= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }*/

            // conditions ? true : false

            string answer = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(answer);
                
            Console.ReadLine();
        }
    }
}