public class Solution_34 {
    public int NumTilings(int n) {
        var modulo = 1_000_000_007;
        long[] dp = {1,2,5};
        for(int i =3;i<n;i++){
            long domino = (2*dp[2]+dp[0])%modulo;
            dp[0]=dp[1];
            dp[1]=dp[2];
            dp[2]=domino;
        }
        return n<3 ? n: (int)dp[2];
    }
}
