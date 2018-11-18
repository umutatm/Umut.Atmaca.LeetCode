using Umut.Atmaca.LeetCode.Amazon;
using Xunit;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0004_InterviewProblemTest {

        [Theory]
        [InlineData(new object[] {
            5,
            new int []{2,3,4,5,6 },
            1
        })]
        [InlineData(new object[] {
            5,
            new int []{2,4,6,8,10 },
            2
        })]
        public void generalizedGCD(int num, int[] arr, int expected) {

            var problem = new A0004_InterviewProblem();
            var result = problem.generalizedGCD(num, arr);

            Assert.True(result == expected);
        }

    }
}
