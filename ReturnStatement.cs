using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class ReturnStatement
    {
        public static void ReturnState()
        {
            int numberToCube;

            Console.Write("Enter a number to cube: ");
            numberToCube = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The cube of the number is " + Cube(numberToCube));
        }

        static int Cube(int numCube)
        {
            int result = Convert.ToInt32(Math.Pow(numCube, 3));
            return result;
        }
    }
}
