using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;


namespace ContainsStringIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awsome!";

            
            Console.WriteLine(message.Contains("C"));

            // Contains for a letter in a sentence

            bool contains = false;

            for (int i = 0;i < message.Length; i++)
            {
                if (message[i].Equals('l'))   // (message[i] == ('l'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);
            Console.ReadLine();
        }
    }
}