namespace PAOA.Lab_3.SquareRootMethod;

public class SquareRootDecomposition
{
    public static double[,] squareRootDecomposition(double[,] A)
    {
        int n = A.GetLength(0);
        double[,] S = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            // Обчислюємо s_ii
            double sum = 0;
            for (int k = 0; k < i; k++)
                sum += S[k, i] * S[k, i];
            S[i, i] = Math.Sqrt(A[i, i] - sum);

            // Обчислюємо s_ij (j > i)
            for (int j = i + 1; j < n; j++)
            {
                sum = 0;
                for (int k = 0; k < i; k++)
                    sum += S[k, i] * S[k, j];
                S[i, j] = (A[i, j] - sum) / S[i, i];
            }
        }

        return S;
    }
}