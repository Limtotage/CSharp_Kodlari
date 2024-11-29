public class Daily_Solution_31 {
    public int MinimumTime(int[][] grid) {
        if(grid[0][1]>1&&grid[1][0]>1) return -1;
        int m= grid.Length,n=grid[0].Length;
        bool[,] visited = new bool[m, n];
        int[] dx= {0,0,1,-1}, dy={1,-1,0,0};
        var pq = new PriorityQueue<(int time, int row, int col), int>();
        pq.Enqueue((0, 0, 0), 0);
        while(pq.Count>0){
            var (time,row,col)=pq.Dequeue();
            if(row==m-1&&col==n-1) return time;
            if(visited[row,col]) continue;
            visited[row,col] = true;
            for(int i=0;i<4;i++){
                int newrow=row+dx[i], newcol=col+dy[i];
                if(newrow>=0&&newrow<m&&newcol>=0&&newcol<n){
                    int nextime = time+1;
                    int requiredtime = grid[newrow][newcol];
                    if(nextime<requiredtime){
                        int wait = (requiredtime-nextime)%2==0 ? 0:1;
                        nextime=requiredtime+wait;
                    }
                    if(!visited[newrow,newcol]) pq.Enqueue((nextime, newrow, newcol), nextime);
                }
            }
        }
        return -1;
    }
}
