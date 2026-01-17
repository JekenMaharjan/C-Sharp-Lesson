using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class ExceptionHandling
    {
        public static void ExceptionHandle()
        {
            try
            {
                Console.WriteLine("Enter Dividend: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Divisor : ");
                int y = Convert.ToInt32(Console.ReadLine());

                double result = Convert.ToDouble(x / y);
                Console.WriteLine("Result : " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
