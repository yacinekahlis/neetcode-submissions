class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        let num1=0
        let num2=0

        for(let i=0; i<nums.length; i++){
            num1 = i;
            let number_to_find = target - nums[i];

            for(let j=i+1; j<nums.length; j++){
                if (number_to_find == nums[j]){
                    num2 = j;
                    return [num1, num2]
                }
            }
        }
        return [num1, num2]
    }
}
