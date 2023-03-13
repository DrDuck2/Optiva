using System;


namespace LinearAlgebra
{
    public class Vector
    {
        private int i;
        private int j;
        private int k;


        private Vector()
        {
            i = 0;
            j = 0;
            k = 0;
        }
        public Vector(int i,int j,int k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }

        public int GetI
        {
            get { return i; }
            set { i = value; }
        }
        public int GetJ
        {
            get { return j; }
            set { j = value; }
        }
        public int GetK
        {
            get { return k; }
            set { k = value; }
        }

        public double EuklidskaUdaljenost(Vector v1, Vector v2)
        {
            return System.Math.Sqrt(System.Math.Pow((v1.GetI + v2.GetI), 2) + System.Math.Pow((v1.GetJ + v2.GetJ), 2) + System.Math.Pow((v1.GetK + v2.GetK), 2));
        }
    }
}
