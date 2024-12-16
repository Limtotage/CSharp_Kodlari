public class Daily_Solution_43 {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        var pq = new PriorityQueue<(int,int),(int,int)>();
        for (int i = 0; i < nums.Length; i++) {
            pq.Enqueue((nums[i], i), (nums[i], i));
        }
        while(k-->0){
            var(temp,index)=pq.Dequeue();
            temp*=multiplier;
            pq.Enqueue((temp,index),(temp,index));
        }
        int[] result = new int[nums.Length];
        while(pq.Count>0){
            var(value,index)=pq.Dequeue();
            result[index]=value;
        }
        return result;
    }
}
