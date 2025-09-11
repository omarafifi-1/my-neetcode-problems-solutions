public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        foreach (var str in strs)
        {
            char[] sorted = str.ToCharArray();
            Array.Sort(sorted);
            string sortedSTR = new string(sorted);
            if(!map.ContainsKey(sortedSTR))
            {
                map[sortedSTR] = new List<string>();
            }
            map[sortedSTR].Add(str);
        }
        return new List<List<string>>(map.Values);
    }
}
