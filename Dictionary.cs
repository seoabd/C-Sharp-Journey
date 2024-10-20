using System;
using System.ComponentModel;
using System.Threading;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;



namespace Dictionary

{
    class Program
    {


        static void Main(string[] args)

        {

            Dictionary<int, string> names = new Dictionary<int, string>
            {
                { 1, "Aba"},
                { 2, "Fiki"}

            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);

            }    
                 
            foreach( KeyValuePair<int, string> pair in names)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Resul" },
                {"Physics", "Mania" }
            };

            // Console.WriteLine(teachers["math"]); //int.TryParse Convert
            
            if (teachers.TryGetValue("Math", out var teacher)) // you can run the code as out string teacher
            {
                Console.WriteLine(teacher);
            }


            Console.ReadLine();


        }


    }

}