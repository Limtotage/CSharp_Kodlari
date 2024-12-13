public class Solution_38 {
    public int MinDistance(string word1, string word2) {
        int n=word1.Length,m=word2.Length;
        if(n == 0 || m == 0) return n==0 ? m:n;
        if(word1==word2) return 0;
        int[,] Dp = new int[n+1,m+1];
        for(int i = 0 ;i<=n;i++) Dp[i,0] = i;
        for(int j = 0 ;j<=m;j++) Dp[0,j] = j;
        for(int i=1;i<=n;i++)
        for(int j=1;j<=m;j++){
            int insertion = Dp[i, j - 1] + 1;
            int deletion = Dp[i - 1, j] + 1;
            int substitution = Dp[i - 1, j - 1] + (word1[i - 1] == word2[j - 1] ? 0 : 1);
            Dp[i, j] = Math.Min(insertion, Math.Min(deletion, substitution));
            /*Dp[i,j] = word1[i-1]==word2[j-1] ? 
            Math.Min(Dp[i-1,j]+1,Math.Min(Dp[i,j-1]+1,Dp[i-1,j-1])):
            Math.Min(Dp[i-1,j]+1,Math.Min(Dp[i,j-1]+1,Dp[i-1,j-1]+1));*/
        }
        return Dp[n,m];
    }
}
