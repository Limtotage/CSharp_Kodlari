public class Solution_37 {
    int[,] dp;
    int f_fee;
    public int MaxProfit(int[] prices, int fee) {
        dp = new int[prices.Length,2];
        f_fee=fee;
        for(int i=0;i<prices.Length;i++)
        for(int j =0;j<2;j++) dp[i,j]=-1;
        return profitprofit(0,0,prices.Length,prices);
    }
    public int profitprofit(int day, int BuyOrSell,int length,int[] prices){
        if(day==length) return 0;
        if(dp[day,BuyOrSell]!=-1) return dp[day,BuyOrSell];
        var answer = profitprofit(day + 1, BuyOrSell,length,prices);
        if(BuyOrSell==0){
            var buy =  profitprofit(day + 1, 1,length,prices) -prices[day];
            answer = Math.Max(answer, buy);
        }
        else{
            var sell = prices[day] - f_fee + profitprofit(day + 1, 0,length,prices);
            answer = Math.Max(answer, sell);
        }
        dp[day,BuyOrSell] =answer;
        return answer;
    }
}
