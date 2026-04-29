class Solution {
    /**
     * @param {number[]} prices
     * @return {number}
     */
    maxProfit(prices) {
        let i = 0;
        let lowest_value = Number.POSITIVE_INFINITY; 
        let best_profit = 0;

        while (i<prices.length-1){
            let j = i+1;
            if(lowest_value>prices[i]) lowest_value=prices[i];
            
             while (j<prices.length){
                if (prices[j]-lowest_value>best_profit) best_profit=prices[j]-lowest_value;             
                j++;
             }

            i++;
        }

        return best_profit;
    }
}
