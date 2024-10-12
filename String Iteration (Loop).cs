using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIteration
{
    class Program
{
    static void Main(string[] args)
    {
        string message = "C# is awsome";
        //char []
        Console.WriteLine(message[0]); //C
        Console.WriteLine(message[1]); //#
        Console.WriteLine(message[2]); //
        Console.WriteLine(message[3]); //i

        Console.WriteLine();
        
        // String Iteration (Loop)
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
        }
        Console.ReadLine();
    }
  }
}