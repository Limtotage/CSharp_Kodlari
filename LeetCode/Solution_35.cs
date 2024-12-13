public class Solution_35 {
    public int UniquePaths(int m, int n) {
        int[] prev_row = new int[n];
        int[] curr_row = new int[n];
        Array.Fill(prev_row,1);
        for(int i=1;i<m;i++){
            for(int j=0;j<n;j++){
                if(j==0) curr_row[j]=1;
                else{
                    curr_row[j]=curr_row[j-1]+prev_row[j];
                }
            }
            prev_row=curr_row;
        }
        return m==1 ? prev_row[n-1] : curr_row[n-1];
        /*int[,] dp =new int[m,n];
        dp[0,0] = 1;
        for(int i=0;i<m;i++){
            for(int j =0;j<n;j++){
                if(i == 0 || j== 0) dp[i,j]=1;
                else{
                    dp[i,j]=dp[i-1,j]+dp[i,j-1];
                }
            }
        }
        return dp[m-1,n-1];*/
    }
}
