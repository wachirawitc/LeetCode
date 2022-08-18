namespace Problems.Test;

public class PowProblemTest
{
    [Fact]
    public void Test1()
    {
        var powProblem = new PowProblem();
        var actual = powProblem.MyPow(2.00000, 10);
        const double expected = 1024.00000;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var powProblem = new PowProblem();
        var actual = powProblem.MyPow(2.10000, 3);
        const double expected = 9.26100;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var powProblem = new PowProblem();
        var actual = powProblem.MyPow(2.00000, -2);
        const double expected = 0.25000;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var powProblem = new PowProblem();
        var actual = powProblem.MyPow(8.88023, 3);
        const double expected = 700.28148;

        Assert.Equal(expected, actual);
    }
}