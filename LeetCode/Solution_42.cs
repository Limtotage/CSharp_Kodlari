public class Solution_42 {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals,(x,y) => x[1].CompareTo(y[1]));
        int prevEnd = int.MinValue;
        int removeCount = 0;
        foreach (var interval in intervals)
        {
            if (interval[0] < prevEnd) removeCount++;
            else prevEnd = interval[1];
        }
        return removeCount;
    }
}
