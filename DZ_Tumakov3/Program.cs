using System;

namespace DZ_Tumakov3
{
    class Program
    {
        /*Упражнение 5.3 Тумаков - Написать программу, вычисляющую среднюю температуру за год.Использовать двумерный массив.*/
        public class Task_3
        {
            private static int[,] temp = new int[12, 30];
            private static Random random = new Random();
            public void Result()
            {
                for (int i = 0; i < temp.GetLength(0); i++)
                {
                    for (int j = 0; j < temp.GetLength(1); j++)
                    {
                        temp[i, j] = random.Next(-10, 10);
                        Console.Write(temp[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                double[] arr = AvgForMonth();
                Array.Sort(arr);
                Console.WriteLine("Массив средних температур по месяцам, отсортированный по возрастанию");
                Console.WriteLine(String.Join(" ", arr));
            }
            private static double[] AvgForMonth()
            {
                double[] arr = new double[temp.GetLength(0)];
                for (int i = 0; i < temp.GetLength(0); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < temp.GetLength(1); j++)
                    {
                        sum += temp[i, j];
                    }
                    arr[i] = Math.Round(sum / temp.GetLength(0), 1);
                }
                return arr;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Упражнение 5.3 Тумаков - Написать программу, вычисляющую среднюю температуру за год.Использовать двумерный массив:");
                Task_3 task_3 = new Task_3();
                task_3.Result();
                Console.ReadKey();
            }
        }
    }
}

