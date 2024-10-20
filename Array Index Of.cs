using System;
using System.ComponentModel;
using System.Threading;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics.CodeAnalysis;



namespace arrayclearing

{
    class Program
    {

        static void Main(string[] args)

        {

            int[] numbers = new int[]
            {
                85, 100, 22, 99, 333, 5
            };

            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32( Console.ReadLine() ); 

            int position = Array.IndexOf( numbers, search ); // After search if you add 2 it will search for the number starting at the second position!

            if (position > -1) // 0 ->
            {
                Console.WriteLine($"Your number {search} has been found at {position +1}");
            }
            else
            {
                Console.WriteLine($"Your number {search} does not exist.");
            }
            Console.ReadKey();


        }

    }

}