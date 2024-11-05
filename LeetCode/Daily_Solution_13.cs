public class Daily_Solution_13 {
    public int MinChanges(string s) {
        char[] c = s.ToCharArray();
        int syc=0;
        for(int i=0;i<c.Length-1;i+=2){
            if(c[i]!=c[i+1])syc++;
        }
        return syc;
    }
}
