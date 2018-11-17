using System;

namespace Umut.Atmaca.Tester.LeetCode.Problems {

    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// Example:
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output: 7 -> 0 -> 8
    /// Explanation: 342 + 465 = 807.
    /// </summary>
    public class P0002_AddTwoNumbers {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

            string firstNumber = GetNodeValue(l1);
            string secondNumber = GetNodeValue(l2);
            string sumStr = SumBigNumbers(firstNumber, secondNumber);
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

        private string SumBigNumbers(string number1, string number2) {
            var maxLen = Math.Max(number1.Length, number2.Length);
            number1 = number1.PadLeft(maxLen, '0');
            number2 = number2.PadLeft(maxLen, '0');

            string sumStr = string.Empty;
            int carryDigit = 0;
            for (var i = maxLen - 1; i >= 0; i--) {
                var digitSum = Convert.ToInt32(number1[i].ToString()) + Convert.ToInt32(number2[i].ToString()) + carryDigit;
                var remainder = digitSum % 10;
                carryDigit = digitSum / 10;
                sumStr = remainder + sumStr;
            }
            if (carryDigit > 0) {
                sumStr = carryDigit + sumStr;
            }

            return sumStr;
        }

    }

    public class ListNode {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode(int x) {
            val = x;
        }
    }
}
