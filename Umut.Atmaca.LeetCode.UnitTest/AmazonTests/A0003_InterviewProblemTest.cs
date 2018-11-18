using Umut.Atmaca.LeetCode.Amazon;
using Xunit;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0003_InterviewProblemTest {

        [Theory]
        [InlineData(new object[] {
            new int[]{ 1,0,0,0,0,1,0,0},
            1,
            new int[]{ 0,1,0,0,1,0,1,0}
        })]
        [InlineData(new object[] {
            new int[]{ 1,1,1,0,1,1,1,1},
            2,
            new int[]{ 0,0,0,0,0,1,1,0}
        })]
        public void cellCompete(int[] states, int numOfDays, int[] expected) {

            var problem = new A0003_InterviewProblem();
            var result = problem.cellCompete(states, numOfDays);

            for (int i = 0; i < result.Length; i++) {
                Assert.True(result[i] == expected[i]);
            }

        }

    }
}
