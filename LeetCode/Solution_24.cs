public class SmallestInfiniteSet {
    private PriorityQueue<int, int> pq; 
    private HashSet<int> inQueue;      
    private int current; 
    public SmallestInfiniteSet() {
        pq = new PriorityQueue<int, int>();
        inQueue = new HashSet<int>();
        current = 1;
    }
    
    public int PopSmallest() {
        if (pq.Count > 0)
        {
            int smallest = pq.Dequeue();
            inQueue.Remove(smallest);
            return smallest;
        }
        return current++;
    }
    
    public void AddBack(int num) {
        if (num < current && !inQueue.Contains(num))
        {
            pq.Enqueue(num, num);
            inQueue.Add(num);
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
