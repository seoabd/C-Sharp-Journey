using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;

            int balance = 3000;  // so if we wanna get the 20% of the 3000 the operation follows:
            Console.WriteLine(balance * (vat / 100D));

            //vat = 10; // we will get a compile error because the vat cannot be changed bc of the "const".


            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}