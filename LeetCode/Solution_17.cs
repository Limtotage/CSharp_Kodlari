public class Solution_17 {
    public int FindCircleNum(int[][] isConnected) {
        int n= isConnected.Length;
        bool[] gezdikmi = new bool[n];  
        int syc=0;
        for(int i=0;i<n;i++){
            if(!gezdikmi[i]){
                Dfs(isConnected,gezdikmi,i);
                syc++;
            }
        }
        return syc;
    }
    public void Dfs(int[][] isConnected,bool[] gezdikmi,int sahir){
        gezdikmi[sahir]= true;
        for(int i=0;i<isConnected.Length;i++){
            if(isConnected[sahir][i]==1&&!gezdikmi[i]){
                Dfs(isConnected,gezdikmi,i);
            }
        }
    }
}
