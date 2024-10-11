using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericFormatting
{
    class Program
    {
        static void Main(string[] args)
        {

            double value = 1000D / 12.34D;       //we place the D so it doesn´t convert the value to int!

            Console.WriteLine(value); // will show the whole numeric format!
            Console.WriteLine(string.Format("{0:0.00}", value));
                                                //after the first number it will show 2 numeric values rounded
           
            
            // to Print out the currency type
            Console.WriteLine(value);
            Console.WriteLine(string.Format("The currency result is: eu{0:0.00}", value));
            Console.WriteLine(value.ToString("C"));
            
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
            
            
            Console.ReadLine();
        }
    }
}
