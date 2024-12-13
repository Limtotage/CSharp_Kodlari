public class Solution_1 {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        backtracking(result,0,0,"",n);
        return result;
    }
    public void backtracking(IList<string> result,int op, int cl,string comb,int max){
        if(op==max&&cl==max){
            result.Add(comb);
            return;
        }
        if(op<max) backtracking(result,op+1,cl,comb+"(",max);
        if(cl<op) backtracking(result,op,cl+1,comb+")",max);
    }
}
