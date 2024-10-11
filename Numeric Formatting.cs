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

            double value = 1000D / 12.34D;

            Console.WriteLine(value); // will show the whole numeric format!
            Console.WriteLine(string.Format("{0:0.00}", value));
                                                //after the first number it will show 2 numeric values rounded
            Console.ReadLine();
        }
    }
}