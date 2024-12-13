public class Solution_26 {
    
    public Dictionary<string, List<(string equations, double divideormultiply)>> equations_map = new();
    public HashSet<string> visited = new();
    public int result;

    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        int i=0;
        double[] result = new double[queries.Count];
        foreach(var nodes in equations){
            string left = nodes[0], right = nodes[1];
            equations_map[left] = equations_map.GetValueOrDefault(left,new List<(string,double)>());
            equations_map[right] = equations_map.GetValueOrDefault(right,new List<(string,double)>());
            equations_map[left].Add((right, values[i]));
            equations_map[right].Add((left, 1/values[i++]));
        }
        for(int j=0;j<queries.Count;j++){
            result[j]=Dfs(queries[j][0],queries[j][1]);
            visited.Clear();
        }
        return result;
    }
    public double Dfs(string curr_letter,string search){
        if(!equations_map.ContainsKey(curr_letter)) return-1;
        if (curr_letter == search) return 1;
        visited.Add(curr_letter);
        foreach(var(letter,multiply) in equations_map[curr_letter]){
            if(visited.Contains(letter)) continue;
            double tempResult = Dfs(letter, search);
            if (tempResult != -1) return multiply * tempResult;
        }
        return -1;
    }
}
