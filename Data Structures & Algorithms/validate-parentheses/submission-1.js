class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isValid(s) {
        if (s.length%2 != 0) return false;

        let stack = [];
        let map = {
            ')': '(',
            '}': '{',
            ']': '['
        };

        for (let char of s) {
            if (char === '(' || char === '{' || char === '[') {
                stack.push(char);
            } else {
                if (stack.pop() !== map[char]) return false;
            }
        }

        return stack.length === 0;
    }
}