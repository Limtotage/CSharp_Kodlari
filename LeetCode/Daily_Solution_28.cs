public class Daily_Solution_28 {
    public int FindChampion(int n, int[][] edges) {
        int[] result = new int[n];
        foreach(var bigger in edges){
            result[bigger[1]]++;
        }
        int zero_count=0,chmp=-1;
        for(int i=0;i<n;i++){
            if(result[i]==0) {
                zero_count++;
                if (zero_count > 1)return -1; 
                chmp = i;
            }
        }
        return chmp;
    }
}
