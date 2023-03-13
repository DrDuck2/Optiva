using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    public class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;

        private MatrixGenerator()
        {
            generator = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[][] Generate(int rows, int columns)
        {
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new double[columns];
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            }

            return matrix;
        }
    }
}
