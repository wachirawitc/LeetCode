namespace Problems;

public class MergeTwoSortedListsProblem
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        var numbers = new List<int>();
        numbers.AddRange(ToNumbers(list1));
        numbers.AddRange(ToNumbers(list2));

        numbers = numbers.OrderBy(value => value).ToList();

        var node = new ListNode(numbers[0]);
        numbers.RemoveAt(0);

        CreateNode(ref node, numbers);

        return node;
    }

    private static void CreateNode(ref ListNode previousNode, IList<int> numbers)
    {
        if (numbers.Any())
        {
            previousNode.next = new ListNode(numbers[0]);

            numbers.RemoveAt(0);
            CreateNode(ref previousNode.next, numbers);
        }
    }

    private static IEnumerable<int> ToNumbers(ListNode node)
    {
        var numbers = new List<int>();
        while (node != null)
        {
            numbers.Add(node.val);
            node = node.next;
        }

        return numbers;
    }

    public class ListNode
    {
        public ListNode next;

        public int val;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}