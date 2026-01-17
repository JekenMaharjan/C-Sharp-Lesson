using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class BuildingAnExponentMethod
    {
        public static void ExponentMethod()
        {
            Console.WriteLine(GetPow(5, 2));
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;  // result = result * baseNum
            }

            return result;
        }
    }
}
