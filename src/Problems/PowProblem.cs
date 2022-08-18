namespace Problems;

public class PowProblem
{
    public double MyPow(double x, int n)
    {
        var row = Math.Pow(x, n);
        var ans = row.ToString("#0.00000");
        return double.Parse(ans);
    }
}