public class Daily_Solution_34 {
    public string AddSpaces(string s, int[] spaces) {
        var words= new List<string>();
        int prev =0;
        foreach(int k in spaces){
            words.Add(s.Substring(prev,k - prev));
            prev=k;
        }
        words.Add(s.Substring(prev));
        return String.Join(' ',words);
    }
}
