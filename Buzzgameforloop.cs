﻿using System;
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
           

            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
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