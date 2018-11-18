using System.Collections.Generic;
using Umut.Atmaca.LeetCode.Amazon;
using Xunit;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0005_DataGenerator: DataGenerator  {

        protected override List<object[]> GetData() {
            
            return new List<object[]> {
                new object[] {
                    3,
                    new int[,] {
                        { 1,-3 },
                        { 1, 2 },
                        { 3, 4 }
                    },
                    1,
                    new List<List<int>> {
                        new List<int> {
                            1,2
                        }
                    }
                }
            };
        }
    }
}
