using static Problems.MergeTwoSortedListsProblem;

namespace Problems.Test;

public class MergeTwoSortedListsProblemTest
{
    [Fact]
    public void Test1()
    {
        var line1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var line2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

        var problem = new MergeTwoSortedListsProblem();
        var actual = problem.MergeTwoLists(line1, line2);

        Assert.Equal(ToArray(expected), ToArray(actual));
    }

    private static int[] ToArray(ListNode? node)
    {
        var items = new List<int>();
        while (node != null)
        {
            items.Add(node.val);
            node = node.next;
        }

        return items.ToArray();
    }
}