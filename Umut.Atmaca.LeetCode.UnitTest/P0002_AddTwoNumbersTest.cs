using Umut.Atmaca.LeetCode.UnitTest;
using Umut.Atmaca.Tester.LeetCode;
using Xunit;

namespace Umut.Atmaca.Tester.UnitTest {
    public class P0002_AddTwoNumbersTest {

        [Theory]
        [ClassData(typeof(P0002_DataGenerator))]
        public void AddTwoNumbers(ListNode l1, ListNode l2, ListNode expected) {

            var problem = new P0002_AddTwoNumbers();
            var result = problem.AddTwoNumbers(l1, l2);

            var currentNode = result;
            var currentExpectedNode = expected;
            while (currentNode != null) {
                Assert.True(currentNode.val == currentExpectedNode.val);
                currentNode = currentNode.next;
                currentExpectedNode = currentExpectedNode.next;
            }
        }
    }
}
