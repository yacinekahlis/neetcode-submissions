public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var i = 0;
        var true_target = 0;

        var valid_indexes = new int[] {};

        //on boucle a travers l'array
        //on fait element courant - target = l'element voulu
        while (i<nums.Length)
        {   
            true_target = target - nums[i];
            var j = 0;

            //on boucle à travers le array pour trouver le vrai target

            while (j<nums.Length)
            {
                if (i == j)
                {
                    j++; 
                    continue;
                } 

                if (nums[j] == true_target)  valid_indexes = new int[] { j, i };

                j++;
            }

            i++;
        }

        return valid_indexes;
    }
}
