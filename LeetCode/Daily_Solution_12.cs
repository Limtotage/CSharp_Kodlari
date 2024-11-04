public class Daily_Solution_12 {
    public string CompressedString(string word) {
        if(word.Length==0) return "";
        StringBuilder rslt = new StringBuilder(); 
        int i=0;
        while (i < word.Length) {
            char c = word[i];
            int syc = 0;
            while (i < word.Length && word[i] == c && syc < 9) {
                syc++;
                i++;
            }
            rslt.Append(syc.ToString());
            rslt.Append(c);
        }
        return rslt.ToString();
    }
}
