public class Daily_Solution_9 {
    public string MakeFancyString(string s) {
        Queue<char> myQueue = new Queue<char>();
        StringBuilder res = new StringBuilder();
        int syc=0;
        char last_element=' ';
        foreach(char x in s.ToArray()){
            if (x == last_element) {
                if (syc < 2) {
                    res.Append(x);
                    syc++;
                }
            } 
            else {
                res.Append(x);
                last_element = x;
                syc = 1;
            }       
        }
        return res.ToString();
    }
}
