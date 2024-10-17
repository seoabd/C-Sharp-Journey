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
                0,1,2,3,4,5,6,7,8,9,10
            };

            //Array.Clear(numbers, 0, numbers.Length);   // index, length

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = default;  // or you can type 0
            }


            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }



            Console.ReadKey();


        }

    }

}