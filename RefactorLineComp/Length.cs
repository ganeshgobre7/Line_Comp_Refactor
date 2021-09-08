using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorLineComp
{
   public class Length
    {
        public static void calculate()
        {
            int x1, x2, y1, y2, x3, x4, y3, y4;
            double line_One, line_Two;
            x1 = 3; y1 = 4; x2 = 4; y2 = 3;
            x3 = 3; y3 = 4; x4 = 4; y4 = 3;

            int equation_One = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            line_One = Math.Abs((0.5) * equation_One);
            Console.WriteLine("Length of Coordinates :" + line_One);

            int Equation_two = ((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            line_Two = Math.Abs((0.5) * Equation_two);
            Console.WriteLine("Length of line_two :" + line_Two);

            Console.WriteLine(line_One.Equals(line_Two));
            Console.WriteLine(line_One.CompareTo(line_Two));

        }
    }
       
}
