public class Solution_32 {
    public bool CanJump(int[] nums) {
        int targetindex=nums.Length-1;
        for(int i = nums.Length-2;i>=0;i--){
            if(nums[i]>=(targetindex-i)) targetindex=i;
        }
        return targetindex==0;
    }
}
