using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest
{
    [TestClass]
    internal class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Matrix matrix1 = new Matrix(2, 3);
            Matrix matrix2 = new Matrix(2, 3);
            Matrix matrix3 = matrix1 + matrix2;
            Matrix matrix4 = matrix1 - matrix2;
            Matrix matrix5 = matrix1 * matrix2;
            Matrix matrix6 = matrix1 * 5;
        }
    }

    public class Matrix
    {
        private int rows;
        private int columns;
        private int[,] data;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.data = new int[rows, columns];
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            Matrix result = new Matrix(matrix1.rows, matrix1.columns);

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.data[i, j] = matrix1.data[i, j] + matrix2.data[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            Matrix result = new Matrix(matrix1.rows, matrix1.columns);

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.data[i, j] = matrix1.data[i, j] - matrix2.data[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.columns != matrix2.rows)
            {
                throw new ArgumentException("The number of columns in the first matrix must be equal to the number of rows in the second matrix.");
            }

            Matrix result = new Matrix(matrix1.rows, matrix2.columns);

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix2.columns; j++)
                {
                    for (int k = 0; k < matrix1.columns; k++)
                    {
                        result.data[i, j] += matrix1.data[i, k] * matrix2.data[k, j];
                    }
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix, int scalar)
        {
            Matrix result = new Matrix(matrix.rows, matrix.columns);

            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    result.data[i, j] = matrix.data[i, j] * scalar;
                }
            }

            return result;
        }
    }
}
