public class Solution_23 {
    public long TotalCost(int[] costs, int k, int candidates) {
        List<int> list = new List<int>(costs);
        long cost=0;
        for(int i=0;i<k;i++){
            PriorityQueue<int,int> pq =new();
            for(int j=1;j <= Math.Min(candidates, list.Count);j++){
                pq.Enqueue(list[j-1],list[j-1]);
                pq.Enqueue(list[^j],list[^j]);
            }
            int removed=pq.Dequeue();
            for(int j=0;j<list.Count;j++){
                if(list[j]==removed){
                    cost+=list[j];
                    list.RemoveAt(j);
                    break;
                }
            }
        }
        return cost;
    }
}
