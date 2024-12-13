public class Solution_32 {
    public int MinCostClimbingStairs(int[] cost) {
        int n =cost.Length;
        int[] dp = new int[n];
        dp[1]=cost[1];
        dp[0]= cost[0];
        if(n<=2) return(Math.Min(dp[1],dp[0]));
        for(int i=2;i<n;i++){
            int curr= cost[i]+Math.Min(dp[1],dp[0]);
            dp[0]=dp[1];
            dp[1]=curr;
        }
        return Math.Min(dp[1],dp[0]);
    }

}
