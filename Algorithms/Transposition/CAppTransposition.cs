﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transposition
{
    class CAppTransposition
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        private static void PrintMatrix(ref int[,] mat, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat[i, j] + ", ");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// A transpose function
        /// </summary>
        /// <param name="mat">A matrix to transpose</param>
        /// <param name="rows">number of rows in a matrix</param>
        /// <param name="cols">number of colums in a matrix</param>
        /// <returns></returns>
        private static int[,] Transpose(ref int[,] mat, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < cols; j++)
                {
                    if (i != j)
                    {
                        int tmp = mat[i, j];
                        mat[i, j] = mat[j, i];
                        mat[j, i] = tmp;
                    }
                }
            }

            return mat;
        }

        static void Main(string[] args)
        {
            //matrix declaration
            const int C_ROWS = 5;
            const int C_COLS = 5;
            int[,] mat = new int[C_ROWS, C_COLS];
            int counter = 10;
            for (int i = 0; i < C_ROWS; i++)
                for (int j = 0; j < C_COLS; j++)
                {
                    mat[i, j] = counter;
                    counter++;
                }

            //print matrix before transposeing
            PrintMatrix(ref mat, C_ROWS, C_COLS);

            Console.WriteLine("Transpose");
            //transpose function call
            mat = Transpose(ref mat, C_ROWS, C_COLS);

            //print the matrix after transpose
            PrintMatrix(ref mat, C_ROWS, C_COLS);
            Console.ReadKey();
        }
    }
}
