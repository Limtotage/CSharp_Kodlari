public class Daily_Solution_48 {
    public int result = 0;

    public int FindTargetSumWays(int[] nums, int target) {
        backtrack(nums, target, 0, 0);
        return result;
    }

    private void backtrack(int[] nums, int target, int cur, int index) {
        if (index == nums.Length) { 
            if (cur == target) {    
                result++;
            }
            return;
        }
        backtrack(nums, target, cur + nums[index], index + 1);
        backtrack(nums, target, cur - nums[index], index + 1);
    }
}
