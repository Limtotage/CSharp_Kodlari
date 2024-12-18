public class Daily_Solution_44 {
    public int[] FinalPrices(int[] prices) {
        int[] result = prices;
        Stack<int> mono = new Stack<int>();
        for(int i=0;i<prices.Length;i++){
            while(mono.Count>0&&prices[i]<=prices[mono.Peek()]){
                int index = mono.Pop();
                result[index]=prices[index]-prices[i];
            }
            mono.Push(i);
        }
        return result;
    }
}
