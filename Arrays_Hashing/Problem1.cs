public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> filtered = new HashSet<int>(nums);
        if (nums.Length == filtered.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}