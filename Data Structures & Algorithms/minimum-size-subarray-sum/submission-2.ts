class Solution {
    /**
     * @param {number} target
     * @param {number[]} nums
     * @return {number}
     */
    minSubArrayLen(target: number, nums: number[]): number {
        let minLen = Number.POSITIVE_INFINITY;
        let sum = 0;
        let left = 0;

        for(let right = 0; right<nums.length; right++){
            sum+=nums[right];

            while(sum>=target){
                minLen = Math.min(minLen, right-left + 1);
                sum-=nums[left];
                left++;
            }

        }

        if(minLen == Number.POSITIVE_INFINITY) return 0;

        return minLen;
    }
}
