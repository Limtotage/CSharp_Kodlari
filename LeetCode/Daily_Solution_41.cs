public class Daily_Solution_41 {
    public long PickGifts(int[] gifts, int k) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        int temp=gifts.Max();
        foreach (var gift in gifts) {
            maxHeap.Enqueue(gift, temp-gift);
        }
        while (k-- > 0) {
            int sqrt = maxHeap.Dequeue();
            maxHeap.Enqueue((int)Math.Sqrt(sqrt),temp- (int)Math.Sqrt(sqrt));
        }
        long sum=0;
        while(maxHeap.Count>0) sum+=maxHeap.Dequeue();
        return sum;
    }
}
