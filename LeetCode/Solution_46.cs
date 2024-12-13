public class Solution_46 {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] answer = new int[n];
        Stack<int> temp = new Stack<int>();
        for(int i=0;i<n;i++){
            while(temp.Count>0&&temperatures[i]>temperatures[temp.Peek()]){
                int previndex = temp.Pop();
                answer[previndex] = i- previndex;
            }
            temp.Push(i);
        }
        return answer;
    }
}
