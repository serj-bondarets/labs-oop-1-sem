using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibForLab2;

namespace Matrix.Tests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void FirstTestReloadedMultiplyOperatorOnTwoMatrices()
        {
            bool expected = true;
            double[,] firstArray = { { 3, 2 ,1},
                                     { 4, 1, 0},
                                     { 1, 2, 6}};
            double[,] secondArray = {{ 2, 3 ,5},
                                     { 2, 2, 0},
                                     { 1, 1, 3}};
            double[,] expectedArray = {  { 11, 14 ,18},
                                     { 10, 14, 20},
                                     { 12, 13, 23}};
            Matrix firstMatrix = new Matrix(3, 3, firstArray);
            Matrix secondMatrix = new Matrix(3, 3, secondArray);
            Matrix expectedMatrix = new Matrix(3, 3, expectedArray);
            Matrix actualMatrix = firstMatrix * secondMatrix;
            bool actual = true;
            for (int i = 0; i < expectedMatrix.NumberOfStrings; i++)
            {
                for (int j = 0; j < expectedMatrix.NumberOfColumns; j++)
                {
                    if (expectedMatrix.Mat[i, j] != actualMatrix.Mat[i, j])
                    {
                        actual = false;
                    }
                }
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondTestReloadedMultiplyOperatorOnTwoMatrices()
        {
            bool expected = true;
            double[,] firstArray = { { 3, 2 ,1},
                                     { 4, 1, 0},
                                     { 1, 2, 6}};
            double[,] secondArray = {{ 2, 3 ,5},
                                     { 2, 2, 0},
                                     { 1, 1, 3}};
            double[,] expectedArray = {  { 23,17 ,32},
                                     { 14, 6, 2},
                                     { 10, 9, 19}};
            Matrix firstMatrix = new Matrix(3, 3, firstArray);
            Matrix secondMatrix = new Matrix(3, 3, secondArray);
            Matrix expectedMatrix = new Matrix(3, 3, expectedArray);
            Matrix actualMatrix = secondMatrix * firstMatrix;
            bool actual = true;
            for (int i = 0; i < expectedMatrix.NumberOfStrings; i++)
            {
                for (int j = 0; j < expectedMatrix.NumberOfColumns; j++)
                {
                    if (expectedMatrix.Mat[i, j] != actualMatrix.Mat[i, j])
                    {
                        actual = false;
                    }
                }
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstTestReloadedMultiplyOperatorOnMatrixAndNumber()
        {
            bool expected = true;
            double[,] array = {      { 4, 2, 2, 0, 6},
                                     { 1, 2, 1, 1, 0},
                                     { 9, 2, 3, 1, 9},
                                     { 3, 2, 3, 1, 5},
                                     { 4, 6, 5, 3, 6} };
            double number = 3;
            double[,] expectedArray = {      { 12, 6, 6, 0, 18},
                                             { 3, 6, 3, 3, 0},
                                             { 27, 6, 9, 3, 27},
                                             { 9, 6, 9, 3, 15},
                                             { 12, 18, 15, 9, 18} };

            Matrix matrix = new Matrix(5, 5, array);
            Matrix expectedMatrix = new Matrix(5, 5, expectedArray);
            Matrix actualMatrix = matrix * number;
            bool actual = true;
            for (int i = 0; i < expectedMatrix.NumberOfStrings; i++)
            {
                for (int j = 0; j < expectedMatrix.NumberOfColumns; j++)
                {
                    if (expectedMatrix.Mat[i, j] != actualMatrix.Mat[i, j])
                    {
                        actual = false;
                    }
                }
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondTestReloadedMultiplyOperatorOnMatrixAndNumber()
        {
            bool expected = true;
            double[,] array = {      { 4, 2, 2, 0, 6},
                                     { 1, 2, 1, 1, 0},
                                     { 9, 2, 3, 1, 9},
                                     { 3, 2, 3, 1, 5},
                                     { 4, 6, 5, 3, 6} };
            int number = 3;
            double[,] expectedArray = {      { 12, 6, 6, 0, 18},
                                             { 3, 6, 3, 3, 0},
                                             { 27, 6, 9, 3, 27},
                                             { 9, 6, 9, 3, 15},
                                             { 12, 18, 15, 9, 18} };

            Matrix matrix = new Matrix(5, 5, array);
            Matrix expectedMatrix = new Matrix(5, 5, expectedArray);
            Matrix actualMatrix = matrix * number;
            bool actual = true;
            for (int i = 0; i < expectedMatrix.NumberOfStrings; i++)
            {
                for (int j = 0; j < expectedMatrix.NumberOfColumns; j++)
                {
                    if (expectedMatrix.Mat[i, j] != actualMatrix.Mat[i, j])
                    {
                        actual = false;
                    }
                }
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
