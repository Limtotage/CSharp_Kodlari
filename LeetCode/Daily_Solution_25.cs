public class Daily_Solution_25 {
    public char[][] RotateTheBox(char[][] box) {
        int rows = box.Length;
        int collumns = box[0].Length;
        char[][] result = new char[collumns][];
        for(int i = 0; i < collumns; i++) {
            result[i] = new char[rows];
            Array.Fill(result[i], '.');
        }
        for(int i=0;i<rows;i++){
            int IdealSpot=collumns-1;
            for(int j=collumns-1;j>=0;j--){
                if(box[i][j]=='#'){
                    result[IdealSpot][rows-i-1]='#';
                    IdealSpot--;
                }
                else if(box[i][j]=='*'){
                    result[j][rows-i-1]='*';
                    IdealSpot=j-1;
                }
            }
        }
        return result;
    }
}
