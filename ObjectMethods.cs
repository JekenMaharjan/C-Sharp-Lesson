using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class ObjectMethods
    {
        public static void ObjMethod()
        {
            Result result1 = new Result("Ram", 52, 25, 32);
            Result result2 = new Result("Hari", 25, 62, 35);

            result1.PassFail();
            result2.PassFail();
        }
    }
}
