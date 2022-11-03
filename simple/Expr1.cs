using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    /// Меняет местами значения двух переменных.
    /// </summary>
    internal static class Expr1
    {
        internal static void Method()
        {
            int a = 12;
            int b = 13;
            Console.WriteLine($"{a}, {b}");
            // 12, 13
            (a, b) = (b, a);
            Console.WriteLine($"{a}, {b}");
            // 13, 12
            Console.WriteLine("------------------------------");
        }
    }
}
