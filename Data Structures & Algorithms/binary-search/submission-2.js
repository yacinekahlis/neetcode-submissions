class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number}
     */
    search(nums, target) {
        let left = 0;
        let right = nums.length - 1;

        while (left<=right){
            //on veux le milieu index
            let milieux_index = Math.floor((left+right) /2)

            //si la valeur de target == celle de milieux return target
            if (target == nums[milieux_index]) return milieux_index;

            //si la valeur de target est plus petite que celle du milieu on garde left et right devient milieu
            if (target < nums[milieux_index]){
                right = milieux_index - 1;
            }

            else{
                left = milieux_index + 1;
            }

            //si la valeur de target est plus grasnde que celle du milieu on garde right et left devient milieu


        }

        return -1;
    }
}
