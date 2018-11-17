using System.Collections.Generic;
using System.Linq;

namespace Umut.Atmaca.Tester.LeetCode.Problems {

    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// Example:
    /// Given nums = [2, 7, 11, 15], target = 9,
    /// Because nums[0] + nums[1] = 2 + 7 = 9,
    /// return [0, 1].
    /// </summary>
    public class P0001_TwoSum {

        public int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++) {

                if (i == nums.Length) {
                    break;
                }

                for (int k = i + 1; k < nums.Length; k++) {
                    if (nums[i] + nums[k] == target) {
                        return new int[] { i, k };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        public int[] TwoSumV2(int[] nums, int target) {
            List<int> numList = nums.ToList();

            for (int i = 0; i < nums.Length; i++) {
                var addingComplement = target - nums[i];
                var index = numList.IndexOf(addingComplement);
                if (numList.Contains(addingComplement) && i != index && index != -1) {
                    return new int[] { i, index };
                }
            }

            return new int[] { -1, -1 };
        }

    }
}
