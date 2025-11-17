namespace PAOA.Lab_3.SquareRootMethod;

public class ForwardSubstitution
{
    public static double[] forwardSubstitution(double[,] S, double[] b)
    {
        int n = b.Length;
        double[] y = new double[n];

        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            for (int k = 0; k < i; k++)
                sum += S[k, i] * y[k];
            y[i] = (b[i] - sum) / S[i, i];
        }

        return y;
    }
}