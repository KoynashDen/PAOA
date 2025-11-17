namespace PAOA.Lab_2
{
    public class Add
    {
        public static double[,] add(double[,] A, double[,] B)
        {
            int n = A.GetLength(0);
            double[,] R = new double[n, n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    R[i, j] = A[i, j] + B[i, j];
                }
            }
            
            return R;
        }
    }
}