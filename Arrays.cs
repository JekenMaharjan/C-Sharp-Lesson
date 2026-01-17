using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Arrays
    {
        public static void Arr()
        {
            int[] randomNum = { 0, 2, 4, 5, 7, 8, 10 };
            string[] friends = new string[5];
            friends[0] = "Ram";
            friends[1] = "Shyam";
            friends[2] = "Gita";
            friends[3] = "Gorey";
            friends[4] = "Adams";

            Console.WriteLine("The Random number is " + randomNum[5]);
            Console.WriteLine("My friends are " + friends[0] + ", " + friends[2] + ", " + friends[4]);
        }
    }
}
