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
public class Solution_17 {
    public int preorderIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return BuildSubTree(preorder,inorder,0,inorder.Length-1);
    }
    private TreeNode BuildSubTree(int[] preorder, int[] inorder, int left, int right) {
        if(left>right) return null;
        int val = preorder[preorderIndex++];
        TreeNode root = new TreeNode(val);
        int inorderIndex = Array.IndexOf(inorder,val);
        root.left = BuildSubTree(preorder,inorder,left,inorderIndex-1);
        root.right = BuildSubTree(preorder,inorder,inorderIndex+1,right);
        return root;
    }
}
