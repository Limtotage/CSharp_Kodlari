public class Solution_4 {
    public char[][] board;
    public IList<IList<string>> SolveNQueens(int n) {
        board = new char[n][];
        for (int i = 0; i < n; i++) {
            board[i] = new char[n];
            for (int j = 0; j < n; j++) {
                board[i][j] = '.';
            }
        }

        IList<IList<string>> result = new List<IList<string>>();
        Placer(0, n, result);
        return result;
    }

    private void Placer(int row, int n, IList<IList<string>> solutions) {
        if (row == n) {
            solutions.Add(BoardToList());
            return;
        }

        for (int col = 0; col < n; col++) {
            if (CanPlace(col, row)) {
                board[row][col] = 'Q';
                Placer(row + 1, n, solutions); 
                board[row][col] = '.'; 
            }
        }
    }
    public bool CanPlace(int col, int row){
        for (int i = 0; i < row; i++) {
            if (board[i][col] == 'Q')return false;
        }
        for (int i = 1; i <board.Length ; i++) {
            if(row-i>=0 && col-i>=0 && board[row - i][col - i] == 'Q') return false;
            if(row-i>=0 && col+i<board.Length && board[row-i][col+i] == 'Q') return false;
        }

        return true;
    }
    private IList<string> BoardToList() {
        int n = board.Length;
        IList<string> BoardToList = new List<string>();
        for(int i=0;i<n;i++) {
            BoardToList.Add(new string(board[i]));
        }
        return BoardToList;
    }
}
