using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class ClassesAndObjects
    {
        public static void ClassObj()
        {
            Books book1 = new Books();
            book1.BookName = "The Alchemist";
            book1.AuthorName = "Paulo Coelho";
            book1.Price = 600;

            Books book2 = new Books();
            book2.BookName = "Think and Grow Rich";
            book2.AuthorName = "Napoleon Hill";
            book2.Price = 750;

            Console.WriteLine(book1.BookName);
            Console.WriteLine(book1.AuthorName);
            Console.WriteLine(book1.Price + "\n");

            Console.WriteLine(book2.BookName);
            Console.WriteLine(book2.AuthorName);
            Console.WriteLine(book2.Price);
        }
    }
}
