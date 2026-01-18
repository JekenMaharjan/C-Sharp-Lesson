using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class GetterAndSetter
    {
        public static void GetSet()
        {
            Movies movie1 = new Movies("Raid", 2020, 7);
            Movies movie2 = new Movies("Syan", 2024, 3.5);

            Console.WriteLine("\nMovies\n");

            Console.WriteLine("Title : " + movie1.title);
            Console.WriteLine("Released : " + movie1.year);
            Console.WriteLine("Rating : " + movie1.Rating + "\n");

            Console.WriteLine("Title : " + movie2.title);
            Console.WriteLine("Released : " + movie2.year);
            Console.WriteLine("Rating : " + movie2.Rating + "\n");
        }
    }
}
