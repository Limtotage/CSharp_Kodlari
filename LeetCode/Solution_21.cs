public class Solution_21 {
    public int FindPeakElement(int[] nums) {
        int n = nums.Length;
        if(n==1)return 0;
        if(nums[0]>nums[1]) return 0;
        if(nums[n-1]>nums[n-2]) return n-1;
        int low=0, high=nums.Length-1;
        while(high>=low){
            int mid = low+ (high-low)/2;
            int newMid =NewMidindex(nums,mid, nums.Length);
            if(newMid == mid) return mid;
            if(newMid < mid) high = newMid;
            if(newMid> mid) low = newMid;
        }
        return -1;
    }
    public int NewMidindex(int[] arr, int mid, int n){
        if(mid==n-1) return mid-1;
        if(mid==0) return 1;
        if(arr[mid]>arr[mid+1]&&arr[mid]>arr[mid-1]) return mid;
        else if(arr[mid+1] > arr[mid]) return mid+1;
        else return mid-1;
    }
}

