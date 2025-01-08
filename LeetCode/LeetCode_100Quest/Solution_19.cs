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
public class Solution_19 {
    public void Flatten(TreeNode root) {
        Stack<TreeNode> sapling = new();
        sapling.Push(root);
        TreeNode prev =null;
        while(sapling.Count>0){
            var node = sapling.Pop();
            if(node!=null){
                if(node.right!=null)sapling.Push(node.right);
                if(node.left!=null) sapling.Push(node.left);
                if(prev!=null){
                    prev.right=node;
                    prev.left=null;
                }
            }
            prev=node;
        }
    }
}
