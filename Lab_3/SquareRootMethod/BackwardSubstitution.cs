namespace PAOA.Lab_3.SquareRootMethod;

public class BackwardSubstitution
{
    public static double[] backwardSubstitution(double[,] S, double[] y)
    {
        int n = y.Length;
        double[] x = new double[n];

        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0;
            for (int k = i + 1; k < n; k++)
                sum += S[i, k] * x[k];
            x[i] = (y[i] - sum) / S[i, i];
        }

        return x;
    }

}