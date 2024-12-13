public class Daily_Solution_42 {
    public long FindScore(int[] nums) {
        int n = nums.Length;
        var marked = new bool[n];
        var pqlikelist = new List<(int value,int index)>(n);
        long result = 0;
        for(int i=0;i<n;i++){
            pqlikelist.Add((nums[i],i));
        }
        pqlikelist.Sort((a,b)=> {
            if(a.value==b.value){
                return a.index.CompareTo(b.index);
            }
            else{
                return a.value.CompareTo(b.value);
            }
        });
        foreach(var(val,idx) in pqlikelist){
            if(marked[idx]) continue;
            result+=val;
            marked[idx]=true;
            if(idx>0&&!marked[idx-1])marked[idx-1]=true;
            if(idx<n-1&&!marked[idx+1])marked[idx+1]=true;
        }
        return result;
    }
}
