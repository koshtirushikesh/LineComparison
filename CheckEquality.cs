using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class CheckEquality
    {
        public static void Length_Of_line()
        {
            int x1 = 10, y1 = 20, x2 = 30, y2 = 40;

            double X1 = Math.Pow((x2 - x1), 2);
            double Y1 = Math.Pow((y2 - y1), 2);
            double length1 = Math.Sqrt(X1 + Y1);

            int a1 = 30, b1 = 40, a2 = 50, b2 = 30;


            double A1 = Math.Pow((a2 - a1), 2);
            double B1 = Math.Pow((b2 - b1), 2);
            double length2 = Math.Sqrt(A1 + B1);

            if (length1 == length2)
            {
                Console.WriteLine("1st Line: {0} and 2nd line: {1} is equal in length ", length1, length2);
            }
            else
            {
                Console.WriteLine("1st Line: {0} and 2nd line: {1} is not equal in length ", length1, length2);
            }

        }
    }
}
