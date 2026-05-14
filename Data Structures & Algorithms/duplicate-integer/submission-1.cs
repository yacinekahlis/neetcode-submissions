public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        var sorted = nums.OrderBy(n=> n).ToList();

        int i = 0;

        while (i< sorted.Count - 1)
        {
            if (sorted[i] == sorted[i+1]) return true;
            i++;
        }

        return false;
    }
}