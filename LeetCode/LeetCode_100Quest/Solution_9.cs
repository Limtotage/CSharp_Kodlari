public class Solution_9{
    public int[] SearchRange(int[] nums, int target) {
        return new int[] { firstindex(nums, target), lastindex(nums, target) };
    }
    public int firstindex(int[] nums, int target){
        int left = 0, right = nums.Length - 1, result = -1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) {
                result= mid;
                right=mid-1;
            }
            else if (nums[mid]>target) {
                right = mid - 1;
            } 
            else {
                left = mid + 1;
            }
        }
        return result;
    }
    public int lastindex(int[] nums, int target){
        int left = 0, right = nums.Length - 1, result = -1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) {
                result= mid;
                left=mid+1;
            }
            else if (nums[mid]>target) {
                right = mid - 1;
            } 
            else {
                left = mid + 1;
            }
        }
        return result;
    }
}
