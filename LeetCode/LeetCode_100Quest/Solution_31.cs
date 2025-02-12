public class Solution_31 {
    public int MaxProduct(int[] nums) {
        int maxending=nums[0],minending=nums[0],res=nums[0];
        for(int i=1;i<nums.Length;i++){
            int num =nums[i];
            int tempvalue = Math.Max(num,Math.Max(num*minending,num*maxending));
            minending=Math.Min(num,Math.Min(num*minending,num*maxending));
            maxending=tempvalue;
            res=Math.Max(res,maxending);
        }
        return res;
    }
}
