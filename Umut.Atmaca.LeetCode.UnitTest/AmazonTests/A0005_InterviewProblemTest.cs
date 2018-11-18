using System.Collections.Generic;
using Umut.Atmaca.LeetCode.Amazon;
using Xunit;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0005_InterviewProblemTest {

        [Theory]
        [ClassData(typeof(A0005_DataGenerator))]
        public void nearestXsteakHouses(int totalSteakHouses, int[,] allLocations, int numOfSteakHouses, List<List<int>> expected) {
            var problem = new A0005_InterviewProblem();
            var result = problem.nearestXsteakHouses(totalSteakHouses, allLocations, numOfSteakHouses);

            for (int i = 0; i < expected.Count; i++) {
                Assert.True(result[i][0] == expected[i][0] && result[i][1] == expected[i][1]);
            }
        }

    }
}
