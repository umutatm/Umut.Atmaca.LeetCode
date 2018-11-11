using Umut.Atmaca.Tester.LeetCode;
using Xunit;

namespace Umut.Atmaca.Tester.UnitTest {

    public class P0001_TwoSumTest {

        [Theory]
        [InlineData(new object[] {
            new int[] { 2, 7, 11, 15 },
            9,
            new int[] { 0,1 }
        })]
        [InlineData(new object[] {
            new int[] { 2, 7, 11, 15 },
            18,
            new int[] { 1,2 }
        })]
        [InlineData(new object[] {
            new int[] { 2, 7, 11, 15 },
            17,
            new int[] { 0,3 }
        })]
        public void TwoSum(int[] numbers, int target, int[] expectedIndices) {
            int[] elements = new int[] { };
            var problem = new P0001_TwoSum();
            var indices = problem.TwoSum(numbers, target);

            Assert.True(indices[0] == expectedIndices[0] && indices[1] == expectedIndices[1]);
        }


        [Theory]
        [InlineData(new object[] {
            new int[] { 2, 7, 11, 15 },
            9,
            new int[] { 0,1 }
        })]
        [InlineData(new object[] {
            new int[] { 2, 7, 11, 15 },
            18,
            new int[] { 1,2 }
        })]
        [InlineData(new object[] {
            new int[] { 2, 7, 11, 15 },
            17,
            new int[] { 0,3 }
        })]
        public void TwoSumV2(int[] numbers, int target, int[] expectedIndices) {
            int[] elements = new int[] { };
            var problem = new P0001_TwoSum();
            var indices = problem.TwoSumV2(numbers, target);

            Assert.True(indices[0] == expectedIndices[0] && indices[1] == expectedIndices[1]);
        }
    }
}
