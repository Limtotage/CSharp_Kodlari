public class Daily_Solution_50 {
    public int MaxScore(string s) {
        int zc=0,oc=0,max=0;
        int size=s.Length;
        for(int i=0;i<size;i++){
            if(s[i]=='0') zc++;
        }
        for(int i=size-1;i>0;i--){
            if(s[i]=='0') zc--;
            else oc++;
            Console.WriteLine(s[i]);
            max=Math.Max(max,zc+oc);
        }
        return max;
    }
}
