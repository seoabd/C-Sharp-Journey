using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementExerciseMultiplicationAnswer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter your first Number: ");
            string firstNum = Console.ReadLine();
            int NumA = Convert.ToInt32(firstNum);

            Console.Write("Enter your second Number: ");
            string secondNum = Console.ReadLine();
            int NumB = Convert.ToInt32(secondNum);

            int ActualSum = NumA * NumB;

            Console.Write("What is the value of " + NumA + "x" + NumB + "?: ");
            string TotalSum = Console.ReadLine();
            int wholeSum = Convert.ToInt32(TotalSum);

            if (ActualSum == wholeSum)
            {
                Console.WriteLine("Genius! Well done");
            }
            else
            {
                Console.WriteLine("Close,you can try it again :)");
            }
                







            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}