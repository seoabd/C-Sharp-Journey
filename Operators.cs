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
                    // age *= 10 ;        or  age /= 10;
            Console.WriteLine(age);
            // if you do division the best operation is as follows:

            double age = 23;
            age /= 10;   // the result gonna be precise = 2.3 and not 2 (with int).
            Console.WriteLine(age);

            
            age--;   // age = age - 1;    or age -= 1;
            Console.WriteLine(age);


            string name = "Aba";
            name += " is programming";
            Console.WriteLine(name);   // the result gonna be "Aba is programming"

            // But it is not the same with Char!

            char ch = 'A'
            ch += 'B'  // the output is gonna be the uni code values for both of these items and try add them together as integer!

            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}
