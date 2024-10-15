using System;
using System.ComponentModel;
using System.Threading;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics.CodeAnalysis;


namespace arrays Triangle Exercise

{
    class Program
    {

        static void Main(string[] args)

        {


            int[] angels = new int[3];

            for (int i = 0; i < angels.Length; i++)
            {
                Console.Write($"Please enter your angles{i + 1}? :");
                angels[i] = Convert.ToInt32(Console.ReadLine());
            }


            int angelsum = 0;

            foreach (int angel in angels)
            {
                angelsum += angel
            }


            Console.WriteLine($"Congratulations! You have a triangle {angelsum}");

            Console.ReadLine();

      
        }

    }

}