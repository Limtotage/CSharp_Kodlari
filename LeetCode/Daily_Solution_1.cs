/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Daily_Solution_1 {
    public TreeNode ReplaceValueInTree(TreeNode root) {
        if (root == null) return root;
        Queue<TreeNode> Node_Kuyruk = new Queue<TreeNode>(); 
        Node_Kuyruk.Enqueue(root);
        var levelSums = new List<int>();
        while (Node_Kuyruk.Count > 0) {
            int levelSum = 0;
            int levelSize = Node_Kuyruk.Count;
            for (int i = 0; i < levelSize; ++i) {
                var node = Node_Kuyruk.Dequeue();
                levelSum += node.val;
                if (node.left != null) Node_Kuyruk.Enqueue(node.left);
                if (node.right != null) Node_Kuyruk.Enqueue(node.right);
            }
            levelSums.Add(levelSum);
        }
        Node_Kuyruk.Enqueue(root);
        int LevelIndex=1;
        root.val=0;
        
        while (Node_Kuyruk.Count > 0) {
            int levelSum = 0;
            int levelSize = Node_Kuyruk.Count;
            for (int i = 0; i < levelSize; ++i) {
                var node = Node_Kuyruk.Dequeue();
                int siblingSum =
                    (node.left != null ? node.left.val : 0) +
                    (node.right != null ? node.right.val : 0);
                if (node.left != null) {
                    node.left.val = levelSums.ElementAt(LevelIndex) -
                    siblingSum;
                    Node_Kuyruk.Enqueue(node.left);
                }
                if (node.right != null) {
                    node.right.val = levelSums.ElementAt(LevelIndex) -
                    siblingSum;
                    Node_Kuyruk.Enqueue(node.right);
                }
            }
            ++LevelIndex;
        }
        return root;
    }
}