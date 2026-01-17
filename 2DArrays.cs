using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class _2DArrays
    {
        public static void _2DArr()
        {
            int[,] matrix = {
                {1, 2, 3 },
                {4, 5, 6 },
                {5, 6, 7 }
            };

            Console.WriteLine(matrix[2, 2]);
        }
    }
}
