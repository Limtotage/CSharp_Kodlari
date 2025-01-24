public class Solution_25 {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> res= new List<IList<int>>();
        var prev = new List<int>();
        prev.Add(1);
        res.Add(new List<int>(prev));
        for(int i=1;i<numRows;i++){
            var curr = new List<int>();
            curr.Add(1);
            for(int j=0;j<prev.Count-1;j++){
                curr.Add(prev[j]+prev[j+1]);
            }
            curr.Add(1);
            res.Add(new List<int>(curr));
            prev=curr;
        }
        return res;
    }
}
