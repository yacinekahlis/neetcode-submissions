class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number}
     */
    search(nums: number[], target: number): number {
        let low = 0;
        let high = nums.length - 1;

        while(low<=high){
            let mid = low + Math.floor((high-low)/2);
            if(nums[mid]===target) return mid;
            
            // 1. La moitié gauche est-elle triée ?
            if (nums[low] <= nums[mid]) {
                if (nums[low] <= target && target < nums[mid]) {
                    high = mid - 1; // Chercher à gauche
                } else {
                    low = mid + 1;  // Chercher à droite
                }
            } 
            // 2. Sinon, la moitié droite est forcément triée
            else {
                if (nums[mid] < target && target <= nums[high]) {
                    low = mid + 1;  // Chercher à droite
                } else {
                    high = mid - 1; // Chercher à gauche
                }
            }
        }

        return -1;
    }
}
