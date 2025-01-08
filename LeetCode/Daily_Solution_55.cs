public class Solution {
    public bool isprefix(string s1,string s2){
        if(s1.Length>s2.Length) return false;
        for(int i =0;i<s1.Length;i++){
            if(s1[i]!=s2[i]) return false;
        }
        return true;
    }
    public bool issuffix(string s1,string s2){
        if(s1.Length>s2.Length) return false;
        for(int i =1;i<=s1.Length;i++){
            if(s1[^i]!=s2[^i]) return false;
        }
        return true;
    }
    public int CountPrefixSuffixPairs(string[] words) {
        int count =0;
        for(int i=0;i<words.Length-1;i++){
            for(int j = i+1;j<words.Length;j++){
                if(issuffix(words[i],words[j])&&isprefix(words[i],words[j])) count++;
            }
        }
        return count;
    }
}
