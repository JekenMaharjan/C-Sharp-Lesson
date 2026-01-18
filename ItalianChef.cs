using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Master Mix Pizza Overloaded Cheese!");
        }

        public void MakeHotDog()
        {
            Console.WriteLine("The Chef makes HotDog!");
        }
    }
}
