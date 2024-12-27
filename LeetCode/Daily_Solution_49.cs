public class Daily_Solution_49 {
    public int MaxScoreSightseeingPair(int[] values) {
        int res = int.MinValue;
        int first =values[0];
        for(int i=1;i<values.Length;i++){
            if(first+values[i]-i>res) res=first+values[i]-i;
            if(values[i]+i>first) first= values[i]+i;
        }
        return res;
    }
}
