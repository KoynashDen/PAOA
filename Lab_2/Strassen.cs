namespace PAOA.Lab_2
{
    public class Strassen
    {
        public static double[,] strassen(double[,] A, double[,] B)
        {
            int n = A.GetLength(0); 
            int m = A.GetLength(1); 
            int p = B.GetLength(1); 
            
            if (m != B.GetLength(0))
                throw new ArgumentException("Кількість стовпців A має дорівнювати кількості рядків B.");
            
            int maxDim = Math.Max(Math.Max(n, m), p);
            int size = 1;
            while (size < maxDim) size <<= 1; 
            
            // Розширення матриць до розміру 2^k x 2^k
            double[,] Aend = ExtendToSize.extendToSize(A, size);
            double[,] Bend = ExtendToSize.extendToSize(B, size);
            
            // Виклик алгоритму Штрассена
            double[,] Cend = StrassenAlgoritm.strassenAlgoritm(Aend, Bend);
            
            // Обрізаємо результат назад до оригінального розміру n x p
            return TrimMatrix.trimMatrix(Cend, n, p);
        }
    }
}