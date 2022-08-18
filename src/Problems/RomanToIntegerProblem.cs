namespace Problems;

public class RomanToIntegerProblem
{
    public int RomanToInt(string s)
    {
        var romans = s.ToCharArray();

        var integers = new List<int>();
        for (var index = 0; index < romans.Length; index++)
        {
            var current = romans.ElementAt(index);
            var next = romans.ElementAtOrDefault(index + 1);

            switch (current)
            {
                case 'I' when 'V'.Equals(next):
                    integers.Add(4);
                    index++;
                    break;

                case 'I' when 'X'.Equals(next):
                    integers.Add(9);
                    index++;
                    break;

                case 'I':
                    integers.Add(1);
                    break;

                case 'V':
                    integers.Add(5);
                    break;

                case 'X' when 'L'.Equals(next):
                    integers.Add(40);
                    index++;
                    break;

                case 'X' when 'C'.Equals(next):
                    integers.Add(90);
                    index++;
                    break;

                case 'X':
                    integers.Add(10);
                    break;

                case 'L':
                    integers.Add(50);
                    break;

                case 'C' when 'D'.Equals(next):
                    integers.Add(400);
                    index++;
                    break;

                case 'C' when 'M'.Equals(next):
                    integers.Add(900);
                    index++;
                    break;

                case 'C':
                    integers.Add(100);
                    break;

                case 'D':
                    integers.Add(500);
                    break;

                case 'M':
                    integers.Add(1000);
                    break;
            }
        }

        return integers.Sum();
    }
}