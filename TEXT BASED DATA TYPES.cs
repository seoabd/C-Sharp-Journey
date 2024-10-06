using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba";
            char letter = 'a';
            Console.Write("Your name is ");
            Console.Write(name);

            // or  Console.WriteLine("Your name is "+ name);
            //we leave a space so it char value doesnt attach to the string

            Console.WriteLine();
            Console.Write(letter);
           
            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}
