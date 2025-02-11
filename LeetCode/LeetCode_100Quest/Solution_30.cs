public class Solution_30 {
    public int MinPathSum(int[][] grid) {//1200ms
        int m = grid.Length, n= grid[0].Length;
        var dxy = new List<(int,int)>{(1,0),(0,1)};
        int[][] dist = new int[m][];
        for(int i=0;i<m;i++){
            dist[i] = new int[n];
            Array.Fill(dist[i],int.MaxValue);
        }
        bool isValid(int row,int col){
            return row<m && col<n;
        }
        dist[0][0]=grid[0][0];
        void dfs(int x,int y){
            foreach((int dx,int dy) in dxy){
                int newx=x+dx,newy=y+dy;
                if(isValid(newx,newy)){
                    int curval= dist[x][y]+grid[newx][newy];
                    if(curval<dist[newx][newy]){
                        dist[newx][newy]=curval;
                        dfs(newx,newy);
                    }
                }
            }
        }
        dfs(0,0);
        return dist[m-1][n-1];
    }
}
public class Solution {//5ms DP
    public int MinPathSum(int[][] grid) {
        int m = grid.Length, n= grid[0].Length;
        int[] PrevDp = new int[n];
        for(int row = 0;row<m;row++){
            int[] CurrDp = new int[n];
            for(int col =0;col<n;col++){
                if(row==col && row==0){
                    CurrDp[0]=grid[0][0];
                }
                else{
                    int up = row-1>=0 ? PrevDp[col]:int.MaxValue;
                    int left = col-1>=0 ? CurrDp[col-1]:int.MaxValue;
                    CurrDp[col]=grid[row][col]+Math.Min(up,left);
                }
            }
            PrevDp=CurrDp;
        }
        return PrevDp[n-1];
    }
}
