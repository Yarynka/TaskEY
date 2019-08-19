using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1111111111111111111111111111111

            Console.WriteLine("ЗАВДАННЯ 1.1:");
            Console.WriteLine("Координати лiвого верхнього кута:");
            Console.WriteLine("XL = ");
            double xl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("YL =");
            double yl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координати правого верхнього кута:");
            Console.WriteLine("XR =");
            double xr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("YR =");
            double yr = Convert.ToDouble(Console.ReadLine());
            
            //Завдання 1
            Rectangle Rectangle1 = new Rectangle(xl, yl, xr, yr);
            Console.WriteLine("Периметр прямокутника: " + Rectangle1.Perimeter_rectangle());
            Console.WriteLine("Площа прямокутника: " + Rectangle1.Square_rectangle());

            //Завдання 2

            Console.WriteLine(" ");
            Console.WriteLine("ЗАВДАННЯ 1.2:");
            RectangleAuto Rectangle2 = new RectangleAuto();
            Rectangle2.xl = xl;
            Rectangle2.yl = yl;
            Rectangle2.xr = xr;
            Rectangle2.yr = yr;
            Rectangle2.Reactangle_A();
            Console.WriteLine("Периметр прямокутника: " + Rectangle2.P_rect);
            Console.WriteLine("Площа прямокутника: " + Rectangle2.S_rect);

            //Завдання 3

            Console.WriteLine("");
            Console.WriteLine("ЗАВДАННЯ 1.3");
            Console.WriteLine("R = ");
            double R = Convert.ToDouble(Console.ReadLine());

            Circle Circle1 = new Circle();
            Console.WriteLine("Довжнина кола: " + Circle1.C(R));
            Console.WriteLine("Площа кола: " + Circle1.S(R));
            //Завдання 4

            Console.WriteLine("");
            Console.WriteLine("ЗAВДАННЯ 1.4");

            Console.WriteLine("Периметр прямокутника: " + RectangleStatic.Perimeter_rectangle(xl,yl,xr,yr));
            Console.WriteLine("Площа прямокутника: " + RectangleStatic.Square_rectangle(xl, yl, xr, yr));

            Console.WriteLine("Довжнина кола: " + CircleStatic.C(R));
            Console.WriteLine("Площа кола: " + CircleStatic.S(R));
            
            //Завдання 5
            Console.WriteLine("");
            Console.WriteLine("ЗAВДАННЯ 1.5");
            
            Console.WriteLine("а(дiйсне) = ");
            double a_r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b(уявне) = ");
            double b_im = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c(дiйсне) = ");
            ComplexNumber a = new ComplexNumber(a_r, b_im);
            double c_r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("d(уявне) = ");
            double d_im = Convert.ToDouble(Console.ReadLine());
            ComplexNumber b = new ComplexNumber(c_r, d_im);

            ComplexNumber mul = a * b;
            ComplexNumber div = a / b;
            Console.WriteLine("(" + a.real_number + " + " + a.imaginary_number + "i) * (" + b.real_number + " + " + b.imaginary_number + "i) = (" + mul.real_number + " + " + mul.imaginary_number + "i)");
            Console.WriteLine("(" + a.real_number + " + " + a.imaginary_number + "i) / (" + b.real_number + " + " + b.imaginary_number + "i) = (" + Math.Round(div.real_number, 2) + " + " + Math.Round(div.imaginary_number, 2) + "i)");
            Console.ReadLine();


            //завдання 2.1 реалізоване в Figure.cs або 2ed2084c0548f8a027487d6a3f55448c089b0057



        }
    }
}
