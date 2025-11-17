namespace PAOA.Lab_2
{
    public class GenerateRandomMatrix
    {
        public static double[,] generateRandomMatrix(int size)
        {
            Random rnd = new Random();
            double[,] matrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    double integerPart = rnd.Next(0, 10);         
                    double fractionalPart = Math.Round(rnd.NextDouble(), 10);
                    matrix[i, j] = integerPart + fractionalPart;   
                }
            }

            return matrix;
        }
    }
}