namespace PAOA.Lab_2
{
    public class CompareMatrices
    {
        public static double[,] difference(double[,] A, double[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);

            double[,] R = new double[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    R[i, j] = A[i, j] - B[i, j];
                }
            }

            return R;
        }

        public static double maxDifference(double[,] A, double[,] B)
        {
            double maxDiff = 0.0;
            int n = A.GetLength(0);
            int m = A.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double diff = Math.Abs(A[i, j] - B[i, j]);
                    if (diff > maxDiff)
                        maxDiff = diff;
                }
            }

            return maxDiff;
        }
    }
}