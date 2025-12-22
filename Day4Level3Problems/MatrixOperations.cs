using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class MatrixOperations
    {
        public static int[,] GenerateMatrix(int m, int n)
        {
            int[,] matrix = new int[m, n];
            Random random = new Random();
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
            return matrix;
        }
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            if ((matrix1.GetLength(0) != matrix2.GetLength(0)) && (matrix1.GetLength(1) != matrix2.GetLength(1)))
            {
                throw new InvalidOperationException("trying to add matrices of different sizes");
            }
            int m = matrix1.GetLength(0);
            int n = matrix2.GetLength(0);
            int[,] resultMatrix = new int[m, n];
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return resultMatrix;
        }
        static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
        {
            if((matrix1.GetLength(0) != matrix2.GetLength(0)) && (matrix1.GetLength(1) != matrix2.GetLength(1)))
            {
                throw new InvalidOperationException("trying to subtract matrices of different sizes");
            }
            int m = matrix1.GetLength(0);
            int n = matrix2.GetLength(0);
            int[,] resultMatrix = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return resultMatrix;
        }
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int m1 = matrix1.GetLength(0);
            int n1 = matrix1.GetLength(1);
            int m2 = matrix2.GetLength(0);
            int n2 = matrix2.GetLength(1);

            if(n1 != m2)
            {
                throw new InvalidOperationException("Invalid input given for matric multiplication");
            }

            int[,] result = new int[m1, n2];
            for(int i = 0; i< m1; ++i)
            {
                for(int j =0; j < n2; ++j)
                {
                    for(int k = 0; k < n1; ++k)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }
        static int[,] Transpose(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int[,] result = new int[n, m];
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    result[j,i] = matrix[i, j];
                }
            }
            return result;
        }
        static void DisplayMatrix(int[,] arr)
        {
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0;j<n; ++j)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static int Determinant2D(int[,] arr)
        {
            if(arr.GetLength(0) != 2 || arr.GetLength(1) != 2)
            {
                throw new Exception("non 2x2 matrix in determinant 2d function");
            }
            return (arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0]);
        }
        static int Determinant3D(int[,] arr)
        {
            if(arr.GetLength(0)!= 3 || arr.GetLength(1) != 3)
            {
                throw new Exception("non 3x3 matrix in determinant 3d function");
            }
            return (arr[0, 0] * Determinant2D(GetMinor(arr, 0, 0)) - arr[0, 1] * Determinant2D(GetMinor(arr, 0, 1)) + arr[0, 2] * Determinant2D(GetMinor(arr, 0, 2)));
        }
        static int[,] GetMinor(int[,] arr, int rowToRemove, int colToRemove)
        {
            int[,] result = new int[2, 2];
            int m = 0;
            int n = 0;
            for(int i = 0; i <= 2; ++i)
            {
                if (i == rowToRemove) continue;
                n = 0;
                for(int j = 0; j <= 2; ++j)
                {
                    if (j == colToRemove) continue;
                    //Console.WriteLine($"at point [{m},{n}] = [{i},{j}]");
                    result[m,n] = arr[i,j];
                    n++;
                }
                m++;
            }
            return result;
        }
        static int[,] Adjoint2D(int[,] arr)
        {
            int temp = arr[0, 0];
            arr[0, 0] = arr[1, 1];
            arr[1, 1] = temp;
            arr[0, 1] *= -1;
            arr[1,0] *= -1;
            return arr;
        }
        static int[,] Inverse2D(int[,] arr)
        {
            arr = Adjoint2D(arr);
            int detArr = Determinant2D(arr);
            for(int i = 0; i < arr.GetLength(0); ++i)
            {
                for(int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] /= detArr;
                }
            }
            return arr;
        }
        static int[,] Inverse3D(int[,] arr)
        {
            int A = arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1];
            int B = (arr[1, 0] * arr[2,2] - arr[1,2] * arr[2,0])*(-1);
            int C = arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0];
            int D = (arr[0, 1] * arr[2,2] - arr[0,2] * arr[2,1]) * (-1);
            int E = arr[0, 0] * arr[2, 2] - arr[0, 2] * arr[2, 0];
            int F = (arr[0, 0] * arr[2,1] - arr[0,1]* arr[2,0]) * (-1);
            int G = arr[0, 1] * arr[1, 2] - arr[0, 2] * arr[1, 1];
            int H = (arr[0,0] * arr[1,2] - arr[0,2] * arr[1,0]) * (-1);
            int I = arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];

            int[,] result = new int[,] { { A, B, C }, { D,E,F},{ G,H,I} };

            result = Transpose(result);

            int detResult = Determinant3D(result);
            for(int i = 0; i < result.GetLength(0); ++i)
            {
                for(int j = 0; j < result.GetLength(1); ++j)
                {
                    arr[i,j] /= detResult;
                }
            }
            return result;
        }
        public static void Main()
        {
            Console.WriteLine("Enter number of rows in first matrix:");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns in first matrix:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of rows in second matrix:");
            int m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns second matrix:");
            int n2 = int.Parse(Console.ReadLine());

            int[,] arr1 = GenerateMatrix(m1, n1);
            int[,] arr2= GenerateMatrix(m2, n2);

            Console.WriteLine("The first generated matrix:");
            DisplayMatrix(arr1);
            Console.WriteLine("The second generated matrix:");
            DisplayMatrix(arr2);
            /*
            Console.WriteLine("Addition matrices:");
            DisplayMatrix(AddMatrices(arr1, arr2));
            Console.WriteLine("Subtraction matrices:");
            DisplayMatrix(SubtractMatrices(arr1, arr2));
            Console.WriteLine("Multiplication matrices:");
            DisplayMatrix(MultiplyMatrices(arr1, arr2));
            Console.WriteLine("Transpose of first matrix:");
            DisplayMatrix(Transpose(arr1));
            */
            //Console.WriteLine($"The Determinant of 3D matrix 1 is : {Determinant3D(arr1)}");
            //Console.WriteLine($"The Determinant of 3D matrix 2 is : {Determinant3D(arr2)}");
            if(Determinant3D(arr1) == 0) {
                Console.WriteLine("Determinant is 0, inverse doesn't exist");
            }
            else
            {
                DisplayMatrix(Inverse3D(arr1));
            }
        }
    }
}
