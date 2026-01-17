using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class WorkingWithStrings
    {
        public static void Strings()
        {
            string text = "Working With Strings";

            Console.WriteLine(text);                    // Working With Strings
            Console.WriteLine(text.Length);             // 20
            Console.WriteLine(text.ToLower());          // working with strings
            Console.WriteLine(text.ToUpper());          // WORKING WITH STRINGS
            Console.WriteLine(text.IndexOf('W'));       // 0
            Console.WriteLine(text[4]);                 // i
            Console.WriteLine(text.Substring(8, 4));    // With
        }
    }
}
