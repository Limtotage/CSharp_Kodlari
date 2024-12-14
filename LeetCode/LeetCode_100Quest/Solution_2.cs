public class Solution_2 {
    public List<IList<int>> result;
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        result = new List<IList<int>>();
        var tempList = new List<int>();
        backtrack(candidates, target,tempList,0);
        return result;
    }
    public void backtrack(int[] candidates, int target, List<int> cur_List,int start){
        int sum = cur_List.Sum();
        if (sum > target) return;
        if (sum == target) {
            result.Add(new List<int>(cur_List));
            return;
        }
        for (int i = start; i < candidates.Length; i++) {
            cur_List.Add(candidates[i]);
            backtrack(candidates, target, cur_List, i); 
            cur_List.RemoveAt(cur_List.Count - 1); 
        }
    }
}
