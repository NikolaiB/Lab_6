using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    public class Circle : Figure
    {
        public double radius;
        public Circle(double radius)

        { 
            this.radius = radius;
        }
        // maybe 
        // public double Radius { get; set; }

        public override double GetPerimetr()
        {
            return Math.PI * 2 * radius;
        }

        public override double GetSquere()
        {
            return (radius * radius) * Math.PI;
        }


    }
}
