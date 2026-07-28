public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;

        while(low<=high){
            int mid = low + (high-low)/2;

            if(nums[mid] == target) return mid;
            //la target est dans la partie de droite et on s'est que mid n'est pas la bonne reponse
            if(nums[mid]<=target) low=mid+1;
            //la target est dans la partie de gauche et on s'est que mid n'est pas la bonne reponse
            else high=mid-1;
        }

        return -1;
    }
}
