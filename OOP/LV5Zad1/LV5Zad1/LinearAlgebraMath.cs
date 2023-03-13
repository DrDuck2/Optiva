using System;

namespace LinearAlgebra.Math
{
    public static class LinearAlgebraMath
    {
        public static double SkalarniProdukt(Vector v1, Vector v2)
        {
            return (v1.GetI * v2.GetI) + (v1.GetJ * v2.GetJ) + (v1.GetK * v2.GetK);
        }
        public static double KutVektora(Vector v1, Vector v2)
        {
            double kut;
            kut = LinearAlgebraMath.SkalarniProdukt(v1, v2) / ((System.Math.Sqrt(System.Math.Pow(v1.GetI, 2) + System.Math.Pow(v2.GetI, 2)))+ (System.Math.Sqrt(System.Math.Pow(v1.GetJ, 2) + System.Math.Pow(v2.GetJ, 2)))+ (System.Math.Sqrt(System.Math.Pow(v1.GetK, 2) + System.Math.Pow(v2.GetK, 2))));
            return kut;
        }
    }
}
