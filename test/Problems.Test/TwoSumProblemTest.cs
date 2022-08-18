namespace Problems.Test
{
    public class TwoSumProblemTest
    {
        [Fact]
        public void Test1()
        {
            var problem = new TwoSumProblem();

            int[] numbers = { 2, 7, 11, 15 };
            const int target = 9;

            int[] expected = { 0, 1 };

            var actual = problem.TwoSum(numbers, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var problem = new TwoSumProblem();

            int[] numbers = { 3, 2, 4 };
            const int target = 6;

            int[] expected = { 1, 2 };

            var actual = problem.TwoSum(numbers, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            var problem = new TwoSumProblem();

            int[] numbers = { 3, 3 };
            const int target = 6;

            int[] expected = { 0, 1 };

            var actual = problem.TwoSum(numbers, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            var problem = new TwoSumProblem();

            int[] numbers = { 0, 4, 3, 0 };
            const int target = 0;

            int[] expected = { 0, 3 };

            var actual = problem.TwoSum(numbers, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            var problem = new TwoSumProblem();

            int[] numbers = { -1, -2, -3, -4, -5 };
            const int target = -8;

            int[] expected = { 2, 4 };

            var actual = problem.TwoSum(numbers, target);
            Assert.Equal(expected, actual);
        }
    }
}