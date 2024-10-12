using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStringLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            // \t \n \" \\ = \

            string speech = "He said" \"something\"";
            string path = "C:\\Users\\Benan\\Pictures\\Screenshots\nNew line test";
            Console.WriteLine(speech);
            Console.WriteLine(path);

            //$ +
            //$"Your name is {name}
            //"Your name is " + name

            path = @"C:\\Users\\Benan\\Pictures\\Screenshots\nNew line test" + "\nNew line tests";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello `someone´";
            Console.WriteLine(name);

            Console.ReadLine(); 
        }
    }
}
