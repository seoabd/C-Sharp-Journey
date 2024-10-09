﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchstatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2: Console.WriteLine("Tue");
                    break;
                case 3: Console.WriteLine("Wed");
                    break;
                case 4: Console.WriteLine("Thur");
                    break;
                case 5: Console.WriteLine("Fri");
                    break;
                case 6: Console.WriteLine("Sat");
                    break;
                case 7: Console.WriteLine("Sun");
                    break;
                default: Console.WriteLine("Please enter the number between 1-7!");
                    break;
            }       


            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}