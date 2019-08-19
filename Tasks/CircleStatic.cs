using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class CircleStatic
    {
        const double Pi = 3.14;
        public static double C(double r)
        {
            return 2 * Pi * r;
        }
        public static double S(double r)
        {
            return Pi * r * r;
        }
    }
}
