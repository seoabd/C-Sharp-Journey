using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            string textAge = "23";
            int age = Convert.ToInt32(textAge); // int is System.Int32
            Console.WriteLine(age);

            string doubleNegative = "-22,2";
            double negative = Convert.ToDouble(doubleNegative); // double is System.double
            Console.WriteLine(negative);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber); // long is System.Int64
            Console.WriteLine(bigNumber);

            string Precision = "4.00001";
            float precision = Convert.ToSingle(Precision); //Float is System.Single
            Console.WriteLine(precision);

            string bigMoney = "17,99";
            decimal money = Convert.ToDecimal(bigMoney); //decimal is Decimal
            Console.WriteLine(money);
            


            Console.ReadLine(); // So the Application doesn´t close immediately
        }
    }
}
