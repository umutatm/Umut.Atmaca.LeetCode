using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Umut.Atmaca.Tester.LeetCode {
    public class P0002_AddTwoNumbers {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

            string firstNumber = GetNodeValue(l1);
            string secondNumber = GetNodeValue(l2);

            //BigInteger sum = BigInteger.Add(new BigInteger(Encoding.ASCII.GetBytes(firstNumber)), new BigInteger(Encoding.ASCII.GetBytes(secondNumber)));
            long sum = Convert.ToInt64(firstNumber) + Convert.ToInt64(secondNumber);
            string sumStr = sum.ToString();

            ListNode sumNode = CreateNode(sumStr);

            return sumNode;
        }

        private string GetNodeValue(ListNode node) {
            if (node.next == null) {
                return node.val.ToString();
            }
            return GetNodeValue(node.next) + node.val;
        }

        public ListNode CreateNode(string value) {
            if (value.Length == 1) {
                return new ListNode(Convert.ToInt32(value));
            }
            var node = new ListNode(Convert.ToInt32(value.Substring(value.Length - 1)));
            node.next = CreateNode(value.Substring(0, value.Length - 1));
            return node;
        }

    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
        }
    }
}
