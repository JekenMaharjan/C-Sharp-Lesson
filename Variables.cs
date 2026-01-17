using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Variables
    {
        public static void Run()
        {
            string name = "Ram";
            int age = 25;

            Console.WriteLine("There once was a man named " + name + ".");
            Console.WriteLine("He was " + age + " years old.");

            name = "Hari";
            age = 55;

            Console.WriteLine("He really liked the name " + name + ".");
            Console.WriteLine("But didn't like being " + age + ".");
        }
    }
}
