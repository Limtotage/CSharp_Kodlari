/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution_12 {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null || root == p || root == q) return root;
        TreeNode sol = LowestCommonAncestor(root.left,p,q);
        TreeNode sag = LowestCommonAncestor(root.right,p,q);
        if (sol != null && sag != null) return root;
        return sol!=null ? sol:sag;
    }
}
