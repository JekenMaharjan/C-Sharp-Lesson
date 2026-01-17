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
            WorkingWithStrings.Strings();

            // --------------- 5) Working with Numbers ---------------
            WorkingWithNumbers.Numbers();

            // --------------- 6) Getting User Input ---------------
            GettingUserInput.Input();

            // --------------- 7) Building a Calculator ---------------
            BuildingACalculator.SimpleCalc();

            // --------------- 8) Building a Mad Libs Game ---------------
            BuildingAMadLibsGame.MadLibsGame();

            // --------------- 9) Arrays ---------------
            Arrays.Arr();

            // --------------- 10) Methods ---------------
            Methods.Method();
            
            // --------------- 11) Return Statement ---------------
            ReturnStatement.ReturnState();

            // --------------- 12) If Statement ---------------
            IfStatement.IfState();
            
            // --------------- 13) More If Statements ---------------
            MoreIfStatement.MoreIfState();


            




            /*


            




           
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
