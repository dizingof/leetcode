using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
internal class MaxSubstringWithoutRepeats
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        HashSet<char> set = new HashSet<char>();
        int left = 0, right = 0;

        while (right < n)
        {
            if (!set.Contains(s[right]))
            {
                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                set.Remove(s[left]);
                left++;
            }
        }

        return maxLength;
    }
}
