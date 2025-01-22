public class Solution_23 {
    public int middlesearcher(string s, int start,int end){
        while(start>=0 && end<s.Length && s[start]==s[end]){
            start--;
            end++;
        }
        return end-start-1;
    }
    public string LongestPalindrome(string s) {
        if(s==null) return "";
        int start = 0;
        int end = 0;
        for(int i=0;i<s.Length;i++){
            int oddpalind=middlesearcher(s,i,i);
            int evenpalind=middlesearcher(s,i,i+1);
            int max = Math.Max(oddpalind,evenpalind);
            if(max>end-start+1){
                start=i-(max-1)/2;
                end=i+max/2;
            }
        }
        return s.Substring(start,end-start+1);
    }
}
