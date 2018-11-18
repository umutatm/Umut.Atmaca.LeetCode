using System.Collections.Generic;

namespace Umut.Atmaca.LeetCode.UnitTest.AmazonTests {
    public class A0006_DataGenerator : DataGenerator {

        protected override List<object[]> GetData() {

            return new List<object[]> {
                new object[] {
                    20,
                    new List<List<int>> {
                        new List<int> {
                            1,8
                        },
                        new List<int> {
                            2,7
                        },
                        new List<int> {
                            3,14
                        },
                    },
                    new List<List<int>> {
                        new List<int> {
                            1,5
                        },
                        new List<int> {
                            2,10
                        },
                        new List<int> {
                            3,14
                        },
                    },
                    new List<List<int>> {
                        new List<int> {
                            3,1
                        }
                    }
                }
            };
        }
    }
}
