namespace Problems;

public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return Array.Empty<int>();
        }

        var numbers = nums
            .Select((value, index) => new Item { Value = value, Index = index })
            .ToList();

        var items = Enumerable
            .Range(0, 1 << numbers.Count)
            .Select(index => numbers
                .Where((_, i) => (index & (1 << i)) != 0)
                .ToArray());

        var answers = items
            .Where(x => x.Select(y => y.Value).Sum() == target)
            .ToList();
        //return answers.Select(x => x.Index).ToArray();

        return Array.Empty<int>();
    }

    private class Item
    {
        public int Index { get; init; }

        public int Value { get; init; }
    }
}