using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    /// Представляет трехзначное число, записанное теми же цифрами в обратном порядке.
    /// </summary>
    internal static class Expr2
    {
        internal static void Method(int number)
        {
            var strNumber = number.ToString().ToCharArray();
            Console.WriteLine(number);
            (strNumber[0],strNumber[2]) = (strNumber[2],strNumber[0]);
            Console.WriteLine(strNumber);
            Console.WriteLine("------------------------------");
        }
    }
}
