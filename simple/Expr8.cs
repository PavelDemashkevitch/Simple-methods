using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    /// Находит точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку M.
    /// L -- Ax + By + C = 0, M (x, y).
    /// </summary>
    internal class Expr8
    {
        internal static void Method(double A, double B, double C, (double x, double y) M)
        {
            double y = (M.x * A * B + A * A * M.y - B * C) / (B * B + A * A);
            double x = -C / A - B / A * y;
            Console.WriteLine($"Точка пересечения Q прямой {A}x + {B}y + {C} = 0 и прямой P с точкой M({M.x},{M.y})");
            Console.WriteLine($"                                    Q({x}:{y})");
            Console.WriteLine("------------------------------");
        }
    }
}
