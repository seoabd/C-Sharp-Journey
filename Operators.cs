using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            age++;
            
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            

            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}