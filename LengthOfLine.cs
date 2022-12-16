using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LengthOfLine
    {
        public static void Length_Of_line()
        {
            int x1 = 10; int y1 = 20;
            int x2 = 30; int y2 = 50;
            
            double X1 = Math.Pow((x2 - x1), 2); 
            double Y1 = Math.Pow((y2 - y1), 2); 
            double length = Math.Sqrt(X1 + Y1);
            Console.WriteLine(length);
            
        }
    }
}