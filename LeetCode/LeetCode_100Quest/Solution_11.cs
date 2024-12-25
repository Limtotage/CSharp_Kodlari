public class Solution_11 {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row= matrix.Length,col= matrix[0].Length;
        int low = 0, high = row*col - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if(matrix[mid/col][mid%col]==target) return true;
            if (matrix[mid/col][mid%col] > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        return false;
    }
}
