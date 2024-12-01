public class Daily_Solution_32 {
    public bool CheckIfExist(int[] arr) {
        int zero_count= arr.Count(n=>n==0);
        foreach(int i in arr){
            if(i%2==0){
                if(arr.Contains(i/2)&&i!=i/2)return true;
            }
        }
        if(zero_count>1) return true;
        return false;
    }
}
