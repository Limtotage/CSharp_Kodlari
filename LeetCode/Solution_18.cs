public class Solution_18 {
    public int FindKthLargest(int[] nums, int k) {
        int res=0;
        PriorityQueue<int,int> sortednums = new PriorityQueue<int,int>();
        foreach(int num in nums){
            sortednums.Enqueue(num,-num);
        }
        for(int i=0;i<k;i++){
            res=sortednums.Dequeue();
        }
        return res;
    }
}
