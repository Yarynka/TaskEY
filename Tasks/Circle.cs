using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Circle
    {
        const double Pi = 3.14;
        public double C(double r)
        {
            return 2 * Pi * r;
        }
        public double S(double r)
        {
            return Pi * r * r;
        }
    }
}
