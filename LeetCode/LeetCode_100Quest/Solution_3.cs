public class Solution_3 {
    public IList<IList<int>> result;
    public IList<IList<int>> Permute(int[] nums) {
        result = new List<IList<int>>();
        backtrack(nums,new List<int>());
        return result;
    }
    public void backtrack(int[] nums,List<int> perm){
        if(perm.Count==nums.Length){
            result.Add(new List<int>(perm));
            return;
        }
        for(int i=0;i<nums.Length;i++){
            if(perm.Contains(nums[i])) continue;
            perm.Add(nums[i]);
            backtrack(nums,perm);
            perm.RemoveAt(perm.Count - 1);
        }
    }
}
