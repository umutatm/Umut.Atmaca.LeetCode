using System.Collections.Generic;
using Umut.Atmaca.LeetCode.Amazon;
using Xunit;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0006_InterviewProblemTest {

        [Theory]
        [ClassData(typeof(A0006_DataGenerator))]
        public void optimalUtilization(int deviceCapacity, List<List<int>> foregroundAppList, List<List<int>> backgroundAppList, List<List<int>> expected) {
            var problem = new A0006_InterviewProblem();
            var result = problem.optimalUtilization(deviceCapacity, foregroundAppList, backgroundAppList);

            for (int i = 0; i < expected.Count; i++) {
                Assert.True(expected[i][0] == result[i][0] && expected[i][1] == result[i][1]);
            }
        }

    }
}
