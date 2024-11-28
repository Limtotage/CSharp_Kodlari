public class Daily_Solution_30 {
    public int MinimumObstacles(int[][] grid) {
        int m=grid.Length, n=grid[0].Length;
        int[,] distance = new int[m,n];
        for(int i=0;i<m;i++) 
        for(int j=0;j<n;j++)
        distance[i,j]=int.MaxValue;
        int[] dx = {0,0,1,-1};
        int[] dy = {1,-1,0,0};
        var zero_one_bfs = new LinkedList<int[]>();
        distance[0, 0] = 0;
        zero_one_bfs.AddFirst(new int[]{0, 0});
        while(zero_one_bfs.Count>0){
            var current = zero_one_bfs.First.Value;
            int currx=current[0],curry=current[1];
            zero_one_bfs.RemoveFirst();
            for(int i=0;i<4;i++){
                int newx = currx+dx[i], newy= curry+dy[i];
                if(newx>=0&&newx<m&&newy>=0&&newy<n){
                    int weight =grid[newx][newy];
                    if(distance[currx,curry]+weight<distance[newx,newy]){
                        distance[newx,newy]=distance[currx,curry]+weight;
                        if(weight==0) zero_one_bfs.AddFirst(new int[]{newx, newy});
                        else zero_one_bfs.AddLast(new int[]{newx, newy});
                    }
                }
            }
        }
        return distance[m-1,n-1];
    }
}
