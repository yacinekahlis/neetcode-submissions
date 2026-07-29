public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1;
        int high = piles.Max();

        while (low<high){
            int mid = low + (high-low)/2;

            if(!CanFinish(mid, piles, h)){
                low = mid + 1;
            }
            else{
                high = mid;
            }
        }
        
        return low;
    }

    private bool CanFinish(int vitesse, int[] piles, int h)
    {
        int heures = 0;

        foreach (int pile in piles)
        {
            heures += (int)Math.Ceiling((double)pile / vitesse);
        }

        return heures <= h;
    }
}

