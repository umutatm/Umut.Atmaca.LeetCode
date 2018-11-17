using System;
using System.Collections.Generic;

namespace Umut.Atmaca.LeetCode.Problems {

    /// <summary>
    /// Given a string, find the length of the longest substring without repeating characters.
    /// Example 1:
    /// Input: "abcabcbb"
    /// Output: 3 
    /// Explanation: The answer is "abc", with the length of 3. 
    /// 
    /// Example 2:
    /// Input: "bbbbb"
    /// Output: 1
    /// Explanation: The answer is "b", with the length of 1.
    /// 
    /// Example 3:
    /// Input: "pwwkew"
    /// Output: 3
    /// Explanation: The answer is "wke", with the length of 3. 
    /// Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
    /// </summary>
    public class P0003_LongestSubstringWithoutRepeatingCharacters {

        public int LengthOfLongestSubstring(string s) {

            int maxLen = 0;
            string maxStr = string.Empty;
            for (int i = 0; i < s.Length; i++) {
                var letter = s[i].ToString();
                if (maxStr.Contains(letter)) {
                    maxLen = Math.Max(maxStr.Length, maxLen);

                    maxStr = maxStr.Substring(maxStr.LastIndexOf(letter) + 1);
                }

                maxStr += s[i].ToString();
            }

            return Math.Max(maxLen, maxStr.Length);
        }

    }
}
