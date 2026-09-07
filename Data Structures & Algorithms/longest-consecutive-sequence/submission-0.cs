public class Solution {
    public int LongestConsecutive(int[] nums) {
        //Créer un hashset contenant tous les elements de l'array O(n)
        //Créer une var longest
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        //boucler à travers l'array O(n)
        foreach (int num in set){
            //est-ce que l'element que je suis à un element +1 existant? par ex: si on a 100 est-ce que 101 existe
            //ATTENTION: il faut vérifier si -1 n'existe pas par 99, pcq sinon ce n'est pas le bon début de sequence
            // si -1 n'existe pas on peut créer une nouvelle liste de sequence avec l'element actuel dedans

            if(!set.Contains(num-1)){
                int currentNum = num;
                int currentStreak = 1;

                while (set.Contains(currentNum+1)){
                    currentNum++;
                    currentStreak++;
                }

                longest = Math.Max(longest, currentStreak);
            }
                
                //si oui, on met le +1 dans le dictionnaire, puis on refait le check sur le prochain +1

                //on passe au prochain element

        }

        return longest;
            
        //retourner la longueur de la liste la plus longue
    }
}
