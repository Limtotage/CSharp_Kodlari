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
 * } En Gıcık Soru
 */
public class Solution_10 {
    public int PathSum(TreeNode root, int targetSum) {
        if(root == null) return 0;
        return Dfs(root, targetSum)+ PathSum(root.left, targetSum)+ PathSum(root.right, targetSum);
        int Dfs(TreeNode node, long toplam)
        {
            var top = node.val == toplam ? 1 : 0;
            if(node.left != null) top += Dfs(node.left, toplam-node.val);
            if(node.right != null) top += Dfs(node.right, toplam-node.val);
            return top;
        }
    }
}
