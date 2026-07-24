class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s: string): boolean {
        //ici c'est une question de symétrie. On peut donc opter pour un two pointers. 
        const isAlnum = (c: string) => /[a-z0-9]/i.test(c);

        let left = 0; //pointeur au début de la string
        let right = s.length - 1; //pointeur à la fin de la string

        //là il faut juste checker comment on enleve les non alphanumerique

        while(left<right){
            while(left<right && !isAlnum(s[left])) left++; // on nuke les char non voulue 
            while(left<right && !isAlnum(s[right])) right--; // on nuke les char non voulue 

            if(s[left].toLowerCase() !== s[right].toLowerCase()) return false;
            
            left++;
            right--;
        }

        return true; //on est sortie de la boucle, c'est un palindrome
    }

}
