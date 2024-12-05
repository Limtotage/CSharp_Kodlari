public class Daily_Solution_36 {
    public bool CanChange(string start, string target) {
        if (start.Replace("_", "") != target.Replace("_", ""))return false;
        bool[] changed = new bool[start.Length];
        bool ifound =false;
        for(int i =0;i<target.Length;i++){
            ifound=false;
            if(target[i]=='L'){
                for(int j = i;j<target.Length;j++){
                    if(start[j]=='R') return false;
                    else if( start[j]=='L' && !changed[j]){
                        changed[j] = true;
                        ifound=true;
                        break;
                    }
                }
                if(!ifound) return false;
            }
            else if(target[i]=='R'){
                for(int j = i;j>=0;j--){
                    if( start[j]=='L')return false;
                    else if(start[j]=='R'&&!changed[j]) {
                        changed[j] = true;
                        ifound=true;
                        break;
                    }
                }
                if(!ifound) return false;
            }
        }
        return true;
    }
}
/* 
public class Solution {
    public bool CanChange(string start, string target) {
        if (start.Replace("_", "") != target.Replace("_", "")) {
            return false;
        }

        int sIndex = 0, tIndex = 0;
        while (sIndex < start.Length && tIndex < target.Length) {
            while (sIndex < start.Length && start[sIndex] == '_') sIndex++;
            while (tIndex < target.Length && target[tIndex] == '_') tIndex++;

            if (sIndex == start.Length && tIndex == target.Length) return true;
            if (sIndex == start.Length || tIndex == target.Length) return false;

            if (start[sIndex] != target[tIndex]) return false;

            if (start[sIndex] == 'L' && sIndex < tIndex) return false;
            if (start[sIndex] == 'R' && sIndex > tIndex) return false;

            sIndex++;
            tIndex++;
        }
        return true;
    }
}
*/
