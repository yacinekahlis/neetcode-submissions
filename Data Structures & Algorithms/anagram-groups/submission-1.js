class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        let anagrams = [];
        let used = new Set();

        for (let i = 0; i < strs.length; i++) {
            if (used.has(i)) continue;

            let group = [strs[i]];
            used.add(i);

            for (let j = i + 1; j < strs.length; j++) {
                if (used.has(j)) continue;

                if (
                    strs[i].split('').sort().join('') ===
                    strs[j].split('').sort().join('')
                ) {
                    group.push(strs[j]);
                    used.add(j);
                }
            }

            anagrams.push(group);
        }

        return anagrams;
    }
}
