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
            age++;  // age = age + 1;     or  age += 1;
            
            Console.WriteLine(age);
            age--;   // age = age - 1;    or age -= 1;
            Console.WriteLine(age);
            

            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}
