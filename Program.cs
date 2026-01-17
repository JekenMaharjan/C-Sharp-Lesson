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

            // --------------- 14) Building a better Calculator ---------------
            BuildingABetterCalculator.BuildingBetterCalc();
            
            // --------------- 15) Switch Statements ---------------
            SwitchStatements.SwitchState();

            // --------------- 16) While Loops ---------------
            WhileLoops.WhileLoop();

            // --------------- 17) Do While Loops ---------------
            DoWhileLoops.DoWhileLoop();

            // --------------- 18) Building a Guessing Game ---------------
            BuildingAGuessingGame.GuessGame();

            // --------------- 19) For Loops ---------------
            ForLoops.ForLoop();

            // --------------- 20) Building an Exponent Method ---------------
            BuildingAnExponentMethod.ExponentMethod();

            // --------------- 21) 2D Arrays ---------------
            _2DArrays._2DArr();


            




            /*
            



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
    }
}
