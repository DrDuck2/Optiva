using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad1
{
    class Circle : IShape
    {
        public double radius;

        public double GetRadius
        {
            get {return radius; }
        }
        
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Povrsina()
        {
            return Math.Pow(radius, 2) * 3.14;
        }
        public double Opseg()
        {
            return 2 * radius * 3.14;
        }

        public override string ToString()
        {
            return $"Radius: {radius}";
        }
    }
}
