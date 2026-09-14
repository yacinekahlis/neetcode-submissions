public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //2 pointers
        //un commence dans nums1 à m-n-1, l'autre commence à n-1
        //on insere dans nums1 à partie de la fin la valeur la plus grosse et on recule l'index conséquent
        
        int p1 = m - 1;         // Dernier élément valide de nums1
        int p2 = n - 1;         // Dernier élément de nums2
        int i = m + n - 1;      // Dernier index disponible dans nums1

        while(p2>=0){
            if(p1 >= 0 && nums1[p1] > nums2[p2]){
                nums1[i] = nums1[p1];
                p1--;
            }
            else{
                nums1[i] = nums2[p2];
                p2--;
            }

            i--;
        }
    }
}