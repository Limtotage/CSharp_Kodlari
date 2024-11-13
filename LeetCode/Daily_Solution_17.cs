public class Daily_Solution_17 {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);
        int i=0,j=nums.Length-1;
        long syc=0;
        int mid=j-1;
        while(i<j){
            int sum=nums[i]+nums[j];
            if(sum<lower) {
                i++;
                if(mid<i) mid++;
            }
            else if(sum>upper) {
                j--;
                if(mid==j) mid--;
            }
            else{
                while(i<mid&&lower<=nums[i]+nums[mid]){
                    mid--;
                }
                syc+=j-mid;
                i++;
                if(mid<i)mid++;
            }
            
        }
        return syc;
    }
}
