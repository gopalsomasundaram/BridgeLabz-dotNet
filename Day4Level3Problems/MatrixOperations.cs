using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class MatrixOperations
    {
        public static double[,] GenerateMatrix(int m, int n)
        {
            double[,] matrix = new double[m, n];
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
        static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
        {
            if ((matrix1.GetLength(0) != matrix2.GetLength(0)) && (matrix1.GetLength(1) != matrix2.GetLength(1)))
            {
                throw new InvalidOperationException("trying to add matrices of different sizes");
            }
            int m = matrix1.GetLength(0);
            int n = matrix2.GetLength(0);
            double[,] resultMatrix = new double[m, n];
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return resultMatrix;
        }
        static double[,] SubtractMatrices(double[,] matrix1, double[,] matrix2)
        {
            if((matrix1.GetLength(0) != matrix2.GetLength(0)) && (matrix1.GetLength(1) != matrix2.GetLength(1)))
            {
                throw new InvalidOperationException("trying to subtract matrices of different sizes");
            }
            int m = matrix1.GetLength(0);
            int n = matrix2.GetLength(0);
            double[,] resultMatrix = new double[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return resultMatrix;
        }
        static double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            int m1 = matrix1.GetLength(0);
            int n1 = matrix1.GetLength(1);
            int m2 = matrix2.GetLength(0);
            int n2 = matrix2.GetLength(1);

            if(n1 != m2)
            {
                throw new InvalidOperationException("Invalid input given for matric multiplication");
            }

            double[,] result = new double[m1, n2];
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
        static double[,] Transpose(double[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            double[,] result = new double[n, m];
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    result[j,i] = matrix[i, j];
                }
            }
            return result;
        }
        static void DisplayMatrix(double[,] arr)
        {
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0;j<n; ++j)
                {
                    Console.Write($"{arr[i, j]:F4} ");
                }
                Console.WriteLine();
            }
        }
        static double Determinant2D(double[,] arr)
        {
            if(arr.GetLength(0) != 2 || arr.GetLength(1) != 2)
            {
                throw new Exception("non 2x2 matrix in determinant 2d function");
            }
            return (arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0]);
        }
        static double Determinant3D(double[,] arr)
        {
            if(arr.GetLength(0)!= 3 || arr.GetLength(1) != 3)
            {
                throw new Exception("non 3x3 matrix in determinant 3d function");
            }
            return (arr[0, 0] * Determinant2D(GetMinor(arr, 0, 0)) - arr[0, 1] * Determinant2D(GetMinor(arr, 0, 1)) + arr[0, 2] * Determinant2D(GetMinor(arr, 0, 2)));
        }
        static double[,] GetMinor(double[,] arr, int rowToRemove, int colToRemove)
        {
            double[,] result = new double[2, 2];
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
        static double[,] Adjoint2D(double[,] arr)
        {
            double temp = arr[0, 0];
            arr[0, 0] = arr[1, 1];
            arr[1, 1] = temp;
            arr[0, 1] *= -1;
            arr[1,0] *= -1;
            return arr;
        }
        static double[,] Inverse2D(double[,] arr)
        {
            arr = Adjoint2D(arr);
            double detArr = Determinant2D(arr);
            for(int i = 0; i < arr.GetLength(0); ++i)
            {
                for(int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] /= detArr;
                }
            }
            return arr;
        }
        static double[,] Inverse3D(double[,] arr)
        {
            double det = Determinant3D(arr);
            if (det == 0)
                throw new Exception("Matrix is singular. Inverse does not exist.");
            double A = arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1];
            double B = (arr[1, 0] * arr[2,2] - arr[1,2] * arr[2,0])*(-1);
            double C = arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0];
            double D = (arr[0, 1] * arr[2,2] - arr[0,2] * arr[2,1]) * (-1);
            double E = arr[0, 0] * arr[2, 2] - arr[0, 2] * arr[2, 0];
            double F = (arr[0, 0] * arr[2,1] - arr[0,1]* arr[2,0]) * (-1);
            double G = arr[0, 1] * arr[1, 2] - arr[0, 2] * arr[1, 1];
            double H = (arr[0,0] * arr[1,2] - arr[0,2] * arr[1,0]) * (-1);
            double I = arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];

            double[,] adjugate = 
            {
                { A, D, G },
                { B, E, H },
                { C, F, I }
            };

            for(int i = 0; i < 3; ++i)
            {
                for(int j = 0; j < 3; ++j)
                {
                    adjugate[i,j] /= det;
                }
            }
            return adjugate;
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

            double[,] arr1 = GenerateMatrix(m1, n1);
            double[,] arr2= GenerateMatrix(m2, n2);

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
