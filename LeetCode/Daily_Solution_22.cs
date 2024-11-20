public class Daily_Solution_22 {
    public int TakeCharacters(string s, int k) {
        int[] freq = new int[3];
        if(k==0) return 0;
        foreach(char c in s){
            freq[c-'a']++;
        }
        if(freq[0]<k||freq[1]<k||freq[2]<k) return -1;
        int[] curr = new int[3];
        int max=0,left=0;
        for(int right=0;right<s.Length;right++){
            curr[s[right] - 'a']++;
            while(left<=right&&(curr[0]>freq[0]-k||
                                curr[1]>freq[1]-k||
                                curr[2]>freq[2]-k)){
                curr[s[left++] - 'a']--;
            }
            max = Math.Max(max, right - left + 1);
        }
        return s.Length-max;
    }
}
