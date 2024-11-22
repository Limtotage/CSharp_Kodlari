/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution_20 : GuessGame {
    public int GuessNumber(int n) {
        int max=n,min=1;
        while(max>=min){
            int mid=min+(max-min)/2;
            int res=guess(mid);
            if(res==1)min=mid+1;
            else if(res==-1) max=mid-1;
            else return mid;
        }
        return -1;
    }
}
