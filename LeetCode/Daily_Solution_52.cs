public class Daily_Solution_52 {
    public int result =0;
    public int[] pubnums;
    public int WaysToSplitArray(int[] nums) {
        pubnums = nums;
        long sumleft= nums.Select(n=> (long)n).Sum()-nums[nums.Length-1];
        long sumright= nums[nums.Length-1];
        backtracking(sumleft,sumright,nums.Length-2);
        return result;
    }
    public void backtracking(long sumleft,long sumright,int index){
        if (index < 0) return;
        else if (sumleft>=sumright) result++;
        sumright+=pubnums[index];
        sumleft-=pubnums[index];
        backtracking(sumleft,sumright,index-1);
    }
}
