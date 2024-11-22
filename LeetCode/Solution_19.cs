public class Solution_19 {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        Array.Sort(nums2,nums1);
        long sum=0,max=0;
        PriorityQueue<int,int> pq = new();
        for(int i=1;i<=nums1.Length;i++){
            sum+=nums1[^i];
            pq.Enqueue(nums1[^i],nums1[^i]);
            if(pq.Count>k){
                sum-=pq.Dequeue();
            }
            if(pq.Count==k){
                max=Math.Max(max,sum*nums2[^i]);
            }
        }
        return max;
    }
}
