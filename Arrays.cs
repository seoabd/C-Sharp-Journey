using System;
using System.ComponentModel;
using System.Threading;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Threading.Tasks;

namespace arrays

{
    class Program
    {

        static void Main(string[] args)
             
        {



            /*Console.Write("Please enter your number: ");                    // We can do this with a for loop like below!
            numbers[0] = Convert.ToInt32(Console.ReadLine());                      

            Console.Write("Please enter your number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter your number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());*/


            int[] numbers = new int[4]; // we have for positions it goes from 0-4
            
            for (int i = 0; i < numbers.Length; i++) //0-3 / 0 0 = 0+1
            {
                Console.Write("Please enter your number: ");                          // We can do this with a for loop like below! So here is to store the numbers!
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]}");  // We can do this with a for loop like below!

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");        // and to print the numbers stored from the userinput
            }
            Console.ReadLine(); 

            


        }
    }

}
