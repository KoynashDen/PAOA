namespace PAOA.Lab_3;

public class Determinant
{
    public static double determinant(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // матриці 1*1 і 2*2
        if (n == 1) return matrix[0, 0];
        if (n == 2) 
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        double det = 0;
        for (int p = 0; p < n; p++)
        {
            int[,] subMatrix = new int[n - 1, n - 1];

            for (int i = 1; i < n; i++)
            {
                int colIndex = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == p) continue;
                    subMatrix[i - 1, colIndex] = matrix[i, j];
                    colIndex++;
                }
            }

            // знак (-1)^p
            int sign = (p % 2 == 0) ? 1 : -1;

            det += sign * matrix[0, p] * determinant(subMatrix);
        }

        return det;
    }

}