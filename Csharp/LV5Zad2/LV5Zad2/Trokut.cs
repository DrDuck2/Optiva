using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Zad2
{
    public class Trokut
    {
        private int a;
        private int b;
        private int c;

        public Trokut()
        {
            a = 1;
            b = 1;
            c = 1;
        }
        public Trokut(int a,int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new GeometryException(a,b,c,"Invalid dimensions!");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int GetA
        {
            get { return a; }
        }
        public int GetB
        {
            get { return b; }
        }
        public int GetC
        {
            get { return c; }
        }

        public override string ToString()
        {
            return $"A = {a}, B = {b}, C = {c}";
        }

        public double Opseg()
        {
            return a + b + c;
        }

        public double Povrsina()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c));
        }

        public bool IsPravokutan()
        {
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                return true;
            }
            else return false;
        }
    }
}
