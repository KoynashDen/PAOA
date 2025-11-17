// using System;
// using System.Diagnostics;
//
// namespace PAOA.Lab_2
// {
//     public class Lab_2
//     {
//         public static void lab_2()
//         {
//             int sizeMatrix = 64; 
//             
//             // Генерація випадкових 
//             var A = GenerateRandomMatrix.generateRandomMatrix(sizeMatrix);
//             var B = GenerateRandomMatrix.generateRandomMatrix(sizeMatrix);
//
//             var stopwatch = Stopwatch.StartNew();
//             
//             Console.WriteLine("Матриця A:");
//             PrintMatrix.printMatrix(A);
//             Console.WriteLine("\nМатриця B:");
//             PrintMatrix.printMatrix(B);
//
//          
//             double[,] C = NaiveMatrixMultiplication.Multiply(A, B);
//             stopwatch.Stop();
//
//             Console.WriteLine("Наївний алгоритм:");
//             Console.WriteLine($"Час виконання: {stopwatch.ElapsedMilliseconds} ms");
//
//             // Кількість операцій
//             int n = A.GetLength(0);
//             int m = A.GetLength(1);
//             int p = B.GetLength(1);
//
//             long naiveMultiplications = n * m * p;
//             long naiveAdditions = n * p * (m - 1);
//
//             Console.WriteLine($"Кількість множень: {naiveMultiplications}");
//             Console.WriteLine($"Кількість додавань: {naiveAdditions}");
//
//             // штрассен
//             stopwatch.Restart();
//             double[,] D = Strassen.strassen(A, B);
//             stopwatch.Stop();
//
//             Console.WriteLine("\nАлгоритм Штрассена:");
//             Console.WriteLine($"Час виконання: {stopwatch.ElapsedMilliseconds} ms");
//
//             
//             var diff = CompareMatrices.difference(C, D);
//             double maxDiff = CompareMatrices.maxDifference(C, D);
//
//             Console.WriteLine("\nПорівняння результатів:");
//             Console.WriteLine($"Максимальна різниця між елементами: {maxDiff:E10}");
//
//             if (sizeMatrix <= 10)
//             {
//                 Console.WriteLine("\nМатриця різниць (C - D):");
//                 PrintMatrix.printMatrix(diff);
//             }
//
//             
//             int maxDim = Math.Max(Math.Max(n, m), p);
//             int size = 1;
//             while (size < maxDim) size <<= 1;
//             Console.WriteLine($"\nТеоретична складність Штрассена ~ O({size}^{Math.Log(7, 2):F3}) ≈ O({Math.Pow(size, Math.Log(7, 2)):F0})");
//         }
//     }
// }
