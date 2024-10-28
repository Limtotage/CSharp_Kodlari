public class Daily_Solution_6 {
    public int LongestSquareStreak(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        int max=0,syc=0;
        foreach(int x in nums){
            int temp=x;
            syc=0;
            while(numSet.Contains(temp)){
                syc+=1;
                if (temp > Math.Sqrt(int.MaxValue)) break;
                temp = temp * temp;
            }
            max=Math.Max(max,syc);
        }
        return max==1 ? -1: max;
    }
}
