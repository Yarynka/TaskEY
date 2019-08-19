using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class RectangleStatic
    {
       public static double a(double xl, double xr)
        {
            if (xl == xr)
            {
                Console.WriteLine("Прямокутника не існує:");
            }
            double a = xl - xr;
            if (a < 0) return a * (-1);
            else return a;

        }

        public static double b(double yl, double yr)
        {
            if (yl == yr)
            {
                Console.WriteLine("Прямокутника не існує:");
            }
            double b = yl - yr;
            if (b < 0) return b * (-1);
            else return b;

        }

        public static double Perimeter_rectangle(double xl, double yl, double xr, double yr)
        {

            double aa = a(xr, xl);
            double bb = b(yr, yl);
            return 2 * (aa + bb);
        }
        public static double Square_rectangle(double xl, double yl, double xr, double yr)
        {
            double aa = a(xr, xl);
            double bb = b(yr, yl);
            return aa * bb;
        }
    }
}
