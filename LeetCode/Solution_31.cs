public class Solution_31 {
    public int Tribonacci(int n) {
        if(n<=2) return n<=1 ? n:1;
        int[]dp={0,1,1};
        for(int i=3;i<=n;i++){
            int rslt= dp[2]+dp[1]+dp[0];
            dp[0]=dp[1];
            dp[1]=dp[2];
            dp[2]=rslt;
        }
        return dp[2];
    }
}
