public class Daily_Solution_54 {
    public IList<string> StringMatching(string[] words) {
        var result = new List<string>();
        Array.Sort(words,(x, y) => x.Length.CompareTo(y.Length));
        for(int i=0;i<words.Length;i++){
            for(int j=i+1;j<words.Length;j++){
                if(words[j].Contains(words[i])) {
                    result.Add(words[i]);
                    break;
                }
            }
        }
        return result;
    }
}
