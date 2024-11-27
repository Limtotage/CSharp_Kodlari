public class Daily_Solution_29 {
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries) {
        int[] result =new int[queries.Length];
        List<int>[] graph = new List<int>[n];
        for(int i=0;i<n;i++) graph[i] = new List<int>();

        for(int i=0;i<n-1;i++)  graph[i].Add(i+1);
        int j=0;
        foreach(var rows in queries){
            int a=rows[0], b=rows[1];
            graph[a].Add(b);
            result[j++]=BFS(graph,n-1);
        }
        return result;
    }
    public int BFS(List<int>[] Graph,int last){
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[Graph.Length];
        int[] distance = new int[Graph.Length];
        queue.Enqueue(0);
        visited[0]=true;
        while(queue.Count>0){
            int cur=queue.Dequeue();
            foreach(var neighbor in Graph[cur]){
                if(!visited[neighbor]){
                    queue.Enqueue(neighbor);
                    visited[neighbor]=true;
                    distance[neighbor] = distance[cur] + 1; 
                    if(neighbor==last) return distance[neighbor];
                }
            }
        }
        return -1;
    }
}
