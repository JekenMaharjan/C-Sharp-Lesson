using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class DataTypes
    {
        public static void Data()
        {
            string phrase = "C sharp course";
            char grade = 'A';
            int myAge = 40;
            double gpa = 3.6; // float, double, decimal
            bool isMale = true;

            // here, "home", 30 and false are constants.
            Console.WriteLine("home");  // home
            Console.WriteLine(30);      // 30
            Console.WriteLine(false);   // false
            Console.WriteLine(myAge);   // 40
            Console.WriteLine(isMale);  // true
            Console.WriteLine(phrase);  // C sharp course
        }
    }
}
