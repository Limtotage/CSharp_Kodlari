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
public class Solution_7 {
    private void dfs(TreeNode node, StringBuilder sb) {
        if (node == null) return;
        dfs(node.left, sb);
        if (node.left == null && node.right == null) {
            sb.Append(node.val);
            sb.Append("S");
        }
        dfs(node.right, sb);
    }
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        StringBuilder store1 = new StringBuilder();
        StringBuilder store2 = new StringBuilder();
        dfs(root1,store1);
        dfs(root2,store2);
        return store1.ToString()==store2.ToString();
    }
}
