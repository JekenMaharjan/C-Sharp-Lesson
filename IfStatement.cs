using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class IfStatement
    {
        public static void IfState()
        {
            bool isMale, isTall;

            Console.WriteLine("Write true or false:");
            Console.Write("Male: ");
            isMale = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Tall: ");
            isTall = Convert.ToBoolean(Console.ReadLine());

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall but not a male.");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a male but not tall.");
            }
            else
            {
                Console.WriteLine("You are neither tall nor male.");
            }
        }
    }
}
