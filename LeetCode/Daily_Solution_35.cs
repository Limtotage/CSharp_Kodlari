public class Daily_Solution_35{
    public bool CanMakeSubsequence(string str1, string str2) {
        if(str2.Length>str1.Length) return false;
        int i=0,j=0,counter=0;
        while(i<str1.Length&&j<str2.Length){
            int ascii1 = (int)str1[i],ascii2 = (int)str2[j];
            if (ascii1 == ascii2 || (ascii1 == 122 && ascii2 == 97) || (ascii1 + 1 == ascii2))j++; 
            i++;
        }
        return j == str2.Length;
    }
}
