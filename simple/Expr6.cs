using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    /// Вычисляет расстояние от точки до прямой, заданной двумя разными точками.
    /// </summary>
    internal static class Expr6
    {
        static (double x, double y) A;
        static (double x, double y) B;
        static (double x, double y) C;
        internal static void Method((double, double) Ab, (double, double) aB, (double, double) c)
        {
            A = Ab;
            B = aB;
            C = c;

            double d = ((B.y - A.y) * (C.x - A.x) - (B.x - A.x) * (C.y - A.y)) / Math.Sqrt((B.y - A.y) * (B.y - A.y) + (B.x - A.x) * (B.x - A.x));
            Console.WriteLine($"({B.y - A.y})x + ({A.x - B.x})y + ({(B.x - A.x) * A.y - (B.y - A.y) * A.x}) = 0\n{d}");
            Console.WriteLine("------------------------------");
        }
    }
}
