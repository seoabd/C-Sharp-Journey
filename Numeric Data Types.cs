using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            // or we can use this form:
            // int age;
            // age = 23;
            Console.WriteLine(age);
            //extra
            Console.WriteLine(int.MinValue);  // We can print how small are the numbers
            Console.WriteLine(int.MaxValue); //  We can print how big are the numbers 

            long bigNumber = 900000000L;

            Console.WriteLine(bigNumber);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            
            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}
