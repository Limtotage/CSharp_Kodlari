public class Solution_25 {// sadece parentı ve cityi versek nasıl olur.
    public Dictionary<int, List<(int destination, bool direction)>> city_map = new();
    public HashSet<int> visited = new();
    public int result;

    public int MinReorder(int n, int[][] connections) {
        foreach(var connect in connections){
            int city_start = connect[0], city_target = connect[1];
            city_map[city_start] = city_map.GetValueOrDefault(city_start,new List<(int,bool)>());
            city_map[city_target] = city_map.GetValueOrDefault(city_target,new List<(int,bool)>());
            city_map[city_start].Add((city_target, true));
            city_map[city_target].Add((city_start, false));
        }
        Dfs(0);
        return result;
    }
    public void Dfs(int curr_city){
        visited.Add(curr_city);
        foreach(var(target,direction) in city_map[curr_city]){
            if(visited.Contains(target)) continue;
            if(direction) result++;
            Dfs(target);
        }
    }

}
