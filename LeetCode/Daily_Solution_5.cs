public class Daily_Solution_5 {
    public int CountSquares(int[][] matrix) {
        int n=matrix.Length,m=matrix[0].Length;
        int[,] dp = new int[matrix.Length,matrix[0].Length];
        int top=0;
        for(int i =0;i<n;i++){
            for(int j=0;j<m;j++){
                if(matrix[i][j]==1){
                    if(i==0||j==0) dp[i, j] = 1;
                    else dp[i,j]=1+Math.Min(dp[i,j-1],Math.Min(dp[i-1,j],dp[i-1,j-1]));
                    top+=dp[i,j];
                }
            }
        }
        return top;
    }
}
