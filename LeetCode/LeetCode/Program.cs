//using LeetCode;

//var solution = new MaxSubstringWithoutRepeats();

//Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew"));


//////////////////////////////////////////////////////////////////////////

using LeetCode;

string[] strs = { "flower", "flow", "flight" };
var longestCommonPrefix = new LongestCommonPrefix();
var result = longestCommonPrefix.LongestCommonPrefixMethod(strs);
foreach (var VARIABLE in result)
{
    Console.WriteLine(VARIABLE);
}

