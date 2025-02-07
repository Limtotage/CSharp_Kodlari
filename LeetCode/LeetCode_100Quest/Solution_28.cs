public class Solution_28 {
    public int[] TwoSum(int[] nums, int target) {
        var hashTable = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int temp= nums[i];
            if(hashTable.ContainsKey(target-temp)){
                return new int[] {hashTable[target-temp],i};
            }
            hashTable[temp]=i;
        }
        return new int[0];
    }
}
