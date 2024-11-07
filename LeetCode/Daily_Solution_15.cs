public class Daily_Solution_15 {
    public int LargestCombination(int[] candidates) {
        int[] bits = new int[32];
        foreach(int i in candidates){
            for(int j=0;j<32;j++){
                if(((1<<j)&i)>0)bits[j]++;
            }
        }
        int max=0;
        for(int i=0;i<32;i++){
            max=Math.Max(max,bits[i]);
        }
        return max;
    }
}
