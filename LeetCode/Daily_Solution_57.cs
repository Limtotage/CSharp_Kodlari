public class Daily_Solution_57 {
    public long CountBadPairs(int[] nums) {
        Dictionary<long,long> freq = new Dictionary<long,long>();
        long good_count = 0;
        var enumaratednums = nums.Select((Num,index) => new {Index = index, Value=Num});
        foreach(var num in enumaratednums){
            long key = num.Index-num.Value;
            long currentCount = freq.GetValueOrDefault(key, 0);
            good_count+= currentCount;
            freq[key]=currentCount+1;
        }
        long n = nums.Length;
        return (n*(n-1))/2 - good_count;
      /*
      long n = nums.Length
      for(int i=0;i<n;i++){
        long key = i-nums[i];
        long currentCount = freq.GetValueOrDefault(key, 0);
        good_count+= currentCount;
        freq[key]=currentCount+1;
      }*/
    }
}
