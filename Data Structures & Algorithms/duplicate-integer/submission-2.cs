public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> foundNums = new(nums);
        return foundNums.Count < nums.Length;
    }
}