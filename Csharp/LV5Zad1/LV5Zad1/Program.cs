using System;
using LinearAlgebra;
using LinearAlgebra.Math;

namespace Test
{
class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(50, 100, 10);
            Vector v2 = new Vector(10, 30, 5);

            v1.GetI = 13;
            v2.GetI = 17;

            Console.WriteLine(LinearAlgebraMath.KutVektora(v1, v2));
        }
    }
}
