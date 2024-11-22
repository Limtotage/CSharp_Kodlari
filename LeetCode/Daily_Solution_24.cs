public class Daily_Solution_24 {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string,int> Equal_Rows = new Dictionary<string,int>();
        foreach(var row in matrix){
            string Flipped = Equalizer(row);
            if(!Equal_Rows.ContainsKey(Flipped)) Equal_Rows[Flipped] = 0;
            Equal_Rows[Flipped]++;
        }
        int max=0;
        foreach(var Raw_Count in Equal_Rows.Values){
            max=Math.Max(max,Raw_Count);
        }
        return max;
    }
    public string Equalizer(int[] row){
        int[] EqualRow = new int[row.Length];
        int baseValue = row[0];
        for(int i=0;i<row.Length;i++){
            EqualRow[i]= (row[i]==baseValue) ? 0:1;
        }
        return string.Join(",", EqualRow);
    }
}
