using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringUserData
{
    class Program
    {
        //Define a variable to hold your name
        //Define a variable to hold your phone number
        //Define a variable to hold your age
        //Print variables line-by-line to the screen
        //extra defome variables using the var keyword
        static void Main(string[] args)
        {    
            string name = "Sead";
            //int phone = 017664822111; // if go with int it wont compile bc the value is too long
            // if we go with long it wont show us the value 0
            string phone = "01766482211"; // with the string it shows the 0 as a value.
            int age = 39;
            Console.WriteLine(name);
            Console.WriteLine(phone);
            Console.WriteLine(age);

            // for var we go with var name = "Sead"; var phone ="017664822111" & var age = 39;
           
            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}