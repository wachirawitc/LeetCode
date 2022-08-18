namespace Problems.Test;

public class RomanToIntegerProblemTest
{
    [Fact]
    public void Test1()
    {
        var problem = new RomanToIntegerProblem();

        const string s = "III";

        const int expected = 3;
        var actual = problem.RomanToInt(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var problem = new RomanToIntegerProblem();

        const string s = "LVIII";

        const int expected = 58;
        var actual = problem.RomanToInt(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var problem = new RomanToIntegerProblem();

        const string s = "MCMXCIV";

        const int expected = 1994;
        var actual = problem.RomanToInt(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var problem = new RomanToIntegerProblem();

        const string s = "DCXXI";

        const int expected = 621;
        var actual = problem.RomanToInt(s);

        Assert.Equal(expected, actual);
    }
}