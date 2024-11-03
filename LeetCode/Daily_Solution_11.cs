public class Daily_Solution_11 {
    public bool RotateString(string s, string goal) {
        if(goal.Length!=s.Length) return false;
        if(goal==s) return true;
        for(int i=1;i<s.Length;i++){
            string temp=s.Substring(s.Length - i) + s.Substring(0, s.Length - i);
            if(temp==goal)return true;
        }
        return false;
    }
}
