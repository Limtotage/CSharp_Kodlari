public class Solution_6 {
    public List<IList<string>> result;
    public IList<IList<string>> Partition(string s) {
        result = new List<IList<string>>();
        backtrack(s,new List<string>(),0);
        return result;
    }
    public void backtrack(string words,List<string> subs,int start){
        if (start == words.Length) {
            result.Add(new List<string>(subs));
            return;
        }
        for (int i = start; i < words.Length; i++) {
            string substring = words.Substring(start, i - start + 1);

            if (IsPalindrome(substring)) {
                subs.Add(substring); 
                backtrack(words, subs, i + 1); 
                subs.RemoveAt(subs.Count - 1); 
            }
        }
    }
    private bool IsPalindrome(string str) {
        int left = 0, right = str.Length - 1;

        while (left < right) {
            if (str[left] != str[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
