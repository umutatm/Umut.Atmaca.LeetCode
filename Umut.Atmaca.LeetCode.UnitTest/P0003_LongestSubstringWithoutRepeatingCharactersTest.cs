using Umut.Atmaca.LeetCode.Problems;
using Xunit;

namespace Umut.Atmaca.Tester.UnitTest {
    public class P0003_LongestSubstringWithoutRepeatingCharactersTest {

        [Theory]
        [InlineData(new object[] {
            "bbbbb",
            1
        })]
        [InlineData(new object[] {
            "abcabcbb",
            3
        })]
        [InlineData(new object[] {
            "dvdf",
            3
        })]
        public void LengthOfLongestSubstring(string str, int expected) {

            var problem = new P0003_LongestSubstringWithoutRepeatingCharacters();
            var result = problem.LengthOfLongestSubstring(str);
            Assert.True(expected == result);

        }
    }
}
