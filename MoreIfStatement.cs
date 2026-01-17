using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class MoreIfStatement
    {
        public static void MoreIfState()
        {
            int a1, a2, a3;

            Console.WriteLine("Max number among 3 numbers:\n");

            Console.Write("Enter first number: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Max number out of " + a1 + "," + a2 + "," + a3 + " is " + GetMax(a1, a2, a3))
        }
    }
}
