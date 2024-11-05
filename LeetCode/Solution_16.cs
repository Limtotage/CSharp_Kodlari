public class Solution_16 {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        bool[] chack = new bool[rooms.Count];
        Dfs(0);
        return chack.All(c=>c);
        void Dfs(int index){
            if(chack[index]) return;
            chack[index]=true;
            foreach(int key in rooms[index]){
                Dfs(key);
            }
        }
    }
    
}
