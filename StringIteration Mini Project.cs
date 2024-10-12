using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace StringIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awsome!";

            // String Iteration (Loop)
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(300);
            }
            Console.ReadLine();
        }
    }
}