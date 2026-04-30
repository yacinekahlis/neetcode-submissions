class Solution {
    /**
     * @param {number[]} heights
     * @return {number}
     */
    maxArea(heights) {
        // On ne peux pas trier car on doit garder les distance
        // Ou il faut ramasser les distance puis trier (à voir)
        // pour le 2 pointers suffit de deplacer vers la plus petite hauteur comme ca on une chance de debloquer la hauteur

        
        //la formule du total serait la min(valeur(indexBarre_1), valeur(indexBarre_2)) * (indexBarre_2 - indexBarre_1)


        let i = 0;
        let j = heights.length -1;
        let max = 0;

        while (i<j){
            let distance = j-i
            let area = Math.min(heights[i], heights[j]) * distance;

            if (max<area) max = area

            if(heights[i]<heights[j])i++;
            else j--;
        }

        return max;

    }
}
