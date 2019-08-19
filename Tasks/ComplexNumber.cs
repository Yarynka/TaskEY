using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class ComplexNumber
    {
       public double real_number;
        public double imaginary_number;
        public ComplexNumber(double real_number, double imaginary_number)
        {
            this.real_number = real_number;
            this.imaginary_number = imaginary_number;
        }

        #region multiplication
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real_number * c2.real_number - c1.imaginary_number * c2.imaginary_number, c1.real_number * c2.imaginary_number + c1.imaginary_number * c2.real_number);
        }
        #endregion
        #region division
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber((c1.real_number * c2.real_number + c1.imaginary_number * c2.imaginary_number) / (c2.real_number * c2.real_number + c2.imaginary_number * c2.imaginary_number), -((c1.real_number * c2.imaginary_number - c1.imaginary_number * c2.real_number) / (c2.real_number * c2.real_number + c2.imaginary_number * c2.imaginary_number)));
        }
        #endregion
    }
}
