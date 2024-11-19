public class Daily_Solution_21
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        Queue<int> window = new Queue<int>();
        HashSet<int> uniq = new HashSet<int>();
        long currentSum = 0;
        long max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (uniq.Contains(nums[i]))
            {
                while (window.Peek() != nums[i])
                {
                    int removed = window.Dequeue();
                    uniq.Remove(removed);
                    currentSum -= removed;
                }
                int redundant = window.Dequeue();
                uniq.Remove(redundant);
                currentSum -= redundant;
            }
            window.Enqueue(nums[i]);
            uniq.Add(nums[i]);
            currentSum += nums[i];
            if (window.Count == k)
            {
                max = Math.Max(max, currentSum);
                int removed = window.Dequeue();
                uniq.Remove(removed);
                currentSum -= removed;
            }
        }
        return max;
    }
}
