namespace PAOA.Lab_2
{
    public class TrimMatrix
    {
        public static double[,] trimMatrix(double[,] M, int rows, int cols)
        {
            double[,] R = new double[rows, cols];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    R[i, j] = M[i, j];
                }
            }

            return R;
        }
    }
}