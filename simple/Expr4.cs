using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    /// Находит количество чисел меньших N, которые имеют простые делители X или Y.
    /// </summary>
    internal static class Expr4
    {
        static int Count { get; set; } = 0;
        internal static void Method(int N, int X, int Y)
        { 
            while(N > 0)
            {
                Count = N % X != 0 || N % Y != 0 ? Count : Count + 1;
                N--;
            }
            Console.WriteLine(Count);
            Console.WriteLine("------------------------------");
        }
    }
}
