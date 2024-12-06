public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        int[] arr = new int[10001];
        foreach(int i in banned)arr[i]=1;
        long total=0;
        int counter=0;
        for(int i=1;i<=n;i++){
            if(arr[i]==1)continue;
            total+=i;
            if(total>maxSum ) {
                break;
            }
            counter++;
        }
        return counter;
    }
        
}
