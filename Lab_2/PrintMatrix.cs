using System;

namespace PAOA.Lab_2
{
    public class PrintMatrix
    {
        public static void printMatrix(int[,] M)
        {
            int n = M.GetLength(0);
            int m = M.GetLength(1);

            Console.WriteLine("\nМатриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // вирівнюємо по ширині 6 символів, без надлишкових десяткових
                    Console.Write($"{M[i, j],6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}