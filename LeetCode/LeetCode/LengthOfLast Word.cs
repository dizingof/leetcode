namespace LeetCode;
public class LengthOfLastWord
{
    public int LengthOfLastWordMethod(string s)
    {
        var strings = s.TrimEnd().Split(" ");
        var stringLength = strings.Last().Length;
        return stringLength;
    }
}
