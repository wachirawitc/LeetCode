namespace Problems.Test;

public class ValidateIPAddressProblemTest
{
    [Fact]
    public void Test1()
    {
        var problem = new ValidateIPAddressProblem();
        var actual = problem.ValidIPAddress("172.16.254.1");
        const string expected = "IPv4";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var problem = new ValidateIPAddressProblem();
        var actual = problem.ValidIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334");
        const string expected = "IPv6";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var problem = new ValidateIPAddressProblem();
        var actual = problem.ValidIPAddress("256.256.256.256");
        const string expected = "Neither";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var problem = new ValidateIPAddressProblem();
        var actual = problem.ValidIPAddress("01.01.01.01");
        const string expected = "Neither";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test5()
    {
        var problem = new ValidateIPAddressProblem();
        var actual = problem.ValidIPAddress("192.0.0.1");
        const string expected = "IPv4";

        Assert.Equal(expected, actual);
    }
}