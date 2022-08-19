using System.Text;

namespace Problems;

/// <summary>
/// String to Integer (atoi)
/// https://leetcode.com/problems/string-to-integer-atoi/
/// </summary>
public class StringToIntegerProblem
{
    public int MyAtoi(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        s = s.Trim();

        var isNegative = false;

        var stack = new StringBuilder();
        for (var index = 0; index < s.Length; index++)
        {
            var current = s[index];
            if (index == 0 && '-'.Equals(current))
            {
                isNegative = true;
            }
            else if (index == 0 && '+'.Equals(current))
            {
                isNegative = false;
            }
            else if (char.IsDigit(current))
            {
                stack.Append(current);
            }
            else
            {
                break;
            }
        }

        var text = stack.ToString();
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        if (int.TryParse(text, out var answer))
        {
            return isNegative ? answer * -1 : answer;
        }

        const int minimumRange = -2147483648;
        const int maximumRange = 2147483647;

        return isNegative ? minimumRange : maximumRange;
    }
}