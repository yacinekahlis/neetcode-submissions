public class Solution {
    public int SearchInsert(int[] nums, int target) {
        //lowerbound algo

        int low = 0; 
        int high = nums.Length;

        while(low<high){
            int mid = low + (high-low)/2;

            //est-il dans la premiere moitier?
            if(nums[mid]<target) low = mid + 1;
            else high = mid;
        }

        return low;
    }
}