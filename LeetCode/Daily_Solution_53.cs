public class Daily_Solution_53 {
    public int[] MinOperations(string boxes) {
        int n = boxes.Length;
        int count = boxes[0] == '1' ? 1 : 0;
        int[] left = new int[n],right= new int[n],result= new int[n];

        for (int i = 1; i < n; i++) {
            left[i] = left[i - 1] + count;
            count += boxes[i] == '1' ? 1 : 0;
        }
        count = boxes[n-1] == '1' ? 1 : 0;

        for (int i = n - 2; i >= 0; i--) {
            right[i] = right[i + 1] + count;
            count +=  boxes[i] == '1' ? 1 : 0;
        }
        for (int i = 0; i < n; i++) {
            result[i] = left[i] + right[i];
        }
        return result;
    }
}
