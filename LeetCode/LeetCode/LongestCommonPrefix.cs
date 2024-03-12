namespace LeetCode;
public class LongestCommonPrefix
{
    public string LongestCommonPrefixMethod1(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }

    public string LongestCommonPrefixMethod(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        var result = "";
        var first =strs.First();
        var source = strs.ToList();
        foreach (var s in source)
        {
            if (s != first)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i <= s.Length)
                    {
                        if (s[i] == first[i])
                        {
                            result += s[i];

                        }
                    }
                    
                }
            }
        }

        return result;
    }


}
