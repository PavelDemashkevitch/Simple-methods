using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    /// Находит вектор, параллельный прямой. Перпендикулярный прямой.
    /// Прямая задана коэффициентами уравнения прямой. Y = kX + c
    /// </summary>
    internal class Expr7
    {
        internal static void Method(double k, double c)
        {
            Console.WriteLine($"Вектор параллельный прямой Y = {k}X + {c} есть вектор (1;{k})");
            Console.WriteLine($"Вектор перпендикулярный прямой Y = {k}X + {c} есть вектор (-{k};1)");
            Console.WriteLine("------------------------------");
        }
    }
}
