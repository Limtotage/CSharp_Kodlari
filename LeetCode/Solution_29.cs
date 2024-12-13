public class Solution_29 {
    private Dictionary<char, string> phone = new Dictionary<char, string>() {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };

    private List<string> output = new List<string>();
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) {
            return new List<string>();
        }
        backtrack("", digits);
        return output;
    }
    
    public void backtrack(string combination, string nextdigit){
        if(nextdigit.Length==0) output.Add(combination);
        else{
            foreach(char c in phone[nextdigit[0]]){
                backtrack(combination+c,nextdigit.Substring(1));
            }
        }
    }
}
