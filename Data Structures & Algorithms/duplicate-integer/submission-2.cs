public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        Array.Sort(nums); //en ordre croissant [1,3,1,2] -> [1,1,2,3]

        for (int i=0; i<nums.Length-1; i++)
        {
            if (nums[i]==nums[i+1]) return true;
        }

        return false;
    }
}