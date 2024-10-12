using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;


namespace StringisNullorEmptyfunction
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write($"Yourname is {name}");

            Console.WriteLine();

            if (!string.IsNullOrEmpty(name)) // null ""
            {
                Console.WriteLine("2");
            }
            Console.ReadLine();
        }
    }
}