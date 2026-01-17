using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class BuildingACalculator
    {
        public static void SimpleCalc()
        {
            // Simple add, substract, multiply, divide

            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);
        }
    }
}
