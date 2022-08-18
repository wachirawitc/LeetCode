namespace Problems;

public class ReverseIntegerProblem
{
    public int Reverse(int x)
    {
        if (x is int.MinValue or int.MaxValue)
        {
            return 0;
        }

        var chars = Math.Abs(x).ToString().ToCharArray();
        Array.Reverse(chars);

        var text = new string(chars);
        if (int.TryParse(text, out var answer) == false)
        {
            return 0;
        }

        return x < 0 ? answer * -1 : answer;
    }
}