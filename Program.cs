using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C_Sharp_Lesson_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------- 1) Drawing a Shape ---------------
            DrawingAShape.Draw();

            // --------------- 2) Variables ---------------
            Variables.Run();

            // --------------- 3) Data Types ---------------
            DataTypes.Data();

            // --------------- 4) Working with Strings ---------------
            WorkingWithStrings.strings();

            


            


            /*

            


            // --------------- 5) Working with Numbers ---------------

            int a = 24;
            int b = 53;

            Console.WriteLine(a + b);               // 77
            Console.WriteLine(Math.Min(a, b));      // 24
            Console.WriteLine(Math.Max(a, b));      // 53
            Console.WriteLine(Math.Sqrt(36));       // 6
            Console.WriteLine(Math.Abs(-b));        // 53
            Console.WriteLine(Math.Round(6.2));     // 6
            Console.WriteLine(Math.Pow(5, 2));      // 25

            Console.WriteLine("------------------------------------------------------");


            // --------------- 6) Getting User Input ---------------

            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string yourAge = Console.ReadLine();

            Console.WriteLine("Hi! " + yourName + "." + "You are " + yourAge + " years old.");

            Console.WriteLine("------------------------------------------------------");


            // --------------- 7) Building a Calculator ---------------

            // Simple add, substract, multiply, divide

            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);

            Console.WriteLine("------------------------------------------------------");


            // --------------- 8) Building a Mad Libs Game ---------------

            Console.WriteLine("Roses are red");
            Console.WriteLine("Violets are blue");
            Console.WriteLine("I Love You");

            string color, thing, favPerson;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a thing: ");
            thing = Console.ReadLine();

            Console.Write("Enter your favPerson: ");
            favPerson = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(thing + " are blue");
            Console.WriteLine("I Love " + favPerson);

            Console.WriteLine("------------------------------------------------------");


            // --------------- 9) Arrays ---------------

            int[] randomNum = {0, 2, 4, 5, 7, 8, 10};
            string[] friends = new string[5];
            friends[0] = "Ram";
            friends[1] = "Shyam";
            friends[2] = "Gita";
            friends[3] = "Gorey";
            friends[4] = "Adams";

            Console.WriteLine("The Random number is " + randomNum[5]);
            Console.WriteLine("My friends are " + friends[0] + ", " + friends[2] + ", " + friends[4]);

            Console.WriteLine("------------------------------------------------------");


            // --------------- 10) Methods ---------------

            string welcomeName;
            int welcomeAge;

            Console.Write("What's your name: ");
            welcomeName = Console.ReadLine();

            Console.Write("What's your age: ");
            welcomeAge = Convert.ToInt32(Console.ReadLine());

            SayHello(welcomeName, welcomeAge);

            Console.WriteLine("------------------------------------------------------");


            // --------------- 11) Return Statement ---------------

            int numberToCube;

            Console.Write("Enter a number to cube: ");
            numberToCube = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The cube of the number is " + Cube(numberToCube));

            Console.WriteLine("------------------------------------------------------");


            // --------------- 12) If Statement ---------------

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
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are tall but not a male.");
            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You are a male but not tall.");
            }
            else
            {
                Console.WriteLine("You are neither tall nor male.");
            }

            Console.WriteLine("------------------------------------------------------");


            // --------------- 13) More If Statements ---------------

            int a1, a2, a3;

            Console.WriteLine("Max number among 3 numbers:\n");

            Console.Write("Enter first number: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Max number out of " + a1 + "," + a2 +  "," + a3 + " is " + GetMax(a1, a2, a3));
            
            Console.WriteLine("------------------------------------------------------");


            // --------------- 14) Building a better Calculator ---------------

            Console.Write("Enter a Number: ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a Number: ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Result is " + Calc(c1, op, c2));

            Console.WriteLine("------------------------------------------------------");


            // --------------- 15) Switch Statements ---------------

            Console.WriteLine(GetDay(1));

            Console.WriteLine("------------------------------------------------------");


            // --------------- 16) While Loops ---------------

            int index1 = 1;
            while (index1 <= 5)
            {
                Console.WriteLine(index1);
                index1++;
            }

            Console.WriteLine("------------------------------------------------------");


            // --------------- 17) Do While Loops ---------------

            int index2 = 1;
            do
            {
                Console.WriteLine(index2);
                index2++;
            }while(index2 <= 5);

            Console.WriteLine("------------------------------------------------------");


            // --------------- 18) Building a Guessing Game ---------------

            string secretWord = "professional";
            string GuessedWord = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outofLives = false;

            while (GuessedWord != secretWord && !outofLives)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter the Guessing Word:");
                    GuessedWord = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outofLives = true;
                }
            }

            if (outofLives)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }

            Console.WriteLine("------------------------------------------------------");


            // --------------- 19) For Loops ---------------

            int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9 };

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("------------------------------------------------------");


            // --------------- 20) Building an Exponent Method ---------------

            Console.WriteLine(GetPow(5, 2));

            Console.WriteLine("------------------------------------------------------");


            // --------------- 21) 2D Arrays ---------------

            int[,] matrix = {
                {1, 2, 3 },
                {4, 5, 6 },
                {5, 6, 7 }
            };

            Console.WriteLine(matrix[2,2]);

            Console.WriteLine("------------------------------------------------------");


            // --------------- 22) Comments ---------------

            // For single line comment, use "//".
            Console.WriteLine("For single line comment, use "//");

            // For multiple line comment, use "/ * all comments here * /".
            Console.WriteLine("For multiple line comment, use "/ * all comments here * /");

            Console.WriteLine("------------------------------------------------------");


            // --------------- 23) Exception Handling ---------------

            try
            {
                Console.WriteLine("Enter Dividend: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Divisor : ");
                int y = Convert.ToInt32(Console.ReadLine());

                double result = Convert.ToDouble(x/y);
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

            Console.WriteLine("------------------------------------------------------");


            */
            // --------------- 24) Exception Handling ---------------


            // use to read input and to make the output hold
            Console.ReadLine();
        }

        static void SayHello(string helloName, int helloAge)
        {
            Console.WriteLine("Hello! " + helloName + " and you're " + helloAge + "years old.");
        }

        static int Cube(int numCube)
        {
            int result = Convert.ToInt32(Math.Pow(numCube, 3));
            return result;
        }

        static int GetMax(int n1, int n2, int n3)
        {
            int result = 0;

            if (n1 >= n2 && n1 >= n3)
            {
                result = n1;
            }
            else if ( n2 >= n1 && n2 >= n3)
            {
                result = n2;
            }
            else
            {
                result = n3;
            }
                return result;
        }

        static double Calc(double x1, string oper, double x2)
        {
            double result = 0;

            if (oper == "+")
            {
                result = (x1 + x2);
            }
            else if (oper == "-")
            {
                result = (x1 - x2);
            }
            else if ( oper == "*")
            {
                result = (x1 * x2);
            }
            else if (oper == "/")
            {
                result = (x1 / x2);
            }
            else
            {
                Console.WriteLine("Invalid Operator!");
            }

            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid Day Number!";
                    break;
            }

            return dayName;
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum ; i++)
            {
                result *= baseNum;  // result = result * baseNum
            }

            return result;
        }
    }
}
