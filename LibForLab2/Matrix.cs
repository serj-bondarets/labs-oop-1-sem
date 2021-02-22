using System;
using System.Text;

namespace LibForLab2
{
    /// <summary>
    /// класс, в котором хранится матрица
    /// </summary>
    public class Matrix
    {
        private int numberOfStrings;
        private int numberOfColumns;

        /// <summary>
        /// двумерный массив для хранения матрицы
        /// </summary>
        private double[,] mat;

        /// <summary>
        /// свойство для кол-ва строк
        /// </summary>
        public int NumberOfStrings
        {
            get { return numberOfStrings; }
        }

        /// <summary>
        /// свойство для кол-ва столбцов
        /// </summary>
        public int NumberOfColumns
        {
            get { return numberOfColumns; }
        }

        /// <summary>
        /// свойство для матрицы
        /// </summary>
        public double[,] Mat
        {
            get { return mat; }
        }

        /// <summary>
        /// конструктор матрицы
        /// </summary>
        public Matrix(int numberOfStrings, int numberOfColumns, double[,] matrix)
        {
            this.numberOfStrings = numberOfStrings;
            this.numberOfColumns = numberOfColumns;
            mat = matrix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="numberOfStrings">The number of strings.</param>
        /// <param name="numberOfColumns">The number of columns.</param>
        public Matrix(int numberOfStrings, int numberOfColumns)
        {
            this.numberOfStrings = numberOfStrings;
            this.numberOfColumns = numberOfColumns;
            mat = new double[numberOfStrings, numberOfColumns];
        }

        /// <param name="firstMatrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns>firstMatrix * secondMatrix</returns>
        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix == null) throw new MatrixExeption("1 аргумент умножения не веден ");
            if (secondMatrix == null) throw new MatrixExeption("2 аргумент умножения не веден ");
            if (secondMatrix == null) throw new MatrixExeption("2 аргумент умножения не веден ");
            
            int n1 = firstMatrix.NumberOfStrings;
            int m1 = firstMatrix.NumberOfColumns;
            int n2 = secondMatrix.NumberOfStrings;
            int m2 = secondMatrix.NumberOfColumns;
            double[,] mat1 = firstMatrix.Mat;
            double[,] mat2 = secondMatrix.Mat;
            double[,] mat3 = new double[n1, m2];

            if (m1 != n2) throw new MatrixExeption("Эти матрицы нельзя перемножать");

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    mat3[i, j] = 0;
                    double sum = 0;
                    for (int t = 0; t < m1; t++)
                    {
                        sum += mat1[i, t] * mat2[t, j];
                    }
                    mat3[i, j] = sum;
                }
            }
            return new Matrix(n1, m2, mat3);
        }

        /// <summary>
        /// перезагрузка оператора'*' для матрицы и int
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="number"></param>
        /// <returns>firstMatrix * secondMatrix</returns>
        public static Matrix operator *(Matrix matrix, int number)
        {
            if (matrix == null) throw new MatrixExeption("Матрица не ведена ");
            int n = matrix.numberOfStrings;
            int m = matrix.NumberOfColumns;
            double[,] sourceMat = matrix.Mat;
            double[,] mat = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = sourceMat[i, j] * Convert.ToDouble(number);
                }
            }
            return new Matrix(n, m, mat);
        }

        /// <summary>
        /// перезагрузка оператора '*' для матрицы и двойного числа
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="number"></param>
        /// <returns>firstMatrix * secondMatrix</returns>
        public static Matrix operator *(Matrix matrix, double number)
        {
            if (matrix == null) throw new MatrixExeption("Матрица не ведена ");
            int n = matrix.NumberOfStrings;
            int m = matrix.NumberOfColumns;
            double[,] sourceMat = matrix.Mat;
            double[,] mat = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = sourceMat[i, j] * number;
                }
            }
            return new Matrix(n, m, mat);
        }

        public override string ToString()
        {
            StringBuilder mat = new StringBuilder();
            for (int i = 0; i < NumberOfStrings; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    mat.Append(Mat[i, j] + "  ");
                }
                mat.Append(" \n");
                mat.Append(" \n");
            }
            return mat.ToString();
        }
    }
}