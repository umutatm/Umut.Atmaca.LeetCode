using Umut.Atmaca.LeetCode.Amazon;
using Xunit;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0001_CountSumOfPairsTest {

        [Theory]
        [InlineData(new object[] {
            new int[] { 1, 2 , 3, 4, 5, 6, 8, 9, 11, 15 ,18, 21 ,22 ,23 ,31, 34, 37, 41, 42, 53, 55, 56},
            48,
            129
        })]
        public void CountSumOfPairs(int[] numbers, int maxCountOfPairs, int expected) {
            var problem = new A0001_CountSumOfPairs();
            var result = problem.CountSumOfPairs(numbers, maxCountOfPairs);

            Assert.True(result == expected);
        }

        [Theory]
        [InlineData(new object[] {
            new int[] { 1, 2 , 3, 4, 5, 6, 8, 9, 11, 15 ,18, 21 ,22 ,23 ,31, 34, 37, 41, 42, 53, 55, 56},
            48,
            129
        })]
        public void CountSumOfPairsV2(int[] numbers, int maxCountOfPairs, int expected) {
            var problem = new A0001_CountSumOfPairs();
            var result = problem.CountSumOfPairsV2(numbers, maxCountOfPairs);

            Assert.True(result == expected);
        }

    }
}
