public class Solution_30 {
    private List<IList<int>> output = new List<IList<int>>();

    public void backtrack(int k, int n,int p,List<int> list,int currsum){
        if(currsum==n&&list.Count==k){
            output.Add(new List<int>(list));
            return;
        }
        if(list.Count>k) return;
        for(int i =p;i<=9;i++){
            if (currsum + i > n) break;
            list.Add(i);
            backtrack(k, n, i + 1, list, currsum + i);
            list.RemoveAt(list.Count - 1);
        }
    }
    public IList<IList<int>> CombinationSum3(int k, int n) {
        List<int> list = new List<int>();
        backtrack(k,n,1,list,0);
        return output;
    }
}
