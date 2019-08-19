using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class RectangleAuto
    {
        public double xl { get; set; }
        public double xr { get; set; }
        public double yl { get; set; }
        public double yr { get; set; }
        public double P_rect { get; set; }
        public double S_rect { get; set; }

        public RectangleAuto()
        {

        }
        public RectangleAuto(double xl, double yl, double xr, double yr)
        {
            this.xl = xl;
            this.xr = xr;
            this.yl = yl;
            this.yr = yr;
        }

        public double a(double xl, double xr)
        {
            if (xl == xr)
            {
                Console.WriteLine("Прямокутника не існує:");
            }
            double a = xl - xr;
            if (a < 0) return a * (-1);
            else return a;

        }

        public double b(double yl, double yr)
        {
            if (yl == yr)
            {
                Console.WriteLine("Прямокутника не існує:");
            }
            double b = yl - yr;
            if (b < 0) return b * (-1);
            else return b;

        }

        public double Perimeter_rectangle()
        {

            double aa = a(xr, xl);
            double bb = b(yr, yl);
            return 2 * (aa + bb);
        }
        public double Square_rectangle()
        {
            double aa = a(xr, xl);
            double bb = b(yr, yl);
            return aa * bb;
        }
        public void Reactangle_A()
        {
            P_rect = this.Perimeter_rectangle();
            S_rect= this.Square_rectangle();
        }
    }
}
