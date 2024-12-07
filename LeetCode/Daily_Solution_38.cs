public class Daily_Solution_38 {
    public int MinimumSize(int[] nums, int maxOperations) {
        int left=1;
        int right =nums.Max();
        int result=1;
        while(left<=right){
            int mid=left+(right-left)/2;
            if(okay(nums,maxOperations,mid)){
                result=mid;
                right=mid-1;
            }
            else left=mid+1;
        }
        return result;
    }
    public bool okay(int[] nums,int maxOperations,int penalty){
        int operations=0;
        foreach(int num in nums){
            operations+=(num-1)/penalty;
        }
        return operations<=maxOperations;
    }
}
