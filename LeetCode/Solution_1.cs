public class Solution_1 {
    public string PredictPartyVictory(string senate) {
        if(!senate.Contains("R")) return "Dire";
        if(!senate.Contains("D")) return "Radiant";
        Queue<char> queue = new Queue<char>(senate.ToCharArray());
        char temp;
        int scr=0,scd=0;
        while(queue.Count>0){
            if(!queue.Contains('R')) return "Dire";
            if(!queue.Contains('D')) return "Radiant";
            temp = queue.Dequeue();
            if(temp=='R'&&scd==0) {
                scr+=1;
                queue.Enqueue('R');
            }
            if(temp=='D'&&scr==0) {
                scd+=1;
                queue.Enqueue('D');
            }
            if(scr>0&&temp=='D'){
                scr--;
            }
            if(scd>0&&temp=='R'){
                scd--;
            }
        }
        return "Nee";
    }
}
