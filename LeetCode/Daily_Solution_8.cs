public class Daily_Solution_8 {
    public int MinimumMountainRemovals(int[] nums) {
        int N=nums.Length;
        if(N<3) return N;
        int[] Lisdp = new int[N];
        int[] Ldsdp = new int[N];
        Array.Fill(Lisdp, 1);
        Array.Fill(Ldsdp, 1);
        int k=N-2,l=0;
        for(int i=1;i<N;i++){
            l=k+1;
            for(int j=i-1;j>=0;j--){
                if(nums[i]>nums[j]){
                    Lisdp[i]=Math.Max(Lisdp[i],Lisdp[j]+1);
                }
                if(nums[k]>nums[l]){
                    Ldsdp[k]=Math.Max(Ldsdp[k],Ldsdp[l]+1);
                }
                l++;
            }
            k--;
        }
        /* Yukarıda L ve K bu döngü gibi çalışıyor.
        for(int i=N-2;i>=0;i--){
            for(int j=i+1;j<N;j++){
                if(nums[i]>nums[j]){
                    Ldsdp[i]=Math.Max(Ldsdp[i],Ldsdp[j]+1);
                }
            }
        }*/
        int rmv = Int32.MaxValue;
        for(int i =0;i<N;i++){
            if(Ldsdp[i]>1 &&Lisdp[i]>1 ){
                rmv=Math.Min(rmv,N-Ldsdp[i]-Lisdp[i]+1);
            }
        }
        return rmv;
    }
}
