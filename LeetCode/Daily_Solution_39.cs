public class Daily_Solution_39 {
    public int MaxTwoEvents(int[][] events) {
        Array.Sort(events,(a,b)=> a[1].CompareTo(b[1]));
        int n = events.Length;
        int[] dp = new int[n];
        dp[0] = events[0][2];
        for(int i=1;i<n;i++){
            dp[i]= Math.Max(dp[i-1],events[i][2]);
        }
        int maxSum = 0;
        for(int i=0;i<n;i++){
            int prev_index = binary(events,i,events[i][0]);
            int currSum = events[i][2];
            if(prev_index!=-1){
                currSum+=dp[prev_index];
            }
            maxSum=Math.Max(maxSum,currSum);
        }
        return maxSum;
    }
    public int binary(int[][] events,int end_index,int start_time){
        int left=0, right = end_index-1,result=-1;
        while(left<=right){
            int mid=left+(right-left)/2;
            if(events[mid][1]<start_time){
                result=mid;
                left=mid+1;
            }
            else right = mid-1;
        }
        return result;
    }
}
