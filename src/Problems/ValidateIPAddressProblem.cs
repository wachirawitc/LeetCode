namespace Problems;

/// <summary>
/// Validate IP Address
/// https://leetcode.com/problems/validate-ip-address/
/// </summary>
public class ValidateIPAddressProblem
{
    public string ValidIPAddress(string queryIP)
    {
        const string neither = "Neither";

        var v4 = queryIP.Split(".");
        if (v4.Length == 4)
        {
            return IsV4(v4) ? "IPv4" : neither;
        }

        var v6 = queryIP.Split(":");
        if (v6.Length == 8)
        {
            return IsV6(v6) ? "IPv6" : neither;
        }

        return neither;
    }

    private static bool IsV4(IEnumerable<string> classes)
    {
        foreach (var text in classes)
        {
            if (int.TryParse(text, out var answer) == false)
            {
                return false;
            }

            if (text[0] == '0')
            {
                return false;
            }

            if (answer is < 0 or > 255)
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsV6(IEnumerable<string> classes)
    {
        foreach (var text in classes)
        {
            if (text.Length > 4)
            {
                return false;
            }

            if (int.TryParse(text, System.Globalization.NumberStyles.HexNumber, null, out int x) == false)
            {
                return false;
            }
        }

        return true;
    }
}