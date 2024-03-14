//using LeetCode;

//var solution = new MaxSubstringWithoutRepeats();

//Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew"));


//////////////////////////////////////////////////////////////////////////


//string[] strs = { "flower", "flow", "flight" };
//var longestCommonPrefix = new LongestCommonPrefix();
//var result = longestCommonPrefix.LongestCommonPrefixMethod(strs);
//foreach (var VARIABLE in result)
//{
//    Console.WriteLine(VARIABLE);
//}

//////////////////////////////////////////////////////////////////////////
//var firstOccurrenceInString = new FirstOccurrenceInString();
//var index = firstOccurrenceInString.StrStr("leetcode", "leeto");
//Console.WriteLine(index);

//////////////////////////////////////////////////////////////////////////

using LeetCode;


var s = "   fly me   to   the moon  ";
var lengthOfLastWord = new LengthOfLastWord();
var length = lengthOfLastWord.LengthOfLastWordMethod(s);
Console.WriteLine(length);
