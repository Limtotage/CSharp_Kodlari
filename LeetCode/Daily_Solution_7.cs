public class Daily_Solution_7 {
    public int MaxMoves(int[][] grid) {
        int row =grid.Length;
        int col =grid[0].Length;
        int max=0,cur=0;
        int[,] Dp = new int[row,col];
        for (int j = 0; j < row; j++) {
            Dp[j, 0] = 0;
        }
        for(int i =1;i<col;i++){
            cur=0;
            for(int j =0;j<row;j++){
                if(grid[j][i]>grid[j][i-1]) Dp[j, i] = Math.Max(Dp[j, i], 1 + Dp[j, i - 1]);
                if(j + 1 <row  &&grid[j][i]>grid[j+1][i-1]) Dp[j, i] = Math.Max(Dp[j, i], 1 + Dp[j + 1, i - 1]);
                if(j - 1 >= 0 &&grid[j][i]>grid[j-1][i-1]) Dp[j, i] = Math.Max(Dp[j, i], 1 + Dp[j - 1, i - 1]);
                cur = Math.Max(cur, Dp[j, i]);
            }
            if(cur ==0 || cur == max) break;
            max = Math.Max(max, cur);
        }
        return max;
    }
}
