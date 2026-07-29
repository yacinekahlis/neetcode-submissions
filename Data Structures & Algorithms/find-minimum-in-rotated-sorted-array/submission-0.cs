public class Solution {
    public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length - 1;

        while(low<high){
            int mid = low + (high-low)/2;
            //le minimum ce trouve dans la partie de droite
            if(nums[mid] > nums[high]){
                low = mid + 1;
            }
            //la moitié de droite est trié
            else{
                high = mid;
            }
        }
        return nums[low];
    }
}
