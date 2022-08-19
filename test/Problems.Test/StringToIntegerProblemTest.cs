namespace Problems.Test;

public class StringToIntegerProblemTest
{
    [Fact]
    public void Test1()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("42");
        const int expected = 42;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test10()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("  -0012a42");
        const int expected = -12;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("   -42");
        const int expected = -42;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("4193 with words");
        const int expected = 4193;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("words and 987");
        const int expected = 0;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test5()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("-91283472332");
        const int expected = -2147483648;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test6()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("3.14159");
        const int expected = 3;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test7()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi(".1");
        const int expected = 0;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test8()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("-");
        const int expected = 0;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test9()
    {
        var stringToIntegerProblem = new StringToIntegerProblem();
        var actual = stringToIntegerProblem.MyAtoi("+1");
        const int expected = 1;

        Assert.Equal(expected, actual);
    }
}