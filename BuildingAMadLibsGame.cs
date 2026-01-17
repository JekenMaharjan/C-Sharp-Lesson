using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class BuildingAMadLibsGame
    {
        public static void MadLibsGame()
        {
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
        }
    }
}
