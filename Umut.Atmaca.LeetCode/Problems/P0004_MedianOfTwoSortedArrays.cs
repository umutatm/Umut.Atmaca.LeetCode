using System;
using System.Linq;

namespace Umut.Atmaca.LeetCode.Problems {
    public class P0004_MedianOfTwoSortedArrays {

        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {

            var arrMerge = nums1.Concat(nums2).ToArray();
            Array.Sort(arrMerge);
            var median = FindMedian(arrMerge);

            return median;
        }


        private double FindMedian(int[] arr) {
            var medianPos = (double)(arr.Length + 1) / 2;
            var medianPosLower = (int)Math.Floor(medianPos) - 1;
            var medianPosHigher = (int)Math.Ceiling(medianPos) - 1;

            return (double)(arr[medianPosLower] + arr[medianPosHigher]) / 2;
        }

    }
}
