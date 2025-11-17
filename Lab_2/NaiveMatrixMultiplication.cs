namespace PAOA.Lab_2
{
    public class NaiveMatrixMultiplication
    {
        public static double[,] Multiply(double[,] A, double[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            int p = B.GetLength(1);

            double[,] C = new double[n, p];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    C[i, j] = 0.0;
                    for (int k = 0; k < m; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return C;
        }
    }
}