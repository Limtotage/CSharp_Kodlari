public class Solution_22 {
    public long hurry_EatThemAll(int[] piles,int k){
        long banana=0;
        foreach(int x in piles){
            banana+=(x%k==0 ? (x/k):(x/k)+1);
        }
        return banana;
    }
    public int MinEatingSpeed(int[] piles, int h) {
        int high=piles[0],low=1;
        foreach(int x in piles) if(x>high) high=x;
        while(high>=low){
            int mid=low+(high-low)/2;
            if(hurry_EatThemAll(piles,mid)<=h) high =mid-1;
            else low=mid+1;
        }
        return low;
    }
}
