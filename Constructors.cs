using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Constructors
    {
        public static void Construct()
        {
            Book book1 = new Book("The Greedy Fox", "Geeta Shree", 900);
            Book book2 = new Book("Will This Work Well!", "Kiwin Bisnt", 500);

            Console.WriteLine("\n" + book1.BookName);
            Console.WriteLine(book1.AuthorName);
            Console.WriteLine(book1.Price + "\n");

            Console.WriteLine(book2.BookName);
            Console.WriteLine(book2.AuthorName);
            Console.WriteLine(book2.Price);
        }
    }
}
