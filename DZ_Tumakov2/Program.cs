using System;

namespace DZ_Tumakov2
{
    /*Упражнение 5.2 Тумаков - Написать программу, реализующую умножению двух матриц, заданных ввиде двумерного массива.*/
    class Matrix
    {
        int[,] frst;
        int[,] scnd;

        public Matrix(int[,] First, int[,] Second)
        {
            frst = First;
            scnd = Second;
        }
        public void WriteMatrix()
        {
            Console.WriteLine("Первая Матрица:");
            for (int i = 0; i < frst.GetLength(0); i++)
            {
                for (int j = 0; j < frst.GetLength(1); j++)
                {
                    Console.Write(frst[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая Матрица:");
            for (int i = 0; i < scnd.GetLength(0); i++)
            {
                for (int j = 0; j < scnd.GetLength(1); j++)
                {
                    Console.Write(scnd[i, j]);
                }
                Console.WriteLine();
            }


        }

        public int[,] MatrixScndFrst()
        {
            int[,] NewMatrix = new int[frst.GetLength(0), scnd.GetLength(1)];
            for (int i = 0; i < frst.GetLength(0); i++)
            {
                for (int j = 0; j < scnd.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < frst.GetLength(1); k++)
                    {
                        sum += frst[i, k] * scnd[k, j];
                    }
                    NewMatrix[i, j] = sum;
                }
            }
            return NewMatrix;
        }
        static void OutPut_2()
        {
            int[,] frst = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] scnd = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Matrix matrix = new Matrix(frst, scnd);

            matrix.WriteMatrix();

            int[,] NewMatrix = matrix.MatrixScndFrst();
            Console.WriteLine("Новая матрица");
            for (int i = 0; i < NewMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < NewMatrix.GetLength(1); j++)
                {
                    Console.Write(NewMatrix[i, j]);
                }
                Console.WriteLine();
            } 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.2 Тумаков - Написать программу, реализующую умножению двух матриц, заданных ввиде двумерного массива.");
            OutPut_2();
            Console.ReadKey();
        }
    }
}
