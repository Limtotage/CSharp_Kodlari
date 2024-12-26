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
public class Solution_12 {
    public int result = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        Solver(root);
        return result;
    }
    public int Solver(TreeNode node){
        if(node==null) return 0;
        int leftSide = Math.Max(Solver(node.left),0);
        int RightSide = Math.Max(Solver(node.right),0);
        int totalpath= node.val+leftSide+RightSide;
        result = Math.Max(totalpath,result);
        return node.val+Math.Max(leftSide,RightSide);
    }

}
