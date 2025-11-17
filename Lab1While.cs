namespace PAOA;

public class Lab1While
{
    static long Fact(long x) {
        if (x < 0) return 1;
        long res = 1;
        for (long i = 1; i <= x; i++) res *= i;
        return res;
    }
    
    public static void lab1While()
    {
        Console.Write("Введіть n і m: ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        double S = 0;
        int i = 1;

        while (i <= n) {
            int j = 1;
            while (j <= m) {
                double numerator = Math.Pow(i, n - j);
                long denominator = Fact((long)Math.Pow(m, j) - j);
                S += numerator / denominator;
                j++;
            }
            i++;
        }

        Console.WriteLine($"S = {S}");
    }
}