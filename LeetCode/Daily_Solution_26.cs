public class Daily_Solution_26 {
    public long MaxMatrixSum(int[][] matrix) {
        int n=matrix.Length,m=matrix[0].Length,negative_counter=0,min=int.MaxValue;
        long sum=0;
        for(int i=0;i<n;i++)
        for(int j=0;j<m;j++){
            if(matrix[i][j]<0)negative_counter++;
            int abs=Math.Abs(matrix[i][j]);
            min=Math.Min(min,abs);
            sum+=abs;
        }
        return negative_counter%2==0 ? sum:sum-2*min;
    }
}
