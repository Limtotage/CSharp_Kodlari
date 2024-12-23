public class Daily_Solution_46 {
    public int MinimumOperations(TreeNode root) {
        Queue<TreeNode> Bfs = new Queue<TreeNode>();
        int swapping = 0;
        Bfs.Enqueue(root);

        while (Bfs.Count > 0) {
            int size = Bfs.Count;
            List<int> levelval = new List<int>();

            for (int i = 0; i < size; i++) {
                var node = Bfs.Dequeue();
                levelval.Add(node.val);
                if (node.left != null) Bfs.Enqueue(node.left);
                if (node.right != null) Bfs.Enqueue(node.right);
            }

            int[] original = levelval.ToArray();
            int[] sorted = levelval.ToArray();
            Array.Sort(sorted);

            Dictionary<int, int> indexMap = new Dictionary<int, int>();
            for (int i = 0; i < sorted.Length; i++) {
                indexMap[sorted[i]] = i;
            }

            bool[] visited = new bool[original.Length];
            for (int i = 0; i < original.Length; i++) {
                if (visited[i] || indexMap[original[i]] == i) continue;//sayı yerinde mi

                int cycleSize = 0;
                int j = i;

                while (!visited[j]) {// yerinde olmayan sayıdan başlayarak 
                                    //kaç farklı sayıyı değiştirmemizgerektiğini hesaplıyoruz.
                                    //örn indeks 2 değişecek 4 ile 4 ün 5 ile 5 inde 2 ile değişmesi gerekiyor şeklinde
                    visited[j] = true;
                    j = indexMap[original[j]];
                    cycleSize++;
                }

                if (cycleSize > 1) {
                    swapping += cycleSize - 1;//döngü varsa bir eksiği yapmamız gerekn değişim miktarıdır.
                }
            }
        }

        return swapping;
    }
}
