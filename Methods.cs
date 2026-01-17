using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Methods
    {
        public static void Method()
        {
            string welcomeName;
            int welcomeAge;

            Console.Write("What's your name: ");
            welcomeName = Console.ReadLine();

            Console.Write("What's your age: ");
            welcomeAge = Convert.ToInt32(Console.ReadLine());

            SayHello(welcomeName, welcomeAge);
        }
        static void SayHello(string helloName, int helloAge)
        {
            Console.WriteLine("Hello! " + helloName + " and you're " + helloAge + "years old.");
        }
    }
}
