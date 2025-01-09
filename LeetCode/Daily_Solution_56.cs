public class Daily_Solution_56 {
    public int PrefixCount(string[] words, string pref) {
        int count =0;
        foreach(string word in words){
            count+=word.StartsWith(pref) ? 1:0;
        }
        return count;
    }
}
