public class Daily_Solution_23 {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        int[,] map = new int[m, n];
        int safe =m*n;
        for (int x = 0; x < m; x++){
            for (int y = 0; y < n; y++){
                map[x, y] = 1;
            }
        }
        foreach (var wall in walls){
            int x = wall[0];
            int y = wall[1];
            map[x, y] = 8;
            safe--;
        }
        foreach (var guard in guards) {
            map[guard[0], guard[1]] = 9;
            safe--;
        }
        int[] directions = new int[] {-1, 0, 1, 0, -1};
        foreach(var guard in guards){
            for(int d=0;d<4;d++){
                int x = guard[0],y = guard[1];
                int dx=directions[d],dy=directions[d+1];
                while(x+dx>=0 && x+dx<m&&y+dy>=0&&y+dy<n&&map[x+dx,y+dy]<2){
                    if(map[x+dx,y+dy]==1){
                        map[x+dx,y+dy]=0;
                        safe--;
                    }
                    x+=dx;
                    y+=dy;
                }
            }
        }
        return safe;
    }
}
