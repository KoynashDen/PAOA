using PAOA.Lab_2;
using PAOA.Lab_3.SquareRootMethod;

using MathNet.Numerics.LinearAlgebra;

namespace PAOA.Lab_3;

using System.Diagnostics;

public class Lab_3
{
    public static void lab_3()
    {
        Random rand = new Random();
        
        // розміри матриць для тесту
        int[] sizes = { 2, 4, 8, 10};
        
        foreach (int n in sizes)
        {
            int[,] matrix = new int[n, n];
        
            // генерація матриці
            for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = rand.Next(1, 10); 
        
           
        
            Console.WriteLine($"Розмір матриці: {n}x{n}");
        
            Stopwatch sw = Stopwatch.StartNew();
        
            double det = Determinant.determinant(matrix);
        
            sw.Stop();
            Console.WriteLine($"Детермінант = {det}");
            Console.WriteLine($"Час виконання: {sw.ElapsedMilliseconds} мс\n");
        }
        
        // double[,] A = {
        //     { 4, 12, -16 },
        //     { 12, 37, -43 },
        //     { -16, -43, 98 }
        // };
        //
        // double[] B = { 8, 16, -10 };
        //
        // double[,] S = SquareRootDecomposition.squareRootDecomposition(A);
        // double[] y = ForwardSubstitution.forwardSubstitution(S, B);
        // double[] x = BackwardSubstitution.backwardSubstitution(S, y);
        //
        // Console.WriteLine("Розв’язок СЛАР методом квадратного кореня:");
        // for (int i = 0; i < x.Length; i++)
        //     Console.WriteLine($"x{i + 1} = {x[i]:F4}");
        //
        //
        //
        // var a = Matrix<double>.Build.DenseOfArray(A);
        // var b = Vector<double>.Build.Dense(B);
        //
        // var x_check = a.Solve(b);
        //
        // Console.WriteLine("Розв’язок СЛАР через MathNet.Numerics:");
        // for (int i = 0; i < x_check.Count; i++)
        //     Console.WriteLine($"x{i + 1} = {x_check[i]:F4}");
        

    }
}