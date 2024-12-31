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
public class Solution_15 {
    public bool IsSymmetric(TreeNode root) {
        return isMirror(root.left,root.right);
    }
    public bool isMirror(TreeNode Node_L, TreeNode Node_R){
        if(Node_L==null&&Node_R==null) return true;
        if(Node_L==null||Node_R==null) return false;
        return Node_L.val==Node_R.val && isMirror(Node_L.left,Node_R.right) && isMirror(Node_L.right,Node_R.left);
    }
}
