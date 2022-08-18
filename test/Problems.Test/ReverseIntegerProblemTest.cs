namespace Problems.Test;

public class ReverseIntegerProblemTest
{
    [Fact]
    public void Test1()
    {
        var reverseIntegerProblem = new ReverseIntegerProblem();
        var actual = reverseIntegerProblem.Reverse(123);
        const int expected = 321;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var reverseIntegerProblem = new ReverseIntegerProblem();
        var actual = reverseIntegerProblem.Reverse(-123);
        const int expected = -321;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var reverseIntegerProblem = new ReverseIntegerProblem();
        var actual = reverseIntegerProblem.Reverse(120);
        const int expected = 21;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var reverseIntegerProblem = new ReverseIntegerProblem();
        var actual = reverseIntegerProblem.Reverse(1534236469);
        const int expected = 0;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test5()
    {
        var reverseIntegerProblem = new ReverseIntegerProblem();
        var actual = reverseIntegerProblem.Reverse(-2147483648);
        const int expected = 0;

        Assert.Equal(expected, actual);
    }
}