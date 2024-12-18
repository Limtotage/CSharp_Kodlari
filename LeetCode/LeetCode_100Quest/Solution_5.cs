public class Solution_5 {
    public bool result;
    public int[] dx={0,0,1,-1};
    public int[] dy={1,-1,0,0};
    public bool[,] visited;
    public bool Exist(char[][] board, string word) {
        result = false;
        int n=board.Length,m=board[0].Length;
        visited = new bool[n,m];
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(board[i][j]==word[0]) {
                    visited[i,j] =true;
                    backtrack(board, word, ""+word[0], i,j,1);
                    visited[i,j] =false;
                }
            }
        }
        return result;
    }
    public void backtrack(char[][] board,string search,string cur,int row,int col,int index){
        if(search==cur){
            result=true;
            return;
        }
        for(int i=0;i<4;i++){
            int xnew= row+dx[i];
            int ynew= col+dy[i];
            if(xnew>=0&&ynew>=0&&xnew<board.Length&&ynew<board[0].Length&&!visited[xnew,ynew]&&board[xnew][ynew]==search[index]){
                visited[xnew,ynew]=true;
                backtrack(board,search,cur+search[index],xnew,ynew,index+1);
                visited[xnew,ynew]=false;
            }
        }
    }
}
