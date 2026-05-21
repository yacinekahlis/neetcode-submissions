public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencies = new Dictionary<int, int>(); // key=valeur, value=frequency
        
        foreach (var num in nums){
            if(!frequencies.ContainsKey(num)) frequencies[num]=0;
            frequencies[num] +=1;
        }

        return frequencies.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}
