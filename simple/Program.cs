using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    internal class Program
    {
        static void Main()
        {
            Expr1.Method();

            Expr2.Method(number: 123);

            Expr3.Method(hour: new List<int>() { 2, 6, 10 });

            Expr4.Method(20, 1, 3);

            Expr5.Method(1150, 1660);

            Expr6.Method(Ab: (1, 4), aB: (3, 6), c: (5, 6));

            Expr7.Method(k: 1, c: 0);

            Expr8.Method(A: 1, B: -1, C: 0, (x: 0, y: 2));
        }
    }
}
