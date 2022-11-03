using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    ///  Находит количество високосных лет на отрезке [a, b] не используя циклы.
    /// </summary>
    internal static class Expr5
    {
        internal static void Method(int a, int b)
        {
            int c = b > a ? b - a : a - b;
            int m = a / 4 == 0 && (a / 100 != 0 || a / 400 == 0) ? 1 : 0;
            m = a / 4 == 0 && (b / 100 != 0 || b / 400 == 0) ? m++ : m;
            int x = c / 4;
            int y = c / 100;
            int z = c / 400;
            
            Console.WriteLine(x - y + z + m);
            Console.WriteLine("------------------------------");
        }
    }
}
