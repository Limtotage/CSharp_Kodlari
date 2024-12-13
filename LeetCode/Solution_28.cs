public class Solution_28 {
    public int OrangesRotting(int[][] grid) {
        int m= grid.Length,n=grid[0].Length;
        int[] dx= {0,0,1,-1} , dy={1,-1,0,0};
        Queue<(int,int)> rottens =  new Queue<(int,int)>();
        for(int i=0;i<m;i++)
        for(int j=0;j<n;j++)
        if(grid[i][j]==2) rottens.Enqueue((i,j));
        int rotten_count=-1;
        while(rottens.Count>0){
            int size = rottens.Count;
            rotten_count++;
            while(size-->0){
                var (x,y) = rottens.Dequeue();
                for(int i=0;i<4;i++){
                    int newx = x+dx[i],newy = y+dy[i];
                    if(newx>=0 && m>newx && newy>=0 && newy<n){
                        if(grid[newx][newy]==1){
                            grid[newx][newy]=2;
                            rottens.Enqueue((newx,newy));
                        }
                    }
                }
            }
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]==1)
                    return -1;
            }
        }
        return Math.Max(0, rotten_count);
    }
}
