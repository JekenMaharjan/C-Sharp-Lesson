using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes Pasta!");
        }

        public void MakeCoffee()
        {
            Console.WriteLine("The Chef makes Coffee!");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Chicken Biryani!");
        }
    }
}
