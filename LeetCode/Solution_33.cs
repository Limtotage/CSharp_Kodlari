public class Solution_33 {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n==1) return nums[0];
        int[] dp = new int[2];
        for(int i=0;i<n;i++){
            int curr= Math.Max(dp[1],nums[i]+dp[0]);
            dp[0]=dp[1];
            dp[1]=curr;
        }
        return dp[1];
    }
}
