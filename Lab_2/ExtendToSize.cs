namespace PAOA.Lab_2
{
    public class ExtendToSize
    {
        public static double[,] extendToSize(double[,] M, int size)
        {
            int rows = M.GetLength(0);
            int cols = M.GetLength(1);
            double[,] R = new double[size, size];
            
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