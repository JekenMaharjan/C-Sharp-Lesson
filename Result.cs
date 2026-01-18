using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class Result
    {
        public string Name;
        public double Maths;
        public double Science;
        public double English;

        public Result(string aName, double aMaths, double aScience, double aEnglish)
        {
            Name = aName;
            Maths = aMaths;
            Science = aScience;
            English = aEnglish;
        }

        public bool PassFail()
        {
            if (Maths < 36 && Science < 36 && English < 36)
            {
                Console.WriteLine($"{Name}: You failed all subjects!");
                return false;
            }
            else if (Science < 36 && English < 36)
            {
                Console.WriteLine($"{Name}: You failed Science and English!");
                return false;
            }
            else if (Science < 36)
            {
                Console.WriteLine($"{Name}: You failed Science!");
                return false;
            }
            else
            {
                Console.WriteLine($"{Name}: Congratulations! You Passed!");
                return true;
            }
        }
    }
}
