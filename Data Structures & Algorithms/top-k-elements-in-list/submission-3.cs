public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var frequences = new Dictionary<int, int>();

        foreach (var num in nums){
            //check dans le dictionnaire si element existe
            //si non existant on ajoute une clef et valeur de 0
            //on incremente de 1

            if(!frequences.ContainsKey(num)){
                frequences[num] = 0;
            }

            frequences[num] += 1;

        }

        //retourner les freq >= k
        return frequences
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
