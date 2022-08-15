using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App5
{
    class Calculator
    {
        double a;
        double b;
        double c;

        public Calculator(double aa, double bb, double cc)
        {
            a = aa;
            b = bb;
            c = cc;

        }
        public double Add()
        {
            return a + b;
        }
        public double Sub()
        {
            return a - b;
        }
        public double Mult()
        {
            return a * b;
        }
        public double Div()
        {
            return a / b;
        }
        public double Pow()
        {
            return Math.Pow(a, b);
        }

        public double Ex1()
        {
            double res = 0;
            for (double i = a; i < b; i++)
            {

                if (i % 29 == 0 && i % 2 == 0 && i % 5 == 2)
                {
                    res += 1;

                }

            }
            return res;
        }

        public double Ex2()
        {
            if ((a >= 0) || (b >= 0) || (c >= 0))
            {
                return Math.Pow((a + b + c), 2);
            }
            else
            {
                return a*a + b*b + c*c;
            }
        }
    }
}