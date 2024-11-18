public class Daily_Solution_20 {
    public int[] Decrypt(int[] code, int k) {
        int[] result= new int[code.Length];
        int sum=0;
        for(int i=0;i<code.Length;i++){
            sum=0;
            if(k>0){
                for(int j =1;j<=k;j++){
                    sum+=code[(i+j)%code.Length];
                }
            }
            if(k<0){
                for(int j =1;j<=-k;j++){
                    sum+=code[(i-j+code.Length)%code.Length];
                }
            }
            result[i] = sum;
        }
        return result;
    }
}
