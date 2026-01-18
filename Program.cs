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
            Console.WriteLine("MAIN MENU\n");
            Console.WriteLine("1. Drawing a Shape");
            Console.WriteLine("2. Variables");
            Console.WriteLine("3. Data Types");
            Console.WriteLine("4. Working with Strings");
            Console.WriteLine("5. Working with Numbers");
            Console.WriteLine("6. Getting User Input");
            Console.WriteLine("7. Building a Calculator");
            Console.WriteLine("8. Building a Mad Libs Game");
            Console.WriteLine("9. Arrays");
            Console.WriteLine("10. Methods");
            Console.WriteLine("11. Return Statement");
            Console.WriteLine("12. If Statement");
            Console.WriteLine("13. More If Statements");
            Console.WriteLine("14. Building a better Calculator");
            Console.WriteLine("15. Switch Statements");
            Console.WriteLine("16. While Loops");
            Console.WriteLine("17. Do While Loops");
            Console.WriteLine("18. Building a Guessing Game");
            Console.WriteLine("19. For Loops");
            Console.WriteLine("20. Building an Exponent Method");
            Console.WriteLine("21. 2D Arrays");
            Console.WriteLine("22. Comments");
            Console.WriteLine("23. Exception Handling");
            Console.WriteLine("24. Classes and Objects");
            Console.WriteLine("25. Constructors");
            Console.WriteLine("26. Object Methods");
            Console.WriteLine("27. Getters And Setters");
            Console.WriteLine("28. Static Class Attribute");
            Console.WriteLine("29. Static Methods and Classes");
            Console.WriteLine("30. Inheritance");

            Console.Write("\nEnter Your Choice : ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DrawingAShape.Draw();
                    break;

                case 2:
                    Variables.Run();
                    break;

                case 3:
                    DataTypes.Data();
                    break;

                case 4:
                    WorkingWithStrings.Strings();
                    break;

                case 5:
                    WorkingWithNumbers.Numbers();
                    break;

                case 6:
                    GettingUserInput.Input();
                    break;

                case 7:
                    BuildingACalculator.SimpleCalc();
                    break;

                case 8:
                    BuildingAMadLibsGame.MadLibsGame();
                    break;

                case 9:
                    Arrays.Arr();
                    break;

                case 10:
                    Methods.Method();
                    break;

                case 11:
                    ReturnStatement.ReturnState();
                    break;

                case 12:
                    IfStatement.IfState();
                    break;

                case 13:
                    MoreIfStatement.MoreIfState();
                    break;

                case 14:
                    BuildingABetterCalculator.BuildingBetterCalc();
                    break;

                case 15:
                    SwitchStatements.SwitchState();
                    break;

                case 16:
                    WhileLoops.WhileLoop();
                    break;

                case 17:
                    DoWhileLoops.DoWhileLoop();
                    break;

                case 18:
                    BuildingAGuessingGame.GuessGame();
                    break;

                case 19:
                    ForLoops.ForLoop();
                    break;

                case 20:
                    BuildingAnExponentMethod.ExponentMethod();
                    break;

                case 21:
                    _2DArrays._2DArr();
                    break;

                case 22:
                    Comments.Comment();
                    break;

                case 23:
                    ExceptionHandling.ExceptionHandle();
                    break;

                case 24:
                    ClassesAndObjects.ClassObj();
                    break;

                case 25:
                    Constructors.Construct();
                    break;

                case 26:
                    ObjectMethods.ObjMethod();
                    break;

                case 27:
                    GetterAndSetter.GetSet();
                    break;

                case 28:
                    StaticClassAttribute.StaticClassAttri();
                    break;

                case 29:
                    StaticMethodsAndClasses.StaticMethodClass();
                    break;

                case 30:
                    Inheritance.Inherit();
                    break;

                default:
                    break;
            }

            // use to read input and to make the output hold
            Console.ReadLine();
        }   
    }
}
