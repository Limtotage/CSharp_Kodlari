public class Daily_Solution_14 {
    public int HwMnyOne(int num){
        int rslt = 0;
        while(num>0){
            rslt+=num%2;
            num/=2;
        }
        return rslt;
    }
    public bool CanSortArray(int[] nums) {
        int PrevMax=0,CurMax=nums[0],CurMin=nums[0],One_Count=HwMnyOne(nums[0]);
        for(int i=1;i<nums.Length;i++){
            int Nw_One_Count=HwMnyOne(nums[i]);
            if(One_Count==Nw_One_Count){
                CurMax=Math.Max(CurMax,nums[i]);
                CurMin=Math.Min(CurMin,nums[i]);
            }
            else{
                if(PrevMax>CurMin) return false;
                One_Count=Nw_One_Count;
                PrevMax= CurMax;
                CurMax=nums[i];
                CurMin=nums[i];
                
            }
        }
        return PrevMax>CurMin ? false: true;
    }
}
