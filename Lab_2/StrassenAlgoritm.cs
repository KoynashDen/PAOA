namespace PAOA.Lab_2
{
    public class StrassenAlgoritm
    {
        public static double[,] strassenAlgoritm(double[,] A, double[,] B)
        {
            int n = A.GetLength(0);

            // Базовий випадок
            if (n == 1)
            {
                return new double[,] { { A[0, 0] * B[0, 0] } };
            }

            int newSize = n / 2;

            // Підматриці
            double[,] A11 = new double[newSize, newSize];
            double[,] A12 = new double[newSize, newSize];
            double[,] A21 = new double[newSize, newSize];
            double[,] A22 = new double[newSize, newSize];

            double[,] B11 = new double[newSize, newSize];
            double[,] B12 = new double[newSize, newSize];
            double[,] B21 = new double[newSize, newSize];
            double[,] B22 = new double[newSize, newSize];

            // Наповнення підматриць
            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < newSize; j++)
                {
                    A11[i, j] = A[i, j];
                    A12[i, j] = A[i, j + newSize];
                    A21[i, j] = A[i + newSize, j];
                    A22[i, j] = A[i + newSize, j + newSize];

                    B11[i, j] = B[i, j];
                    B12[i, j] = B[i, j + newSize];
                    B21[i, j] = B[i + newSize, j];
                    B22[i, j] = B[i + newSize, j + newSize];
                }
            }

            // 7 проміжних множень Штрассена
            var M1 = strassenAlgoritm(Add.add(A11, A22), Add.add(B11, B22));
            var M2 = strassenAlgoritm(Add.add(A21, A22), B11);
            var M3 = strassenAlgoritm(A11, Subtraction.subtraction(B12, B22));
            var M4 = strassenAlgoritm(A22, Subtraction.subtraction(B21, B11));
            var M5 = strassenAlgoritm(Add.add(A11, A12), B22);
            var M6 = strassenAlgoritm(Subtraction.subtraction(A21, A11), Add.add(B11, B12));
            var M7 = strassenAlgoritm(Subtraction.subtraction(A12, A22), Add.add(B21, B22));

            // Об’єднання результатів
            var C11 = Add.add(Subtraction.subtraction(Add.add(M1, M4), M5), M7);
            var C12 = Add.add(M3, M5);
            var C21 = Add.add(M2, M4);
            var C22 = Add.add(Subtraction.subtraction(Add.add(M1, M3), M2), M6);

            // Збирання результату в одну матрицю
            double[,] C = new double[n, n];
            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < newSize; j++)
                {
                    C[i, j] = C11[i, j];
                    C[i, j + newSize] = C12[i, j];
                    C[i + newSize, j] = C21[i, j];
                    C[i + newSize, j + newSize] = C22[i, j];
                }
            }

            return C;
        }
    }
}
