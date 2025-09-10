public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var Map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int check = target - nums[i];
            if (Map.ContainsKey(check)) {
                return new int[] { Map[check], i };
            }
            Map[nums[i]] = i;
        }

        return null; 
    }
}
