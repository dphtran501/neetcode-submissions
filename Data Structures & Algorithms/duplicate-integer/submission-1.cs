public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> foundNums = new();
        foreach(int i in nums)
        {
            if (foundNums.Contains(i))
            {
                return true;            
            }

            foundNums.Add(i);
        }

        return false;
    }
}