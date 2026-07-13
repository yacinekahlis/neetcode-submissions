class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s) {
        let cleaned_string = s.replace(/[^a-z0-9]/gi, '').toLowerCase();
        let left = 0;
        let right = cleaned_string.length-1;
        
        while (left<right){
            //process current element

            //condition
            if(cleaned_string[left]!=cleaned_string[right]) return false;
            
            left++;
            right--;
        }

        return true;
    }
}
