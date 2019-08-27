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
            /*  //TASK1111111111111111111111111111111

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
              //завдання 2.2 реалізоване в Figure.cs або 42bc32f2f8257565e1fa378902b08bc6cb7b7b2e
              Console.WriteLine("ЗAВДАННЯ 2.1,2.2");

              Tasks.Rectangles RR = new Tasks.Rectangles(1, 2);
              RR.Draw();
              Tasks.Square SS = new Tasks.Square(1, 2);
              SS.Draw();

              // завдання 2.3. реалізоване в CFigure.cs або  a549b7569dd0586926e59cd1759ab1faacdbb75f          
              Console.WriteLine("ЗAВДАННЯ 2.3");
              Tasks.CFigure F = new Tasks.CFigure(1, 2);
               F.Draw();
               Tasks.CRectangles R3 = new Tasks.CRectangles(1, 2);
               R3.Draw();
               Tasks.CSquare S3 = new Tasks.CSquare(1, 2);
               S3.Draw();
              //завдання 2.4. реалізоване в NFigure.cs
              Tasks.IDrawable[] ID = new Tasks.IDrawable[3];
              ID[0] = new Tasks.NFigure(1, 2);
              ID[1] = new Tasks.NRectangles(1, 2);
              ID[2] = new Tasks.NSquare(1, 2);
              DrawAll(ID);
              */
            //завданння 3.1.Вивести список персон(імя,вік)
            Console.WriteLine("ЗAВДАННЯ 3.1: ");
            Task3_Person myPerson3_1 = new Task3_Person();
            Console.WriteLine(myPerson3_1.PersonNameAndAge());
           
            //завданння 3.2.Вивести список персон(імя,вік)
            Console.WriteLine("ЗAВДАННЯ 3.2: ");
            myPerson3_1.AddTwoList();
            Console.WriteLine(myPerson3_1.PersonPhoneNumber());


            //завданння 3.3.Вивести список персон(імя,вік)



            Console.ReadLine();}
        public static void DrawAll(Tasks.IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i].Draw();
        }
    }
}
