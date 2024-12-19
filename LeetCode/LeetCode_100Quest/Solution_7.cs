public class Solution_7 {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) {
            (nums2,nums1)=(nums1,nums2);
        }
        int m= nums1.Length,n=nums2.Length;
        int x1=0,x2=m;
        while(x1<=x2){
            int i=(x1+x2)/2;
            int j=((n+m+1)/2)-i;
            int maxX = (i == 0) ? int.MinValue : nums1[i - 1];
            int maxY = (j == 0) ? int.MinValue : nums2[j - 1];
            
            int minX = (i == m) ? int.MaxValue : nums1[i];
            int minY = (j == n) ? int.MaxValue : nums2[j];
            if(minX>=maxY&&minY>=maxX){
                return (m+n)%2==0 ? (Math.Max(maxX,maxY)+Math.Min(minX,minY))/2.0:
                    Math.Max(maxX,maxY);
            }
            else if(maxX>maxY) x2=i-1;
            else x1=i+1;
        }
        return 999;
    }
}
