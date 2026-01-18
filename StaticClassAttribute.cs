using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class StaticClassAttribute
    {
        public static void StaticClassAttri()
        {
            Console.WriteLine("\nNumbering number of Song every time a song is created...");
            Song song1 = new Song("Live Long", "Bishal Gautam", 5);
            Console.WriteLine(song1.getSongCount());
            Song song2 = new Song("Tail of Fox", "Vishor Shall", 6);
            Console.WriteLine(song2.getSongCount());
        }
    }
}
