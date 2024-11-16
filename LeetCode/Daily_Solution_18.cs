public class Daily_Solution_18 {
    public int[] ResultsArray(int[] nums, int k) { 
        int[] rslt = new int[nums.Length - k + 1];
        for (int i = 0; i <= nums.Length - k; i++) {
            bool Artiyormu = true;
            for (int j = i; j < i + k - 1; j++) {
                if (nums[j] + 1 != nums[j + 1]) { 
                    Artiyormu = false;
                    break;
                }
            }
            rslt[i] = Artiyormu ? nums[i + k - 1] : -1;
        }
        return rslt;
    }
}
