using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    public class Triangle : Figure
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Perimetr()
        {
            return a + b + c;
        }

        public override double Squere()
        {
            double semiperimeter = (a + b + c) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));

            //switch (semiperimeter == 0 | semiperimeter < 0)
            //{
                // try to catch exeption
            //}

        }

    }
}
