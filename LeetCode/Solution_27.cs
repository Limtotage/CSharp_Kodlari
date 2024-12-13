public class Solution_27 {
    class Cell{
        public int loc_x;
        public int loc_y;
        public int Distance;
        public Cell(int x,int y, int distance){
            this.loc_x=x;
            this.loc_y=y;
            this.Distance=distance;
        }
    }
    public int NearestExit(char[][] maze, int[] entrance) {
        int m= maze.Length, n= maze[0].Length;
        bool[,] visited = new bool[m,n];
        Queue<Cell> que = new Queue<Cell>();
        que.Enqueue(new Cell(entrance[0], entrance[1], 0));
        visited[entrance[0], entrance[1]] = true;
        int[] dx= {0,0,1,-1};
        int[] dy= {1,-1,0,0};
        while(que.Count>0){
            var current = que.Dequeue();
            int x = current.loc_x;
            int y = current.loc_y;
            int distance = current.Distance;
            if((x==0||x==m-1||y==0||y==n-1)&&!(x==entrance[0]&&y==entrance[1])) return distance;
            for(int i=0;i<4;i++){
                int new_x= x+dx[i];
                int new_y= y+dy[i];
                if(new_x>=0&&new_x<m&&new_y>=0&&new_y<n){
                    if((maze[new_x][new_y] == '.'&&!visited[new_x,new_y])){
                        visited[new_x,new_y]=true;
                        que.Enqueue(new Cell(new_x,new_y,distance+1));
                    }
                }
            }
        }
        return -1;
    }
}
