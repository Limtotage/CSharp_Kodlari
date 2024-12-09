public class Daily_Solution_40 {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        bool[] result = new bool[queries.Length];
        int[] parity = new int[nums.Length];
        for(int i=1;i<nums.Length;i++){
            parity[i]=parity[i-1];
            if(nums[i]%2==nums[i-1]%2){
                parity[i]++;
            }
        }
        int j=0;
        foreach(var que in queries){
            int SpecialCount= parity[que[1]] - (que[0]>0? parity[que[0]]:0);
            result[j++]=(SpecialCount==0);
        }
        return result;
    }
}
