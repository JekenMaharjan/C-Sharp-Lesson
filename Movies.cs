using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Movies
    {
        public string title;
        public int year;
        private double rating; // Getter and Setter Example using private instead of public

        public Movies(string aTitle, int aYear, double aRating)
        {
            title = aTitle;
            year = aYear;
            Rating = aRating;
        }

        public double Rating
        {
            // Getter
            get
            {
                return rating;
            }

            // Setter
            set
            {
                if(value > 0 && value <= 5)
                {
                    rating = value;
                }
                else
                {
                    rating = 0;
                }
            }
        }
    }
}
