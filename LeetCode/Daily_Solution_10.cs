public class Daily_Solution_10 {
    public bool IsCircularSentence(string sentence) {
        string[] kelimeler = sentence.Split(" ");
        bool snc = true;
        for(int i=0;i<kelimeler.Length;i++){
            if(i+1<kelimeler.Length){
                if(kelimeler[i][kelimeler[i].Length-1]==kelimeler[i+1][0]){
                    snc=true;
                }
                else return false;
            }
            else{
                if(kelimeler[i][kelimeler[i].Length-1]==kelimeler[0][0]){
                    snc=true;
                }
                else return false;
            }
        }
        return snc;
    }
}
