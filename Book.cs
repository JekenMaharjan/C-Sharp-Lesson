using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Book
    {
        public string BookName;
        public string AuthorName;
        public int Price;

        public Book(string aBookName, string aAuthorName, int aPrice)
        {
            BookName = aBookName;
            AuthorName = aAuthorName;
            Price = aPrice;
        }
    }
}
