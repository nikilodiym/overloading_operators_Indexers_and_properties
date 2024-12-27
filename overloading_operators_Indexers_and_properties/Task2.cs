using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace overloading_operators_Indexers_and_properties
{
    public class Matrix
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException("Matrices");
            }

            return new Matrix(matrix1.Rows, matrix1.Columns);
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException("Matrices");
            }

            return new Matrix(matrix1.Rows, matrix1.Columns);
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
            {
                throw new ArgumentException("Matrices");
            }

            return new Matrix(matrix1.Rows, matrix2.Columns);
        }

        public static Matrix operator *(Matrix matrix, int number)
        {
            return new Matrix(matrix.Rows, matrix.Columns);
        }
    }
}
