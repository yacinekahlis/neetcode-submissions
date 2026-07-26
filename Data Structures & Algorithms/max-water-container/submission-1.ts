class Solution {
    /**
     * @param {number[]} heights
     * @return {number}
     */
    maxArea(heights: number[]): number {
        //initialiser 2 pointeurs, un à la premiere barre et un à la derniere
        let start = 0;
        let end = heights.length - 1;

        let maxWater = 0;

        //on fait converger les pointeurs
        while(start<end){
            //on calcul l'air mais faut prendre la barre qui est la plus petite pcq sinon ca deborde
            let d = end-start;
            let area = Math.min(heights[start], heights[end]) * d;
            maxWater = Math.max(area, maxWater);

            //on bouge la barre la plus petite pcq c'est elle qui decide de l'air actuel
            if(heights[start]<heights[end]) start++;
            else end--;
        }

        return maxWater;
    }
}
