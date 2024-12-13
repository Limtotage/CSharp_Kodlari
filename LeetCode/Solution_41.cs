public class Solution_41 {
    public int String_bits(int x){
        int count=0;
        while(x>0) {
            if(x%2==1) count++;
            x/=2;
        }
        return count;
    }
    public int MinFlips(int a, int b, int c) {
        int mask = (a | b) ^ c;
        return String_bits(mask)+ String_bits(mask&a&b);
    }
}
