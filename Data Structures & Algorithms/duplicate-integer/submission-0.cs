public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> foundNums = new();
        foreach(int i in nums)
        {
            if (foundNums.ContainsKey(i))
            {
                return true;            
            }

            foundNums.Add(i, 1);
        }

        return false;
    }
}