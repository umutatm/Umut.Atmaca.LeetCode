using Umut.Atmaca.LeetCode.Amazon;
using Xunit;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0002_CountNumbersWithSameFirstAndLastDigitTest {

        [Theory]
        [InlineData(new object[] {
            0,10,9
        })]
        [InlineData(new object[] {
            10,100,9
        })]
        [InlineData(new object[] {
            100,1000,90
        })]
        [InlineData(new object[] {
            1000,10000,900
        })]
        [InlineData(new object[] {
            3,441,33
        })]
        public void CountSumOfPairs(int start, int end, int expected) {
            var problem = new A0002_CountNumbersWithSameFirstAndLastDigit();
            var result = problem.CountNumbersWithSameFirstAndLastDigit(start, end);

            Assert.True(result == expected);
        }

    }
}
