using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class WorkingWithNumbers
    {
        public static void Numbers() 
        {
            int a = 24;
            int b = 53;

            Console.WriteLine(a + b);               // 77
            Console.WriteLine(Math.Min(a, b));      // 24
            Console.WriteLine(Math.Max(a, b));      // 53
            Console.WriteLine(Math.Sqrt(36));       // 6
            Console.WriteLine(Math.Abs(-b));        // 53
            Console.WriteLine(Math.Round(6.2));     // 6
            Console.WriteLine(Math.Pow(5, 2));      // 25
        }
    }
}
