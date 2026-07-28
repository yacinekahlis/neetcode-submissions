class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    searchRange(nums: number[], target: number): number[] {
        let low1 = 0;
        let high1 = nums.length;

        let low2 = 0;
        let high2 = nums.length;

        while (low1<high1){
            let mid = low1 + Math.floor((high1-low1)/2);

            if(nums[mid]<target) low1 = mid+1;
            else high1 = mid;
        }

        while (low2<high2){
            let mid = low2 + Math.floor((high2-low2)/2);

            if(nums[mid]<=target) low2 = mid+1;
            else high2 = mid;
        }
        if(nums[low1]===target && nums[low2-1]===target) return [low1, low2-1];
        else return [-1,-1];
    }
}
