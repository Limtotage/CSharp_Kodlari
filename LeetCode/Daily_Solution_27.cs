public class Daily_Solution_27 {
    public int SlidingPuzzle(int[][] board) {
        string target ="123450";
        string start = "";
        
        foreach(var row in board){
            foreach(var num in row){
                start+=num.ToString();
            }
        }

        int[][] Swap_Directions=new int[][]{
            new int[] {1, 3},
            new int[] {0, 2, 4},
            new int[] {1, 5},
            new int[] {0, 4},
            new int[] {1, 3, 5},
            new int[] {2, 4},
        };

        Queue<(string State, int moves)> Puzzle_Solver = new Queue<(string, int)>();
        HashSet<string> State_checker = new HashSet<string>();

        Puzzle_Solver.Enqueue((start, 0));
        State_checker.Add(start);

        while(Puzzle_Solver.Count>0){
            var (curr_State,curr_mov)= Puzzle_Solver.Dequeue();
            if (curr_State == target) return curr_mov;
            int Zero_Index = curr_State.IndexOf('0');
            foreach(int Neighbor in Swap_Directions[Zero_Index]){
                char[] swapping_state = curr_State.ToCharArray();
                (swapping_state[Zero_Index],swapping_state[Neighbor])=(swapping_state[Neighbor],swapping_state[Zero_Index]);
                string swapped_State = new string(swapping_state);
                if(!State_checker.Contains(swapped_State)){
                    Puzzle_Solver.Enqueue((swapped_State,curr_mov+1));
                    State_checker.Add(swapped_State);
                }
            }
        }

        return -1;
    }
}
