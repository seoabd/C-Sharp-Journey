using System;
using System.ComponentModel;
using System.Threading;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics.CodeAnalysis;



namespace Lists

{
    class Program
    {
        

        static void Main(string[] args)

        {

            int[] numbers = new int[3]
            {
                1, 2, 3
            };

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write(listNumbers[i]);
            }

            Console.ReadLine();


        }


    }

}