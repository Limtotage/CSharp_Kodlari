public class Solution_39 {
    public int countbit(int x){
        int bits =0;
        while(x>0){
            if(x%2==1) bits++;
            x/=2;
        }
        return bits;
    }
    public int[] CountBits(int n) {
        int[] answer = new int [n+1];
        for(int i=0;i<n+1;i++){
            answer[i]=countbit(i);
        }
        return answer;
    }
}
