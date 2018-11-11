using System.Collections.Generic;
using Umut.Atmaca.Tester.LeetCode;

namespace Umut.Atmaca.LeetCode.UnitTest {
    class P0002_DataGenerator : DataGenerator {

        protected override List<object[]> GetData() {
            P0002_AddTwoNumbers p0002 = new P0002_AddTwoNumbers();
            return new List<object[]> {
                new object[] {
                    p0002.CreateNode("342"),
                    p0002.CreateNode("465"),
                    p0002.CreateNode("807")
                },
                new object[] {
                    p0002.CreateNode("9"),
                    p0002.CreateNode("9999999991"),
                    p0002.CreateNode("10000000000")
                },
                new object[] {
                    p0002.CreateNode("1000000000000000000000000000001"),
                    p0002.CreateNode("465"),
                    p0002.CreateNode("1000000000000000000000000000466")
                }
            };
        }
    }
}
