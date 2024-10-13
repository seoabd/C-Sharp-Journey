using System;
using System.ComponentModel;
using System.Threading;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Threading.Tasks;

namespace Passwordcheckerminiproject

{
    class Program
    {
      
        static void Main(string[] args)
        {

            Console.Write("Please enter your password: ");
            string password1 = Console.ReadLine();

            Console.Write("Please enter your password again: ");
            string password2 = Console.ReadLine();


            bool bothNull = string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2);    // I prefered to solve the Problem with a bool

            // to.Lower is not preferable used for sensitive data!

            if (bothNull)   // we could type an if statement like follows: (!password1.Equals(string.Empty) && !password2.Equals(string.Empty))
            { 
                
                Console.WriteLine("Please enter a valid charachter of Password!: ");
            }

            else if (password1.Equals(password2))
            {
                Console.WriteLine("Your password do match");
            }
            else if (!password1.Equals(password2))
            {
                Console.WriteLine("Your password do not match");
            }

            Console.ReadLine();
        }
    }

}