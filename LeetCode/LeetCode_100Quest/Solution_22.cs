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
public class Solution_22 {
    public int DiameterOfBinaryTree(TreeNode root) {
        int maxdepth=0;
        DFS(root,ref maxdepth);
        return maxdepth;
    }
    public int DFS(TreeNode node,ref int depth){
        if(node==null) return 0;
        int rightdepth=0,leftdepth=0;
        if(node.left!=null){
            leftdepth = DFS(node.left,ref depth);
        }
        if(node.right!=null){
            rightdepth = DFS(node.right,ref depth);
        }
        depth = Math.Max(depth,rightdepth+leftdepth);
        return Math.Max(rightdepth,leftdepth)+1;
    }
    
}
