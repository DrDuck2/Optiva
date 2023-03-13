using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Zad2
{
    public class GeometryException : Exception
    {
        private int a;
        private int b;
        private int c;
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
        public GeometryException(int a, int b, int c, string message) : base(message) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

    }
}
