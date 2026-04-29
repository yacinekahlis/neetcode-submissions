class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs) {
        let encoded_string = ""
        
        for (let str of strs) {
            encoded_string += str.length + "#" + str;
        }

        return encoded_string;
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str) {
        let i = 0;
        let fortnite = [];
        
        while (i<str.length){
            let j = i;
            
            while(str[j]!=="#"){
                j++;
            }

            const length = parseInt(str.slice(i, j));
            let word = str.slice(j+1, j+1+length);

            fortnite.push(word);
            i = j+1+length;
        }

        return fortnite;
    }
}
