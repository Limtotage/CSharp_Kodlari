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
public class Solution_8 {
    public int say=0;
    public int GoodNodes(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null&&root.right == null) return 1;
        count(root,root.val);
        return say;
    }
    public void count(TreeNode root,int max) {
        if(root==null){
            return;
        }
        if (root.val>=max){
            say++;
            max=root.val;
        }
        count(root.left,max);
        count(root.right,max);
    }
}
