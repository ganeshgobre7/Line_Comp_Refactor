using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorLineComp
{
   public class Length
    {
        public static void calculate()
        {
            int x1, x2, y1, y2;
            double line_One;
            x1 = 3; y1 = 4; x2 = 4; y2 = 3;

            int equation_One = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            line_One = Math.Abs((0.5) * equation_One);
            Console.WriteLine("Length of Coordinates :" + line_One);
        }
    }
}
