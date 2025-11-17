namespace PAOA;

public class Lab1For
{
    static long Fact(long x) {
        if (x < 0) return 1; 
        long res = 1;
        for (long i = 1; i <= x; i++) res *= i;
        return res;
    }
    
    public static void lab1For()
    {
        Console.Write("Введіть n і m: ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        double S = 0;

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= m; j++) {
                double numerator = Math.Pow(i, n - j);
                long denominator = Fact((long)Math.Pow(m, j) - j);
                S += numerator / denominator;
            }
        }

        Console.WriteLine($"S = {S}");
    }
}