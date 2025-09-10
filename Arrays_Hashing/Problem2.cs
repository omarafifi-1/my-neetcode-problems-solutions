public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] FirstString = s.ToCharArray();
        Array.Sort(FirstString);
        char[] SecondString = t.ToCharArray();
        Array.Sort(SecondString);
        return FirstString.SequenceEqual(SecondString);
}   }
