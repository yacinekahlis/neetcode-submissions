public class Solution {
    public int MaxProfit(int[] prices) {
        var minmumProfit = 0;

        for (int i=0; i<prices.Length; i++)
        {
            for (int j=i+1; j<prices.Length; j++)
            {
                if (prices[j]-prices[i]>minmumProfit) minmumProfit=prices[j]-prices[i];
            }
        }

        return minmumProfit;
    }
}
