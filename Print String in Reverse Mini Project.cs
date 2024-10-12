using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;


namespace Exercise
{
    class Program
    {
        //Ask a user to input message
        //Print in order
        //Print in reverse
        
        
        
        
        static void Main(string[] args)
        {
            Console.Write("Enter your full name please: ");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
                Console.WriteLine();
                
            }
                Console.WriteLine();

          
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }



            Console.ReadLine();
        }
    }
}