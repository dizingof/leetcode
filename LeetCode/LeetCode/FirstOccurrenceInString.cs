using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FirstOccurrenceInString
{
    public int StrStr(string haystack, string needle)
    {
        var index =haystack.IndexOf(needle, StringComparison.Ordinal);
        return index;
    }
}
