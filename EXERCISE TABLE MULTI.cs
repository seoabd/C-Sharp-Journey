using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
        
{
        // Ask the user for a number for the table
        // Write a for loop to print X times table
    static void Main(string[] args)
    {
            
            Console.Write("Please enter the number:  ");
            int loopcounter = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, loopcounter, i * loopcounter);
            }
            

            Console.ReadLine();
    }
}
}