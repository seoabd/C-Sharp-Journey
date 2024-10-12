using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Numerics;
using System.ComponentModel.Design;
using System.Data;

namespace FizzBuzzforloopaction
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numdiv3 = false;
            bool numdiv5 = false;
            bool numfizzbuzz = false;   

            for (int i = 0; i <= 15; i++)
            {
                numdiv3 % 3 == 0;
                numdiv5 % 5 == 0;
                numfizzbuzz = numdiv3 && numdiv5;

                if (numfizzbuzz)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (numdiv3)
                {
                    Console.WriteLine("Fizz");
                }
                else if (numdiv5)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                
            }

            Console.ReadLine();
        }
    }
}