using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    public class Rectangle : Figure
    {
        public double a;
        public double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double GetPerimetr()
        {
            return 2 * (a + b);
        }

        public  override double GetSquere()
        {
            return a * b;
        }

       
    }
}