public class Daily_Solution_16 {
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        int e= (int) Math.Pow(2,maximumBit)-1;
        int[] Xor = new int[nums.Length];
        Xor[0]=nums[0];
        for(int i =1;i<nums.Length;i++){
            Xor[i]=Xor[i-1]^nums[i];
        }
        List<int> rslt=new List<int>();
        for(int i =Xor.Length-1;i>=0;i--){
            rslt.Add(e^Xor[i]);
        }
        return rslt.ToArray();
    }
}
