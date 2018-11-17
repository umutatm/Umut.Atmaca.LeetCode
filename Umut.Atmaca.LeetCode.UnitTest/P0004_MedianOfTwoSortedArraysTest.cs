using Umut.Atmaca.LeetCode.Problems;
using Xunit;

namespace Umut.Atmaca.Tester.UnitTest {
    public class P0004_MedianOfTwoSortedArraysTest {

        [Theory]
        [InlineData(new object[] {
            new int[] {1, 3},
            new int[] {2},
            2.0d
        })]
        [InlineData(new object[] {
            new int[] {1, 2},
            new int[] {3, 4},
            2.5d
        })]
        [InlineData(new object[] {
            new int[] { },
            new int[] {1},
            1
        })]
        [InlineData(new object[] {
            new int[] {1, 1},
            new int[] {1, 2},
            1
        })]
        public void LengthOfLongestSubstring(int[] nums1, int[] nums2, double expected) {

            var problem = new P0004_MedianOfTwoSortedArrays();
            var result = problem.FindMedianSortedArrays(nums1, nums2);
            Assert.True(expected == result);

        }
    }
}
