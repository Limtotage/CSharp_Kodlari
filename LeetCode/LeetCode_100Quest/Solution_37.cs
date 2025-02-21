public class Solution_37 {
    public int NumSquares(int n) {
        int[] Dp = new int[n+1];
        Dp[0]=0;
        for(int i=1;i<=n;i++){
            int minval=int.MaxValue;
            for(int j=1;j*j<=i;j++){
                int temp=i-j*j;
                if(Dp[temp]<minval)minval=Dp[temp];
            }
            Dp[i]=minval+1;
        }       
        return Dp[n];
    }
}
