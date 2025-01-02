public class Daily_Solution_51 {
    public bool StartEndVow(string word){
        return "aeiou".Contains(word[0])&&"aeiou".Contains(word[word.Length-1]);
    }
    public int[] VowelStrings(string[] words, int[][] queries) {
        int n = words.Length;
        int[] prefixSum = new int[n + 1]; 
        for (int i = 0; i < n; i++) {
            prefixSum[i + 1] = prefixSum[i] + (StartEndVow(words[i]) ? 1 : 0);
        }
        int[] result = new int[queries.Length];
        for(int i=0;i<queries.Length;i++){
            int start = queries[i][0];
            int end = queries[i][1];
            result[i]= prefixSum[end+1]-prefixSum[start];
        }
        return result;
    }
}
