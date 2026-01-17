using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class BuildingABetterCalculator
    {
        public static void BuildingBetterCalc()
        {
            Console.Write("Enter a Number: ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a Number: ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Result is " + Calc(c1, op, c2));
        }

        static double Calc(double x1, string oper, double x2)
        {
            double result = 0;

            if (oper == "+")
            {
                result = (x1 + x2);
            }
            else if (oper == "-")
            {
                result = (x1 - x2);
            }
            else if (oper == "*")
            {
                result = (x1 * x2);
            }
            else if (oper == "/")
            {
                result = (x1 / x2);
            }
            else
            {
                Console.WriteLine("Invalid Operator!");
            }

            return result;
        }
    }
}
