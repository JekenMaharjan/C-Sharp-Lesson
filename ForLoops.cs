using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class ForLoops
    {
        public static void ForLoop()
        {
            int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
