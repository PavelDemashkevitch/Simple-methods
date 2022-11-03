using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    /// <summary>
    /// Вычисляет угол в градусах между часовой и минутной стрелками. 
    /// </summary>
    internal class Expr3
    {
        internal static void Method(List<int> hour)
        {
            foreach(var item in hour)
            {
                var degree = (item > 6 ? (12 - item): item) * 30;
                Console.WriteLine($"{item} ~ {degree}°C");
            }
            
            Console.WriteLine("------------------------------");
        }
    }
}
