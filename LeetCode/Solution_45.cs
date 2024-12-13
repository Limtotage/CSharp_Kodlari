public class Solution_45 {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points,((a,b)=>a[1].CompareTo(b[1])));
        int arrow=1;
        int end=points[0][1];
        foreach(var point in points){
            if(point[0]>end){
                arrow++;
                end=point[1];
            }
        }
        return arrow;
    }
}
