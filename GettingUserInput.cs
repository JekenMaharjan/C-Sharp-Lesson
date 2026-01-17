using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class GettingUserInput
    {
        public static void Input()
        {
            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string yourAge = Console.ReadLine();

            Console.WriteLine("Hi! " + yourName + "." + "You are " + yourAge + " years old.");
        }
    }
}
