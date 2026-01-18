using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Inheritance
    {
        public static void Inherit()
        { 
            Chef chef = new Chef();
            Console.WriteLine("\nWhat do chef make?\n");
            chef.MakePasta();
            chef.MakeCoffee();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            Console.WriteLine("\nWhat do ItalianChef make?\n");
            italianChef.MakePasta();
            italianChef.MakeCoffee();
            italianChef.MakeSpecialDish();
            italianChef.MakeHotDog();
        }
    }
}
