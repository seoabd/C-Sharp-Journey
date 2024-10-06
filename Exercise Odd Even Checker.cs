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
        //Create & initialise two ints
        //Make a variable to work out the remainder
        //Output remainder to the screen
        //Change the first int variable to another number
           // and recalculate the remainder
           // output new remainder to the screen.
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 2;
            Console.WriteLine(firstNum % secondNum);

            int firstNumber = (firstNum + 3);
            Console.WriteLine(firstNumber % secondNum);


            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}