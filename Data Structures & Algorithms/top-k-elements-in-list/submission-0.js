class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {
        //si k est plus grand que number.length? On throw?
        
        //on sort le array
        nums.sort();

        //map (valeur, frequence)
        const frequenciesMap = new Map();

        //on boucle chaque element et on compte les frequences puis on ajoute au map
        for (let num of nums){
            let frequence = frequenciesMap.get(num) || 0;

            frequenciesMap.set(num, frequence +1);

        }

        //return les k frequences les plus eleves
        // trier par fréquence décroissante
        const sorted = [...frequenciesMap.entries()]
            .sort((a, b) => b[1] - a[1]);

        // prendre les k premiers et retourner seulement les valeurs
        return sorted.slice(0, k).map(entry => entry[0]);
    }
}
